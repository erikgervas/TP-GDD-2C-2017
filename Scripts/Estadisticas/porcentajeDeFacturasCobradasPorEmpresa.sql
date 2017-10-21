CREATE FUNCTION porcentajeDeFacturasCobradasPorEmpresa(@anio int, @trimestre int)
RETURNS table
AS

	return (
	
		SELECT top 5 e.* from Empresa e join 
				Factura f on e.id_empresa = f.id_empresa join 
				Item_Pago i on f.numero_factura = i.numero_factura join 
				Pago p on i.numero_pago = p.numero_pago
			
			where dbo.esFechaValida(p.fecha_pago, @anio, @trimestre) = 1

			group by e.id_empresa, e.nombre, e.cuit, e.domicilio, e.id_rubro, e.dia_rendicion, e.habilitada

			order by (
			
				sum (

					case 
						when e.id_empresa = f.id_empresa and f.numero_factura = i.numero_factura and i.numero_pago IS NOT NULL then 1
						else 0
					end


				) * 100 / sum (
				
					case 
						when e.id_empresa = f.id_empresa then 1
						else 0
					end
				
				)
			
			) DESC /* Ordeno por la cantidad de pagos que tuvo la empresa por cien, dividido la cantidad de facturas que tuvo. Todo esto es en el periodo dado. */
			

		)