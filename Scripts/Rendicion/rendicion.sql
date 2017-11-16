create function SQL_BOYS.obtenerFacturasARendir(@id_empresa int, @fecha_actual nvarchar(10))
returns table

return 
			(select f.* from SQL_BOYS.Factura f
					where f.numero_rendicion is null and f.id_empresa = @id_empresa and f.factura_fecha_alta <= SQL_BOYS.obtenerFecha(@fecha_actual)
						and exists	(select * from SQL_BOYS.Item_Pago ip
										where ip.numero_factura = f.numero_factura	
									) -- fue pagada
						and not exists	(select * from SQL_BOYS.Devolucion d
											where d.numero_factura = f.numero_factura
								
										) -- no fue devuelta
			)

GO

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

GO

create procedure SQL_BOYS.rendirFacturas(@id_empresa int, @fecha_actual nvarchar(10))
as
begin

	-- Verifico que la empresa que me pedis rendir, sea rendible
	if(exists(select e.* from SQL_BOYS.empresasARendir(@fecha_actual) e where e.id_empresa = @id_empresa))
	begin

		declare @porcentaje_comision int

		-- Obtengo el porcentaje de la empresa
		set @porcentaje_comision = (select e.porcentaje_comision from SQL_BOYS.Empresa e where e.id_empresa = @id_empresa)

		-- Declaro mi futura id rendicion
		declare @id_numero_rendicion int

		-- Inserto en la rendicion la suma de las facturas a rendir
		insert into SQL_BOYS.Rendicion (importe_comision, fecha_rendicion)
			values ((select sum(o.factura_monto_total) from SQL_BOYS.obtenerFacturasARendir(@id_empresa, @fecha_actual) o) * @porcentaje_comision / 100, SQL_BOYS.obtenerFecha(@fecha_actual))
		
		-- Obtengo el id de la rendicion ingresada
		set @id_numero_rendicion = (select scope_identity())

		declare @numero_factura_cr int

		-- Obtengo las facturas a rendir de la empresa solicitada
		declare cr_facturas cursor local for 
			select fs.numero_factura from SQL_BOYS.obtenerFacturasARendir(@id_empresa, @fecha_actual) fs

		open cr_facturas

		fetch next from cr_facturas into @numero_factura_cr

		-- Recorro las facturas a rendir
		while @@FETCH_STATUS = 0
		begin

			print '@numero_factura_cr=' + str(@numero_factura_cr)
			
			declare @id_item_factura_cr int

			-- Declaro un nuevo cursor para poder agarrar a cada item de las facturas que van a ser rendidas
			declare cr_item_facturas cursor local for
				select i.id_item from SQL_BOYS.Item i where i.numero_factura = @numero_factura_cr

			open cr_item_facturas
		
			fetch next from cr_item_facturas into @id_item_factura_cr

			-- Recorro los items a ser agregados como rendidos
			while @@FETCH_STATUS = 0
			begin

				print '@id_item_factura_cr=' + str(@id_item_factura_cr)

				-- Los inserto con el id de la rendicion que obtuve previamente
				insert into SQL_BOYS.Item_Rendicion (id_item, numero_rendicion) values
					(@id_item_factura_cr, @id_numero_rendicion)

				fetch next from cr_item_facturas into @id_item_factura_cr

			end

			close cr_item_facturas

			deallocate cr_item_facturas

			-- Ahora la factura pasa a estar rendida
			update SQL_BOYS.Factura
				set numero_rendicion = @id_numero_rendicion
				where numero_factura = @numero_factura_cr

			fetch next from cr_facturas into @numero_factura_cr

		end  

		close cr_facturas

		deallocate cr_facturas

	end

	else

	begin

		-- No habia facturas para rendir
		;throw 50069, 'No hay facturas para rendir para esta empresa', 1

	end

end