CREATE PROCEDURE SQL_BOYS.darDeBajaRol(@idRol INT) AS

UPDATE Rol SET habilitadx = 0 WHERE id_rol = @idRol