CREATE PROCEDURE SQL_BOYS.actualizarSucursal(@CP NUMERIC(18,0),@nombre nvarchar(50), @domicilio nvarchar(50), @estado bit) AS

UPDATE Sucursal SET nombre = @nombre ,domicilio = @domicilio ,habilitadx = @estado WHERE cp_sucursal = @CP