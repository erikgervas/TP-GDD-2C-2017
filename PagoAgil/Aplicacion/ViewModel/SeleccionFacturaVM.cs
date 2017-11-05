using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo;
using System.Data;

namespace PagoAgil.Aplicacion.ViewModel
{
    class SeleccionFacturaVM
    {

        public DataTable buscarFactura(int numeroFactura,long idEmpresa, DateTime fechaVencimiento)
        {
            return RepositorioFacturas.getInstancia().getAlmacenamiento().obtenerFacturaPorNroEmpresaYFechaVenc(numeroFactura,idEmpresa,fechaVencimiento);
        }

    }
}
