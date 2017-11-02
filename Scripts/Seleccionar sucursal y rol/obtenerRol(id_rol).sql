CREATE FUNCTION SQL_BOYS.obtenerRol(@id_rol int)
RETURNS table

	return (

		select r.nombre, f.id_funcionalidad from Rol r join SQL_BOYS.Funcionalidad_Por_Rol as fr on r.id_rol = fr.id_rol join SQL_BOYS.Funcionalidad f on fr.id_funcionalidad = f.id_funcionalidad
			where @id_rol = r.id_rol

	)