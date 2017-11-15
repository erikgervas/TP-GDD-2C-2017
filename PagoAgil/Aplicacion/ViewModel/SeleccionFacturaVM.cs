using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo;
using System.Data;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.View.Pago.Excepciones;
using PagoAgil.Aplicacion.BD.Utils;
using System.Data.SqlClient;

namespace PagoAgil.Aplicacion.ViewModel
{
    class SeleccionFacturaVM
    {
        public List<string> empresas { get; set; }

        public DataTable buscarFactura(int numeroFactura,long idEmpresa, DateTime fechaVencimiento)
        {
            DataTable factura = obtenerFacturaPorNroEmpresaYFechaVenc(numeroFactura, idEmpresa, fechaVencimiento);

            if (factura.Rows.Count == 0) throw new FacturaInvalidaException("Factura invalida");

            return factura;
        }

        public EmpresaDB[] obtenerEmpresas() 
        {
            List<EmpresaDB> empresas = new List<EmpresaDB>();

            TablaDTO tabla = LectorDeTablas.getInstance().obtener("SELECT * FROM SQL_BOYS.Empresa");
            FilaDTO fila;

            for (int i = 0; i < tabla.cantidadDeFilas(); i++)
            {
                fila = tabla.obtener(i);
                empresas.Add(new EmpresaDB(fila));
            }

            return empresas.ToArray();
        }

        public DataTable obtenerFacturaPorNroEmpresaYFechaVenc(int numeroFactura, long idEmpresa, DateTime fechaVencimiento)
        {
            DateTime datevalue = (Convert.ToDateTime(fechaVencimiento.ToString()));

            String dia = datevalue.Day.ToString();
            String mes = datevalue.Month.ToString();
            String anio = datevalue.Year.ToString();

            string query = "obtenerFactura(" + numeroFactura + "," + idEmpresa + "," + dia + "," + mes + "," + anio + ")";

            return LectorDeTablas.getInstance().obtenerMejorado(query);
        }

        public void crearPago(PagoDB pago, List<int> facturasPagadas)
        {
            int numeroPago;
            SqlCommand cmd = new SqlCommand("SELECT SQL_BOYS.obtenerProximoNroPago()", Conexion.getInstance().obtenerConexion());
            numeroPago = int.Parse(cmd.ExecuteScalar().ToString());

            Insertador.getInstance().insertarPago(pago);

            for (int i = 0; i < facturasPagadas.Count ;i++)
            {
                SqlCommand cmd2 = new SqlCommand("SQL_BOYS.insertarItemPagoDeFactura", Conexion.getInstance().obtenerConexion());

                cmd2.CommandType = CommandType.StoredProcedure;

                cmd2.Parameters.AddWithValue("@nroPago", DbType.Int32).Value = numeroPago;
                cmd2.Parameters.AddWithValue("@nroFactura", DbType.Int32).Value = facturasPagadas.ElementAt(i);

                cmd2.ExecuteNonQuery();
            }
        }

    }
}
