CREATE FUNCTION SQL_BOYS.clientesCumplidores(@anio int, @trimestre int)
RETURNS TABLE
AS 

	RETURN (

		select top 5 c.*, (sum(ip.numero_factura) * 100 / sum(f.numero_factura)) as porcentaje_facturas_pagadas from SQL_BOYS.Cliente c 
			join SQL_BOYS.Pago p on c.dni_cliente = p.dni_cliente
			join SQL_BOYS.Item_Pago ip on p.numero_pago = ip.numero_pago
			join SQL_BOYS.Factura f on c.dni_cliente = f.dni_cliente

			where SQL_BOYS.esFechaValida(p.fecha_pago, @anio, @trimestre) = 1 and SQL_BOYS.esFechaValida(f.factura_fecha_alta, @anio, @trimestre) = 1
			group by c.dni_cliente, c.nombre, c.apellido, c.mail, c.nacimiento, c.telefono, c.codigo_postal, c.habilitadx, c.domicilio
		
			order by porcentaje_facturas_pagadas DESC

	)