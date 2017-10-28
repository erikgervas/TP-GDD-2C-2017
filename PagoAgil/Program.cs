using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.View;
using System;
using System.Windows.Forms;

namespace PagoAgil
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

        }
    }
}
