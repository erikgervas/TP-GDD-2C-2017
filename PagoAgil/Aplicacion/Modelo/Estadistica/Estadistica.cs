using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Modelo.Estadistica
{
    public class Estadistica
    {

        string nombre;
        string funcion;
        string[] columnas;

        public Estadistica(string nombre, string funcion, string[] columnas)
        {
            this.nombre = nombre;
            this.funcion = funcion;
            this.columnas = columnas;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getFuncion()
        {
            return this.funcion;
        }

        public string[] getColumnas()
        {
            return this.columnas;
        }

        public string getFuncionArmada(int anio, int trimestre)
        {

            return this.funcion + "(" + anio + ", " + trimestre + ")";

        }
        
        public override string ToString()
        {
            return this.nombre;
        }
        
    }
}
