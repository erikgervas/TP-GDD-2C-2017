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

        public Estadistica[] obtenerEstadisticas()
        {

            return GestorDeEstadisticas.getInstance().obtenerEstadisticas();

        }

        public void trimestre(int trimestre)
        {

            GestorDeEstadisticas.getInstance().asignarTrimestre(trimestre);

        }

        public Boolean esCalculable()
        {

            return GestorDeEstadisticas.getInstance().esCalculable();

        }


        public void agregarColumna(string p)
        {
            GestorDeEstadisticas.getInstance().agregarColumna(p);
        }

        public void quitarColumna(string p)
        {
            GestorDeEstadisticas.getInstance().quitarColumna(p);
        }

        public List<System.Windows.Forms.CheckBox> obtenerCheckboxes(Estadistica estadisticaElegida)
        {

            GestorDeEstadisticas.getInstance().elegir(estadisticaElegida);

            return CreadorDeVistas.getInstance().crearCheckboxes(estadisticaElegida);
            
        }

        internal System.Data.DataTable calcularEstadistica(string anio)
        {

            return GestorDeEstadisticas.getInstance().calcularEstadistica(anio);

        }
    }
}
