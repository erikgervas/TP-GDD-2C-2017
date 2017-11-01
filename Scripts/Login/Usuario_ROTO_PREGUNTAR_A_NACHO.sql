CREATE TRIGGER HashUsuariosPassword
ON SQL_BOYS.Usuario
INSTEAD OF INSERT
AS
BEGIN

	INSERT SQL_BOYS.Usuario(username, contraseña, habilitadx)
		SELECT username, HASHBYTES('SHA2_256', contraseña), habilitadx
		FROM inserted;

END