CREATE PROCEDURE SQL_BOYS.darDeBajaSucursal(@CP NUMERIC(18,0)) AS

UPDATE Sucursal SET habilitadx = 0 WHERE cp_sucursal = @CP