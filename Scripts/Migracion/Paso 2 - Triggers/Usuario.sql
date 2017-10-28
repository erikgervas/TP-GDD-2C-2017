CREATE TRIGGER dbo.HashUsuariosPassword
ON dbo.Usuario
INSTEAD OF INSERT
AS
BEGIN

  INSERT dbo.Usuario(username, contraseña, habilitado)
    SELECT username, HASHBYTES('SHA2_256', contraseña), habilitado
    FROM inserted;

END