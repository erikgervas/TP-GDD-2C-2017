using PagoAgil.Aplicacion.BD;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion
{
    public class Configuracion
    {

        public static Boolean esConsistente()
        {

            return fechaParseable();

        }

        public static string fechaCruda()
        {

            return ConfigurationManager.AppSettings["fecha"];
            
        }

        public static Boolean fechaParseable()
        {

            string fecha = fechaCruda();

            string[] formats = { "yyyy-MM-dd" };

            DateTime parsedDateTime;

            return DateTime.TryParseExact(fecha, formats, new CultureInfo("en-US"), DateTimeStyles.None, out parsedDateTime);

        }

        public static DateTime fecha()
        {

            return DateTime.Parse(fechaCruda());

        }

    }
}
