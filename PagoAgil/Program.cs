using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Orquestradores;
using PagoAgil.Aplicacion.View;
using System;
using System.Windows.Forms;
using PagoAgil.Aplicacion.View.Sucursales;
using PagoAgil.Aplicacion.View.Empresas;
using PagoAgil.Aplicacion;
using PagoAgil.Aplicacion;
using PagoAgil.Aplicacion.View.Pago;


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
            Application.Run(new FormSeleccionFacturas(new PagoBuilder()));

        }
    }
}
