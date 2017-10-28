CREATE FUNCTION dbo.obtenerRoles(@id_usuario int, @id_sucursal int)
RETURNS TABLE

	return (

		select r.* from Rol_De_Usuario_Por_Sucursal as rus join Rol as r on rus.id_rol = r.id_rol
			where @id_usuario = rus.id_usuario and @id_sucursal = rus.id_sucursal

	)