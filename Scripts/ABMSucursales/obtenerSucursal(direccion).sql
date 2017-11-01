CREATE FUNCTION SQL_BOYS.obtenerSucursalPorDireccion(@domicilio nvarchar(50))
RETURNS table

	return (
	
		select * from SQL_BOYS.Sucursal s
			where s.cp_sucursal = @domicilio

	)