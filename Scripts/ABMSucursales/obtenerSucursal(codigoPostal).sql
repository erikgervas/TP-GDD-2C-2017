CREATE FUNCTION dbo.obtenerSucursalPorCodigoPostal(@CP NUMERIC(18,0))
RETURNS table

	return (
	
		select * from dbo.Sucursal s
			where s.codigo_postal = @CP

	)