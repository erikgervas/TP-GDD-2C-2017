CREATE FUNCTION SQL_BOYS.obtenerSucursalPorNombre(@nombre NVARCHAR(50))
RETURNS table as 

	return(SELECT * FROM SQL_BOYS.Sucursal s WHERE (@nombre IS NULL) OR (s.nombre LIKE concat(@nombre,'%')))
