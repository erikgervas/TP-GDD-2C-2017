CREATE TRIGGER dbo.HashUsuariosPassword
ON dbo.Usuario
INSTEAD OF INSERT
AS
BEGIN

	INSERT dbo.Usuario(username, contraseña, habilitadx)
		SELECT username, HASHBYTES('SHA2_256', contraseña), habilitadx
		FROM inserted;

END