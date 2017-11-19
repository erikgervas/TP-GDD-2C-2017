CREATE FUNCTION SQL_BOYS.obtenerProximoIdRol() 
RETURNS INT AS BEGIN

DECLARE @proximoId INT
DECLARE @ultimoId INT

SELECT @ultimoId = MAX(r.id_rol) FROM SQL_BOYS.Rol r

SET @proximoId = @ultimoId + 1

RETURN @proximoId

END