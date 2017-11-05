CREATE FUNCTION SQL_BOYS.obtenerFactura(@nroFactura NUMERIC(18,0), @idEmpresa int,@fechaVencimiento DateTime)
RETURNS table AS 

	return(SELECT * FROM Factura f WHERE f.numero_factura = @nroFactura AND f.id_empresa = @idEmpresa AND f.factura_fecha_vencimiento = @fechaVencimiento)