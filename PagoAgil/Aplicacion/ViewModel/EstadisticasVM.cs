using PagoAgil.Aplicacion.Modelo.Estadistica;
using PagoAgil.Aplicacion.Orquestradores;
using PagoAgil.Aplicacion.Orquestradores.Estadisticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.ViewModel
{
    public class EstadisticasVM
    {

        GestorDeEstadisticas gestorDeEstadisticas = new GestorDeEstadisticas();

        public Estadistica[] obtenerEstadisticas()
        {

            return gestorDeEstadisticas.obtenerEstadisticas();

        }

        public void trimestre(int trimestre)
        {

            gestorDeEstadisticas.asignarTrimestre(trimestre);

        }

        public Boolean esCalculable()
        {

            return gestorDeEstadisticas.esCalculable();

        }


        public void agregarColumna(string p)
        {
            gestorDeEstadisticas.agregarColumna(p);
        }

        public void quitarColumna(string p)
        {
            gestorDeEstadisticas.quitarColumna(p);
        }

        public List<System.Windows.Forms.CheckBox> obtenerCheckboxes(Estadistica estadisticaElegida)
        {

            gestorDeEstadisticas.elegir(estadisticaElegida);

            return CreadorDeVistas.getInstance().crearCheckboxes(estadisticaElegida);
            
        }

        internal System.Data.DataTable calcularEstadistica(string anio)
        {

            return gestorDeEstadisticas.calcularEstadistica(anio);

        }
    }
}
