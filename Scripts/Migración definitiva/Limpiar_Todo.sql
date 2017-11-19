USE [GD2C2017]

GO

DROP TABLE

	SQL_BOYS.Item_Rendicion,
	SQL_BOYS.Item_Pago,
	SQL_BOYS.Item,
	SQL_BOYS.Pago,
	SQL_BOYS.Medio_De_Pago,
	SQL_BOYS.Devolucion,
	SQL_BOYS.Factura,
	SQL_BOYS.Empresa,
	SQL_BOYS.Rubro,
	SQL_BOYS.Rendicion,
	SQL_BOYS.Cliente,
	SQL_BOYS.Rol_De_Usuario_Por_Sucursal, 
	SQL_BOYS.Sucursal,
	SQL_BOYS.Funcionalidad_Por_Rol,
	SQL_BOYS.Funcionalidad,
	SQL_BOYS.Rol,
	SQL_BOYS.Usuario,
	SQL_BOYS.Tabla_Maestra_Conflictiva

DROP VIEW

	SQL_BOYS.Empresa_View_Empresa_Con_Rubro

DROP FUNCTION

	SQL_BOYS.clientesConMasPagos,
	SQL_BOYS.clientesCumplidores,
	SQL_BOYS.empresasARendir,
	SQL_BOYS.empresasConMayorMontoRendido,
	SQL_BOYS.existeCliente,
	SQL_BOYS.facturasDevolvibles,
	SQL_BOYS.filtrarEmpresa,
	SQL_BOYS.filtrarFactura,
	SQL_BOYS.obtenerFactura,
	SQL_BOYS.obtenerFacturasARendir,
	SQL_BOYS.obtenerRol,
	SQL_BOYS.obtenerRoles,
	SQL_BOYS.obtenerRubros,
	SQL_BOYS.obtenerSucursales,
	SQL_BOYS.obtenerSucursalPorCodigoPostal,
	SQL_BOYS.obtenerSucursalPorDireccion,
	SQL_BOYS.obtenerSucursalPorFiltrado,
	SQL_BOYS.obtenerSucursalPorNombre,
	SQL_BOYS.obtenerUsuario,
	SQL_BOYS.porcentajeDeFacturasCobradasPorEmpresa,
	SQL_BOYS.cantidadDeFacturasPorRendirDeEmpresa,
	SQL_BOYS.esFechaValida,
	SQL_BOYS.id_Rubro,
	SQL_BOYS.obtenerEmpresa,
	SQL_BOYS.obtenerFecha,
	SQL_BOYS.obtenerProximoNroPago

DROP PROCEDURE

	SQL_BOYS.actualizarSucursal,
	SQL_BOYS.altaDeEmpresa,
	SQL_BOYS.altaDeFactura,
	SQL_BOYS.altaDeItem,
	SQL_BOYS.bajaDeEmpresa,
	SQL_BOYS.bajaDeFactura,
	SQL_BOYS.darDeBajaSucursal,
	SQL_BOYS.devolverFacturaPaga,
	SQL_BOYS.insertarItemPagoDeFactura,
	SQL_BOYS.modificacionDeEmpresa,
	SQL_BOYS.modificacionDeFactura,
	SQL_BOYS.rendirFacturas

