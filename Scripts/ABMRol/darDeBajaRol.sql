CREATE PROCEDURE SQL_BOYS.darDeBajaRol(@idRol INT) AS

UPDATE SQL_BOYS.Rol SET habilitadx = 0 WHERE id_rol = @idRol