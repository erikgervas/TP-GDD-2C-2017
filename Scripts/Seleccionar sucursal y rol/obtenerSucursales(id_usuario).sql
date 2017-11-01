CREATE FUNCTION SQL_BOYS.obtenerSucursales(@id_usuario int)
RETURNS table

	return (

		select s.* from SQL_BOYS.Rol_De_Usuario_Por_Sucursal as rus join SQL_BOYS.Sucursal s on rus.cp_sucursal = s.cp_sucursal
			where @id_usuario = rus.id_usuario

	)