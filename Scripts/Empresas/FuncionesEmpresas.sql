CREATE FUNCTION SQL_BOYS.obtenerRubros() RETURNS TABLE

	RETURN SELECT r.id_rubro, r.descripcion FROM SQL_BOYS.Rubro r

GO