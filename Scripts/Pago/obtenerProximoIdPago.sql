CREATE FUNCTION SQL_BOYS.obtenerProximoNroPago() 
RETURNS NUMERIC(18,0) AS BEGIN

DECLARE @proximoId NUMERIC(18,0)
DECLARE @ultimoId NUMERIC(18,0)

SELECT @ultimoId = MAX(p.numero_pago) FROM SQL_BOYS.Pago p

SET @proximoId = @ultimoId + 1

RETURN @proximoId

END