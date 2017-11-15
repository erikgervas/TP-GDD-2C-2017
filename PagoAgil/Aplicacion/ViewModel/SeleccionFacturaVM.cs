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

    }
}
