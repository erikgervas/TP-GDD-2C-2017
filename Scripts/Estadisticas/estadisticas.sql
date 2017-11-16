CREATE FUNCTION SQL_BOYS.esFechaValida(@fecha datetime, @anio int, @trimestre int)
RETURNS bit
AS
BEGIN

	declare @mes int

	set @mes = month(@fecha)

	declare @trimesteDelAnio int

		if(@mes >= 0 and @mes <= 2)
			SET @trimesteDelAnio = 1

		if(@mes >= 3 and @mes <= 5)
			SET @trimesteDelAnio = 2

		if(@mes >= 6 and @mes <= 8)
			SET @trimesteDelAnio = 3
		
		if(@mes >= 9 and @mes <= 11)
			SET @trimesteDelAnio = 4

	if(year(@fecha) = @anio and @trimesteDelAnio = @trimestre)
		return 1

	return 0

END

GO

CREATE FUNCTION SQL_BOYS.clientesConMasPagos(@anio int, @trimestre int)
RETURNS TABLE
AS 

	RETURN (

		select top 5 c.*, count(p.dni_cliente) as cantidad_de_pagos from SQL_BOYS.Cliente c join SQL_BOYS.Pago p on c.dni_cliente = p.dni_cliente
			where SQL_BOYS.esFechaValida(p.fecha_pago, @anio, @trimestre) = 1
			group by c.dni_cliente, c.nombre, c.apellido, c.mail, c.nacimiento, c.telefono, c.codigo_postal, c.habilitadx, c.domicilio
			order by cantidad_de_pagos DESC

	)

GO

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

GO

CREATE FUNCTION SQL_BOYS.empresasConMayorMontoRendido(@anio int, @trimestre int)
RETURNS TABLE
AS 

	RETURN (

		select top 5 e.*, sum(i.monto) as monto_rendido from SQL_BOYS.Empresa e
			join SQL_BOYS.Factura f on e.id_empresa = f.id_empresa
			join SQL_BOYS.Rendicion r on f.numero_rendicion = r.numero_rendicion
			join SQL_BOYS.Item_Rendicion ir on r.numero_rendicion = ir.numero_rendicion
			join SQL_BOYS.Item i on ir.id_item = i.id_item

			where SQL_BOYS.esFechaValida(r.fecha_rendicion, @anio, @trimestre) = 1

			group by e.id_empresa, e.nombre, e.cuit, e.domicilio, e.porcentaje_comision, e.id_rubro, e.dia_rendicion, e.habilitadx

			order by monto_rendido desc

	)

GO

CREATE FUNCTION SQL_BOYS.porcentajeDeFacturasCobradasPorEmpresa(@anio int, @trimestre int)
RETURNS table
AS

	return (
	
		SELECT top 5 e.*, sum (

					case 
						when e.id_empresa = f.id_empresa and f.numero_factura = i.numero_factura and i.numero_pago IS NOT NULL then 1
						else 0
					end


				) * 100 / sum (
				
					case 
						when e.id_empresa = f.id_empresa then 1
						else 0
					end
				
				) as porcentaje_facturas_cobradas -- Cantidad de pagos que tuvo la empresa por cien, dividido la cantidad de facturas que tuvo
				
				from SQL_BOYS.Empresa e join 
				SQL_BOYS.Factura f on e.id_empresa = f.id_empresa join 
				SQL_BOYS.Item_Pago i on f.numero_factura = i.numero_factura join 
				SQL_BOYS.Pago p on i.numero_pago = p.numero_pago
			
			where SQL_BOYS.esFechaValida(p.fecha_pago, @anio, @trimestre) = 1

			group by e.id_empresa, e.nombre, e.porcentaje_comision, e.cuit, e.domicilio, e.id_rubro, e.dia_rendicion, e.habilitadx

			order by porcentaje_facturas_cobradas DESC
			

		)






