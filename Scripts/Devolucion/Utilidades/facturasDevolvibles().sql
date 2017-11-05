create function SQL_BOYS.facturasDevolvibles()
returns table

	return	(	
	
				-- Obtengo las que no fueron devueltas, fueron pagas y no han sido rendidas
				select f.numero_factura from SQL_BOYS.Factura f left join
					SQL_BOYS.Devolucion d on f.numero_factura = d.numero_factura left join
					SQL_BOYS.Item_Pago ip on f.numero_factura = ip.numero_pago
					
					where d.numero_factura is null and f.numero_rendicion is null and ip.numero_factura is not null

			)