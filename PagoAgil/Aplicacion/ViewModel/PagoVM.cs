using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.BD;

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

    }
}
