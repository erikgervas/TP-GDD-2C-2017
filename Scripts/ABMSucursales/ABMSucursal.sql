CREATE FUNCTION SQL_BOYS.obtenerSucursalPorNombre(@nombre NVARCHAR(50))
RETURNS table as 

	return(SELECT * FROM SQL_BOYS.Sucursal s WHERE (@nombre IS NULL) OR (s.nombre LIKE concat(@nombre,'%')))

GO

CREATE FUNCTION SQL_BOYS.obtenerSucursalPorDireccion(@direccion NVARCHAR(50))
RETURNS table as 

	return(SELECT * FROM SQL_BOYS.Sucursal s WHERE (@direccion IS NULL) OR (s.domicilio LIKE concat(@direccion,'%')))

GO

CREATE FUNCTION SQL_BOYS.obtenerSucursalPorCodigoPostal(@CP NUMERIC(18,0))
RETURNS table as 

	return(SELECT * FROM SQL_BOYS.Sucursal s WHERE (@CP = 0) OR (s.cp_sucursal = @CP))

GO

CREATE FUNCTION SQL_BOYS.obtenerSucursalPorFiltrado(@CP NUMERIC(18,0),@nombre NVARCHAR(50),@domicilio NVARCHAR(50))
RETURNS table

return (
	
		SELECT * FROM SQL_BOYS.Sucursal s
			where s.cp_sucursal IN (SELECT s.cp_sucursal FROM SQL_BOYS.obtenerSucursalPorCodigoPostal(@CP) as s) AND
			s.nombre IN (SELECT s.nombre FROM SQL_BOYS.obtenerSucursalPorNombre(@nombre) as s) AND
			s.domicilio IN (SELECT s.domicilio FROM SQL_BOYS.obtenerSucursalPorDireccion(@domicilio) as s)

	)

GO

CREATE PROCEDURE SQL_BOYS.actualizarSucursal(@CP NUMERIC(18,0),@nombre nvarchar(50), @domicilio nvarchar(50), @estado bit) AS

UPDATE Sucursal SET nombre = @nombre ,domicilio = @domicilio ,habilitadx = @estado WHERE cp_sucursal = @CP

GO

CREATE PROCEDURE SQL_BOYS.darDeBajaSucursal(@CP NUMERIC(18,0)) AS

UPDATE Sucursal SET habilitadx = 0 WHERE cp_sucursal = @CP

