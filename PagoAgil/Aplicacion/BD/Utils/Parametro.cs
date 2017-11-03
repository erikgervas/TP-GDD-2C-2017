using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.BD.Utils
{
    public class Parametro
    {
        public string nombre { get; set; }
        public SqlDbType tipo { get; set; }
        public object valor { get; set; }

        public Parametro (string unNombre, SqlDbType unTipo, object unValor)
        {
            this.nombre = "@" + unNombre;
            this.tipo = unTipo;
            this.valor = unValor;
        }

    }
}
