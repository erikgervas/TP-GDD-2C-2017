CREATE FUNCTION dbo.obtenerSucursalPorNombre(@nombre nvarchar(50))
RETURNS table

	return (
	
		select * from dbo.Sucursal s
			where s.nombre = @nombre

	)