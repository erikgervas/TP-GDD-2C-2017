using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo;
using System.Data;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.BD;

namespace PagoAgil.Aplicacion.ViewModel
{
    class SeleccionFacturaVM
    {
        public List<string> empresas { get; set; }

        public void buscarFactura(int numeroFactura,long idEmpresa, DateTime fechaVencimiento)
        {
            DataTable factura;
            //return RepositorioFacturas.getInstancia().getAlmacenamiento().obtenerFacturaPorNroEmpresaYFechaVenc(numeroFactura,idEmpresa,fechaVencimiento);
            //return factura;
        }

        public void obtenerEmpresas() 
        {
           empresas = (List<string>) RepositorioEmpresas.instanciar().listarElementos().Select(e => e.ToString());
        }

    }
}
