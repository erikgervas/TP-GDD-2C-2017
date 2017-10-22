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
<<<<<<< HEAD

            Application.Run(new FormLogin());
=======
            Application.Run(new FormHome());
>>>>>>> 569c238ffde73fa3ffe113c22d57b8cb55f46f54
        }
    }
}
