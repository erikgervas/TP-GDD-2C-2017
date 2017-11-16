CREATE FUNCTION SQL_BOYS.obtenerSucursales(@id_usuario int)
RETURNS table

	return (

		select s.* from SQL_BOYS.Rol_De_Usuario_Por_Sucursal as rus join SQL_BOYS.Sucursal s on rus.cp_sucursal = s.cp_sucursal
			where @id_usuario = rus.id_usuario

	)

GO

CREATE FUNCTION SQL_BOYS.obtenerRol(@id_rol int)
RETURNS table

	return (

		select r.nombre, f.id_funcionalidad from Rol r join SQL_BOYS.Funcionalidad_Por_Rol as fr on r.id_rol = fr.id_rol join SQL_BOYS.Funcionalidad f on fr.id_funcionalidad = f.id_funcionalidad
			where @id_rol = r.id_rol

	)

GO

CREATE FUNCTION SQL_BOYS.obtenerRoles(@id_usuario int, @id_sucursal int)
RETURNS TABLE

	return (

		select r.* from SQL_BOYS.Rol_De_Usuario_Por_Sucursal as rus join SQL_BOYS.Rol as r on rus.id_rol = r.id_rol
			where @id_usuario = rus.id_usuario and @id_sucursal = rus.cp_sucursal

	)