CREATE FUNCTION dbo.obtenerUsuario(@nombre nvarchar(255))
RETURNS table

	return (
	
		select u.* from dbo.Usuario u
			where u.username = @nombre

	)