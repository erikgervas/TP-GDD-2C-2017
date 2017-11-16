CREATE FUNCTION SQL_BOYS.obtenerProximoNroPago() 
RETURNS NUMERIC(18,0) AS BEGIN

DECLARE @proximoId NUMERIC(18,0)
DECLARE @ultimoId NUMERIC(18,0)

SELECT @ultimoId = MAX(p.numero_pago) FROM SQL_BOYS.Pago p

SET @proximoId = @ultimoId + 1

RETURN @proximoId

END

GO

CREATE FUNCTION SQL_BOYS.obtenerFactura(@nroFactura NUMERIC(18,0), @idEmpresa int,@diaV int,@mesV int,@anioV int)
RETURNS table AS 

	return(SELECT * FROM Factura f WHERE f.numero_factura = @nroFactura AND f.id_empresa = @idEmpresa AND 
	
	YEAR(f.factura_fecha_vencimiento) = @anioV AND MONTH(f.factura_fecha_vencimiento) = @mesV AND DAY(f.factura_fecha_vencimiento) = @diaV AND @nroFactura
	
	NOT IN (SELECT it.numero_factura FROM SQL_BOYS.Item_Pago it) )

GO

CREATE FUNCTION SQL_BOYS.existeCliente(@DNI NUMERIC(18,0))
RETURNS table as 

	return(SELECT c.dni_cliente, c.habilitadx FROM SQL_BOYS.Cliente c WHERE c.dni_cliente = @DNI)

GO

CREATE PROCEDURE SQL_BOYS.insertarItemPagoDeFactura(@nroPago NUMERIC(18,0), @nroFactura NUMERIC(18,0))
AS
BEGIN

INSERT INTO SQL_BOYS.Item_Pago(id_item, numero_factura, numero_pago)

SELECT it.id_item, @nroFactura, @nroPago FROM SQL_BOYS.Item it WHERE it.numero_factura = @nroFactura

END