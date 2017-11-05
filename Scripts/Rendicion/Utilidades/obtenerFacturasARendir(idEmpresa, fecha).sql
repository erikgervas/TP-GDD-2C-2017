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