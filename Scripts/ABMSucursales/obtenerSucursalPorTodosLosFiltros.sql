CREATE FUNCTION SQL_BOYS.obtenerSucursalPorFiltrado(@CP NUMERIC(18,0),@nombre NVARCHAR(50),@domicilio NVARCHAR(50),@habilitado BIT)
RETURNS table

return (
	
		SELECT * FROM SQL_BOYS.Sucursal s
			where s.cp_sucursal IN (SELECT s.cp_sucursal FROM SQL_BOYS.obtenerSucursalPorCodigoPostal(@CP) as s) AND
			s.nombre IN (SELECT s.nombre FROM SQL_BOYS.obtenerSucursalPorNombre(@nombre) as s) AND
			s.domicilio IN (SELECT s.domicilio FROM SQL_BOYS.obtenerSucursalPorDireccion(@domicilio) as s)

	)