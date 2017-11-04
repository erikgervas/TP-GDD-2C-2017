using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace PagoAgil.Aplicacion.Orquestradores
{
    public class CreadorDeVistas
    {

        private static CreadorDeVistas instance = new CreadorDeVistas();

        private CreadorDeVistas() { }

        public static CreadorDeVistas getInstance()
        {

            return instance;

        }


        public List<CheckBox> crearCheckboxes(Modelo.Estadistica.Estadistica estadisticaElegida)
        {

            string[] columnas = estadisticaElegida.getColumnas();

            int mitadIzquierda = columnas.Length / 2;

            List<CheckBox> checkboxes = new List<CheckBox>();

            for (int i = 0; i < mitadIzquierda; i++)
            {

                CheckBox checkbox = this.crearCheckbox(columnas[i]);

                checkbox.Location = new Point(25, (i + 1) * 100); // Vertical
                checkbox.Location = new Point((i + 1) * 150, 25); // Horizontal

                checkboxes.Add(checkbox);

            }

            for (int i = mitadIzquierda; i < columnas.Length; i++)
            {

                CheckBox checkbox = this.crearCheckbox(columnas[i]);

                checkbox.Location = new Point(75, (i + 1 - mitadIzquierda) * 100); // Vertical
                checkbox.Location = new Point((i + 1 - mitadIzquierda) * 150, 75); // Horizontal
                
                checkboxes.Add(checkbox);

            }

            return checkboxes;

        }

        private CheckBox crearCheckbox(string texto)
        {
            CheckBox checkbox = new CheckBox();
            checkbox.Tag = texto;
            checkbox.Text = texto;
            checkbox.AutoSize = true;
            checkbox.Checked = true;

            return checkbox;
        }

    }
}
