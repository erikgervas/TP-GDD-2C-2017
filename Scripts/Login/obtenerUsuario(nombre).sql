CREATE FUNCTION SQL_BOYS.obtenerUsuario(@nombre nvarchar(255))
RETURNS table

	return (
	
		select u.* from SQL_BOYS.Usuario u
			where u.username = @nombre

	)