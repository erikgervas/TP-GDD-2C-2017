CREATE FUNCTION SQL_BOYS.obtenerRoles(@id_usuario int, @id_sucursal int)
RETURNS TABLE

	return (

		select r.* from SQL_BOYS.Rol_De_Usuario_Por_Sucursal as rus join SQL_BOYS.Rol as r on rus.id_rol = r.id_rol
			where @id_usuario = rus.id_usuario and @id_sucursal = rus.cp_sucursal

	)