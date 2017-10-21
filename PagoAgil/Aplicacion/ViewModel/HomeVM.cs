using PagoAgil.Aplicacion.Modelo.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.ViewModel
{
    class HomeVM
    {

        Usuario usuarioLoggeado;

        public HomeVM(Usuario usuario)
        {
            this.usuarioLoggeado = usuario;
        }


    }
}
