using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes.Medios
{
    public abstract class MedioBD<DTO> : Medio<DTO>
    {
        protected abstract string nombreTabla();

        protected abstract List<Parametro> listaDeParametros(DTO unaEntidad);

        public DataTable darTabla()
        {
            return LectorDeTablas.getInstance().obtenerMejorado(this.todasLasColumnas() + this.nombreTabla());
        }

        public DataTable darTablaFiltrados(List<Parametro> parametros)
        {
            return this.ejecutarFuncion("filtrar", parametros);
        }

        public void aniadir(DTO unaEntidad)
        {
            this.ejecutarProcedimiento("altaDe", this.listaDeParametros(unaEntidad));
        }

        public void eliminar(DTO unaEntidad)
        {
            this.ejecutarProcedimiento("bajaDe", this.listaDeParametros(unaEntidad));
        }

        public void modificar(DTO unaEntidad)
        {
            this.ejecutarProcedimiento("modificacionDe", this.listaDeParametros(unaEntidad));
        }

        public DataTable ejecutarFuncion(String funcion, List<Parametro> parametros)
        {
            SqlCommand comando = new SqlCommand(this.todasLasColumnas() + funcion + this.nombreTabla() + ParametroFactory.generarTextoParametros(parametros), Conexion.getInstance().obtenerConexion());

            comando.CommandType = CommandType.Text;

            foreach (Parametro unParametro in parametros) comando.Parameters.Add(unParametro.nombre, unParametro.tipo).Value = unParametro.valor;

            DataTable tabla = new DataTable();

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(tabla);

            return tabla;
        }

        public void ejecutarProcedimiento(String procedimiento, List<Parametro> parametros)
        {
            SqlCommand comando = new SqlCommand(this.esquema() + procedimiento + this.nombreTabla(), Conexion.getInstance().obtenerConexion());

            comando.CommandType = CommandType.StoredProcedure;

            foreach (Parametro unParametro in parametros) comando.Parameters.Add(unParametro.nombre, unParametro.tipo).Value = unParametro.valor;

            comando.ExecuteNonQuery();
        }

        protected virtual string select(string[] columnas)
        {
            String columnasElegidas = "t.";

            int i = 0;

            foreach (string columna in columnas)
            {
                columnasElegidas += columna + ((i < columnas.Count() - 1) ? ", t." : "");

                i++;
            }

            return "SELECT " + columnasElegidas + " FROM " + this.esquema() + this.nombreTabla() + " t";
        }

        protected virtual string esquema()
        {
            return "SQL_BOYS.";
        }

        protected virtual string todasLasColumnas()
        {
            return "SELECT * FROM " + esquema();
        }

        protected abstract DTO rellenarFila(List<String> elementos);

        public List<DTO> darTodos()
        {
            return realizarConsulta(this.todasLasColumnas() + this.nombreTabla());
        }

        public long asignarId()
        {
            throw new NotImplementedException();
        }

        protected List<DTO> realizarConsulta(String consulta)
        {
            TablaDTO tabla = LectorDeTablas.getInstance().obtener(consulta);

            FilaDTO fila;

            List<DTO> objetos = new List<DTO>();

            int cant = tabla.cantidadDeFilas();

            for (int i = 0; i < cant; i++)
            {

                fila = tabla.obtener(i);

                objetos.Add(this.generarFila(fila));
            }

            return objetos;

        }

        protected DTO generarFila(FilaDTO fila)
        {
            List<String> elementos = fila.obtener();

            return this.rellenarFila(elementos);
        }
    }
}
