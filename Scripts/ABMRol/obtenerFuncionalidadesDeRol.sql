CREATE FUNCTION SQL_BOYS.obtenerFuncionalidadesDeRol(@idRol INT) 
RETURNS TABLE AS 

RETURN (SELECT f.id_funcionalidad, f.nombre FROM SQL_BOYS.Funcionalidad f JOIN SQL_BOYS.Funcionalidad_Por_Rol fxr ON (f.id_funcionalidad = fxr.id_funcionalidad) WHERE fxr.id_rol = @idRol)