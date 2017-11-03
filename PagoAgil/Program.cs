using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Orquestradores;
using PagoAgil.Aplicacion.View;
using System;
using System.Windows.Forms;
using PagoAgil.Aplicacion.View.Sucursales;

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
            Bootstrap.iniciarComponentes();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());

        }
    }
}
