CREATE FUNCTION SQL_BOYS.obtenerSucursalPorCodigoPostal(@CP NUMERIC(18,0))
RETURNS table as begin
	
	if(@CP != 0) begin 
	return (select * from SQL_BOYS.Sucursal s where s.cp_sucursal = @CP)
	end
	else
	return (select * from SQL_BOYS.Sucursal)
	end

	end