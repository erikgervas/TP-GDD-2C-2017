CREATE FUNCTION SQL_BOYS.obtenerSucursalPorCodigoPostal(@CP NUMERIC(18,0))
RETURNS table

	return (
	
		select * from SQL_BOYS.Sucursal s
			where s.cp_sucursal = @CP

	)