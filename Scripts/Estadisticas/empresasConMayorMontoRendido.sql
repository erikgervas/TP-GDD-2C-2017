CREATE FUNCTION SQL_BOYS.empresasConMayorMontoRendido(@anio int, @trimestre int)
RETURNS TABLE
AS 

	RETURN (

		select top 5 e.* from SQL_BOYS.Empresa e
			join SQL_BOYS.Factura f on e.id_empresa = f.id_empresa
			join SQL_BOYS.Rendicion r on f.numero_rendicion = r.numero_rendicion
			join SQL_BOYS.Item_Rendicion ir on r.numero_rendicion = ir.numero_rendicion
			join SQL_BOYS.Item i on ir.id_item = i.id_item

			where SQL_BOYS.esFechaValida(r.fecha_rendicion, @anio, @trimestre) = 1

			group by e.id_empresa, e.nombre, e.cuit, e.domicilio, e.id_rubro, e.dia_rendicion, e.habilitadx

			order by sum(i.monto) desc

	)