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