create procedure SQL_BOYS.rendirFacturas(@id_empresa int)
as
begin

	-- Verifico que la empresa que me pedis rendir, sea rendible
	if(exists(select e.* from SQL_BOYS.empresasARendir() e where e.id_empresa = @id_empresa))
	begin

		declare @porcentaje_comision int

		-- Obtengo el porcentaje de la empresa
		set @porcentaje_comision = (select e.porcentaje_comision from SQL_BOYS.Empresa e where e.id_empresa = @id_empresa)

		-- Declaro mi futura id rendicion
		declare @id_numero_rendicion int

		-- Inserto en la rendicion la suma de las facturas a rendir
		insert into SQL_BOYS.Rendicion (importe_comision, fecha_rendicion)
			values ((select sum(o.factura_monto_total) from SQL_BOYS.obtenerFacturasARendir(@id_empresa) o) * @porcentaje_comision / 100, getdate())
		
		-- Obtengo el id de la rendicion ingresada
		set @id_numero_rendicion = (select scope_identity())

		declare @numero_factura_cr int

		-- Obtengo las facturas a rendir de la empresa solicitada
		declare cr_facturas cursor for 
			select fs.numero_factura from SQL_BOYS.obtenerFacturasARendir(@id_empresa) fs

		open cr_facturas

		fetch next from cr_facturas into @numero_factura_cr

		-- Recorro las facturas a rendir
		while @@FETCH_STATUS = 0
		begin
		
			-- Inserto los item de cada factura como items rendidos
			insert into SQL_BOYS.Item_Rendicion (id_item, numero_rendicion) values
				((select i.id_item from SQL_BOYS.Item i
					where i.numero_factura = @numero_factura_cr), @id_numero_rendicion)
			
			-- Ahora la factura pasa a estar rendida
			update SQL_BOYS.Factura
				set numero_rendicion = @id_numero_rendicion
				where numero_factura = @numero_factura_cr

			fetch next from cr_facturas

		end  


	end

	else

	begin

		-- No habia facturas para rendir
		;throw 69, 'No hay facturas para rendir para esta empresa', 1

	end

end