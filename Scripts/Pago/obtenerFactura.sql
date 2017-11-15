CREATE FUNCTION SQL_BOYS.obtenerFactura(@nroFactura NUMERIC(18,0), @idEmpresa int,@diaV int,@mesV int,@anioV int)
RETURNS table AS 

	return(SELECT * FROM Factura f WHERE f.numero_factura = @nroFactura AND f.id_empresa = @idEmpresa AND 
	
	YEAR(f.factura_fecha_vencimiento) = @anioV AND MONTH(f.factura_fecha_vencimiento) = @mesV AND DAY(f.factura_fecha_vencimiento) = @diaV AND @nroFactura
	
	NOT IN (SELECT it.numero_factura FROM Item_Pago it) )