CREATE FUNCTION SQL_BOYS.existeCliente(@DNI NUMERIC(18,0))
RETURNS table as 

	return(SELECT c.dni_cliente, c.habilitadx FROM SQL_BOYS.Cliente c WHERE c.dni_cliente = @DNI)