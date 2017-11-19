CREATE PROCEDURE SQL_BOYS.actualizarRol(@idRol INT,@nombre nvarchar(255), @estado bit) AS BEGIN

UPDATE SQL_BOYS.Rol SET nombre = @nombre ,habilitadx = @estado WHERE id_rol = @idRol

DELETE FROM SQL_BOYS.Funcionalidad_Por_Rol WHERE id_rol = @idRol 

END
