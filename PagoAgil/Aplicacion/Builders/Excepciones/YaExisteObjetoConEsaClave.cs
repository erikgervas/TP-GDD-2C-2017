﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.View.Excepciones
{
    public class YaExisteObjetoConEsaClave : Exception
    {
        public string mensaje { get; set; }
    }
}
