CREATE FUNCTION clientesConMasPagos(@anio int, @trimestre int)
RETURNS TABLE
AS 

	RETURN (

		select top 5 c.* from Cliente c join Pago p on c.id_cliente = p.id_cliente
			where dbo.esFechaValida(p.fecha_pago, @anio, @trimestre) = 1
			group by c.id_cliente, c.dni, c.nombre, c.apellido, c.mail, c.nacimiento, c.telefono, c.codigo_postal, c.habilitado, c.domicilio
			order by count(p.id_cliente) DESC

	)
