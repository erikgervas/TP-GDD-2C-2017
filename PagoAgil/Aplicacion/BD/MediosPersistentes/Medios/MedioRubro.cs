﻿using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes.Medios
{
    public class MedioRubro : MedioBD<String>
    {
        protected override string nombreTabla()
        {
            return "obtenerRubros()";
        }

        protected override String rellenarFila(List<String> elementos)
        {
            return elementos.ElementAt(1);
        }
    }
}