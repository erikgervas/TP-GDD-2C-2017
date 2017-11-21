using PagoAgil.Aplicacion.Modelo.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.View;

namespace PagoAgil.Aplicacion.View
{
    public class HomeVM
    {
        FormHome homeObservadora;

        public HomeVM(FormHome _home) 
        {
            homeObservadora = _home;
        }

        public void notificarCambios() 
        {
            homeObservadora.actualizarBotonesDeFuncionalidades();
        }


    }
}
