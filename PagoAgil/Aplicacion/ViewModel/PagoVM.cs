using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.View.Pago.Excepciones;

namespace PagoAgil.Aplicacion.ViewModel
{
    class PagoVM
    {
        public MedioDePago[] obtenerMediosDePago()
        {

            List <MedioDePago> medios = new List<MedioDePago>();

            TablaDTO tabla = LectorDeTablas.getInstance().obtener("SELECT * FROM SQL_BOYS.Medio_De_Pago");
            FilaDTO fila;

            for(int i = 0; i < tabla.cantidadDeFilas(); i++)
            {
               fila = tabla.obtener(i);
               medios.Add(new MedioDePago(fila));
            }

            return medios.ToArray();

        }

        public int revisarCliente(int DNI) 
        {
            string query = "SELECT * FROM SQL_BOYS.existeCliente(" + DNI + ")";
            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            if (tabla.cantidadDeFilas() == 0) throw new NoExisteClienteException("No existe el cliente");

            //Esto quiere decir que el cliente está deshabilitado, por lo que no puede haber pagos a su nombre
            if (tabla.getFilas().ElementAt(0).obtener().ElementAt(1) == "false") throw new ClienteDeshabilitadoException("Cliente deshabilitado");

            return DNI;
        }

    }
}
