CREATE FUNCTION SQL_BOYS.obtenerFuncionalidadesDeRol(@idRol INT) 
RETURNS TABLE AS 

RETURN (SELECT f.id_funcionalidad, f.nombre FROM Funcionalidad f JOIN Funcionalidad_Por_Rol fxr ON (f.id_funcionalidad = fxr.id_funcionalidad) WHERE fxr.id_rol = @idRol)