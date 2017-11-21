using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Modelo.ClienteSQL
{
    public class RolDB : Entidad
    {

        string nombre;
        Boolean habilitado;

        public RolDB(FilaDTO fila)
        {

            List<string> elementos = fila.obtener();

            this.id = long.Parse(elementos.ElementAt(0));
            this.nombre = elementos.ElementAt(1);
            this.habilitado = elementos.ElementAt(2).Equals("True") ? true : false;

        }

        public static Rol generar(long id ,TablaDTO tablaDTO)
        {

            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            for (int i = 0; i < tablaDTO.cantidadDeFilas(); i++)
            {

                FilaDTO filaDTO = tablaDTO.obtener(i);

                List<string> elementos = filaDTO.obtener();

                Funcionalidad funcionalidad = new Funcionalidad(elementos.ElementAt(1));

                funcionalidades.Add(funcionalidad);

            }

            return new Rol((int)id,tablaDTO.obtener(0).obtener().ElementAt(0), funcionalidades);

        }

        public override string ToString()
        {
            return this.nombre;
        }

        public Boolean getHabilitado()
        {
            return this.habilitado;
        }

    }
}
