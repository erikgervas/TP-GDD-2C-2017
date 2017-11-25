using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.View.Pago;

namespace PagoAgil.Aplicacion.ViewModel
{
    class BuscarClientesVM
    {
        FormPago miForm = new FormPago();

        public BuscarClientesVM(FormPago form) 
        {
            miForm = form;
        } 


        public DataTable traerClientes() 
        {
            return LectorDeTablas.getInstance().obtenerMejorado("Cliente WHERE habilitadx = 1");
        }

        public void notificarCambio(int DNI) 
        {
            miForm.ponerDNI(DNI);
        }

    }
}
