CREATE PROCEDURE SQL_BOYS.actualizarRol(@idRol INT,@nombre nvarchar(255), @estado bit) AS

UPDATE Rol SET nombre = @nombre ,habilitadx = @estado WHERE id_rol = @idRol
