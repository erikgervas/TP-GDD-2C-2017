CREATE FUNCTION SQL_BOYS.obtenerSucursalPorCodigoPostal(@CP NUMERIC(18,0))
RETURNS table as 

	return(SELECT * FROM SQL_BOYS.Sucursal s WHERE (@CP = 0) OR (s.cp_sucursal = @CP))
