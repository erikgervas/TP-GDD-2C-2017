CREATE FUNCTION SQL_BOYS.obtenerSucursalPorNombre(@nombre nvarchar(50))
RETURNS table

	return (
	
		select * from SQL_BOYS.Sucursal s
			where s.cp_sucursal = @nombre

	)