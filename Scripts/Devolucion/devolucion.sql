create function SQL_BOYS.facturasDevolvibles()
returns table

	return	(	
	
				-- Obtengo las que no fueron devueltas, fueron pagas y no han sido rendidas
				select f.numero_factura from SQL_BOYS.Factura f left join
					SQL_BOYS.Devolucion d on f.numero_factura = d.numero_factura left join
					SQL_BOYS.Item_Pago ip on f.numero_factura = ip.numero_pago
					
					where d.numero_factura is null and f.numero_rendicion is null and ip.numero_factura is not null

			)

GO

create procedure SQL_BOYS.devolverFacturaPaga(@numero_factura int, @motivo nvarchar(255), @fecha_actual nvarchar(10))
as begin

	if(exists(select fd.numero_factura from SQL_BOYS.facturasDevolvibles() fd where fd.numero_factura = @numero_factura))
	begin

		declare @numero_pago int

		-- Tomo el numero del pago a borrar
		set @numero_pago = (select top 1 ip.numero_pago from SQL_BOYS.Item_Pago ip where ip.numero_factura = @numero_factura)

		declare @devolucion_de_factura char

		-- En caso de que falle la transaccion, es conveniente que la base haga rollback automaticamente
		set xact_abort on

		begin transaction @devolucion_de_factura

			delete from SQL_BOYS.Item_Pago
				where numero_pago = @numero_pago	

			delete from SQL_BOYS.Pago
				where numero_pago = @numero_pago

			-- Una vez borrados los pagos y los items, puedo insertar la devolucion correspondiente
			insert into SQL_BOYS.Devolucion (fecha_devolucion, motivo, numero_factura) values
				(SQL_BOYS.obtenerFecha(@fecha_actual), @motivo, @numero_factura)

		commit transaction @devolucion_de_factura

	end

	else

	begin

		;throw 50071, 'No se pudo devolver la factura, ya que no cumplia los requisitos para ser devuelta', 1

	end

end