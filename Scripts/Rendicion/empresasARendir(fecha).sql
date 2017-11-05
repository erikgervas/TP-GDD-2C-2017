create function SQL_BOYS.empresasARendir(@fecha_actual nvarchar(10))
returns table

	return (

		select e.* from SQL_BOYS.Empresa e
			where e.dia_rendicion = day(SQL_BOYS.obtenerFecha(@fecha_actual)) and SQL_BOYS.obtenerFecha(@fecha_actual) != (select top 1 r.fecha_rendicion from SQL_BOYS.Factura f join SQL_BOYS.Rendicion r on f.numero_rendicion = r.numero_rendicion
																		where f.id_empresa = e.id_empresa
																		
																		order by r.fecha_rendicion desc	
																	)

					and exists(select * from SQL_BOYS.obtenerFacturasARendir(e.id_empresa, @fecha_actual))

	)