using PagoAgil.Aplicacion.Modelo.Estadistica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores
{
    public class RepositorioDeEstadisticas
    {

        private Estadistica[] estadisticas = { 
                                                 
                                                new Estadistica(
                                                    "Porcentaje de facturas cobradas por empresa", 
                                                    "SQL_BOYS.porcentajeDeFacturasCobradasPorEmpresa", 
                                                    new string[]{"id_empresa", "nombre", "cuit", "domicilio", "dia_rendicion", "porcentaje_comision", "habilitadx", "id_rubro", "porcentaje_facturas_cobradas"}
                                                    ),

                                                new Estadistica(
                                                    "Empresas con mayor monto rendido", 
                                                    "SQL_BOYS.empresasConMayorMontoRendido", 
                                                    new string[]{"id_empresa", "nombre", "cuit", "domicilio", "dia_rendicion", "porcentaje_comision", "habilitadx", "id_rubro", "monto_rendido"}
                                                    ),

                                                new Estadistica(
                                                    "Clientes con mas pagos", 
                                                    "SQL_BOYS.clientesConMasPagos", 
                                                    new string[]{"dni_cliente", "nombre", "apellido", "nacimiento", "mail", "domicilio", "codigo_postal", "telefono", "habilitadx", "cantidad_de_pagos"}
                                                    ),

                                                new Estadistica(
                                                    "Clientes cumplidores",
                                                    "SQL_BOYS.clientesCumplidores", 
                                                    new string[]{"dni_cliente", "nombre", "apellido", "nacimiento", "mail", "domicilio", "codigo_postal", "telefono", "habilitadx", "porcentaje_facturas_pagadas"}
                                                    )

                                             };

        private static RepositorioDeEstadisticas instance = new RepositorioDeEstadisticas();

        private RepositorioDeEstadisticas() { }

        public static RepositorioDeEstadisticas getInstance()
        {
            
            return instance;

        }

        public Estadistica[] obtenerEstadisticas()
        {

            return this.estadisticas;

        }
    }
}
