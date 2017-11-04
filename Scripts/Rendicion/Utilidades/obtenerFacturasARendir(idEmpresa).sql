create function SQL_BOYS.obtenerFacturasARendir(@id_empresa int)
returns table

return 
		(select f.* from SQL_BOYS.Factura f
					where f.numero_rendicion is null and f.id_empresa = @id_empresa and f.factura_fecha_alta between getdate() and DateAdd(month, -1, Convert(date, GetDate())) -- Hay un monton de facturas viejas que no estan rendidas, que hacemos?
						and exists	(select * from SQL_BOYS.Item_Pago ip
										where ip.numero_factura = f.numero_factura	
									) -- fue pagada
						and not exists	(select * from SQL_BOYS.Devolucion d
											where d.numero_factura = f.numero_factura
								
										)
				)