CREATE PROCEDURE SQL_BOYS.insertarItemPagoDeFactura(@nroPago NUMERIC(18,0), @nroFactura NUMERIC(18,0))
AS
BEGIN

INSERT INTO SQL_BOYS.Item_Pago(id_item, numero_factura, numero_pago)

SELECT it.id_item, @nroFactura, @nroPago FROM SQL_BOYS.Item it WHERE it.numero_factura = @nroFactura GROUP BY it.id_item

END