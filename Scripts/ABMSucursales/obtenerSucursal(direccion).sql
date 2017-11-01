CREATE FUNCTION dbo.obtenerSucursalPorDireccion(@domicilio nvarchar(50))
RETURNS table

	return (
	
		select * from dbo.Sucursal s
			where s.cp_sucursal = @domicilio

	)