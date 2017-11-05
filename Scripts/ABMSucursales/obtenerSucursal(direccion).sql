CREATE FUNCTION SQL_BOYS.obtenerSucursalPorDireccion(@direccion NVARCHAR(50))
RETURNS table as 

	return(SELECT * FROM SQL_BOYS.Sucursal s WHERE (@direccion IS NULL) OR (s.domicilio LIKE concat(@direccion,'%')))