using PagoAgil.Aplicacion;
using PagoAgil.Aplicacion.Orquestradores;
using PagoAgil.Aplicacion.View;
using PagoAgil.Aplicacion.View.Empresas;
using PagoAgil.Aplicacion.View.Facturas;
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
            Bootstrap.iniciarComponentes();

            if (!Configuracion.esConsistente())
                throw new ArgumentException("La configuración no es correcta");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FacturaSeleccionadorABM());

        }
    }
}
