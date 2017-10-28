CREATE FUNCTION dbo.obtenerRol(@id_rol int)
RETURNS table

	return (

		select r.nombre, f.id_funcionalidad from Rol r join Funcionalidad_Por_Rol as fr on r.id_rol = fr.id_rol join Funcionalidad f on fr.id_funcionalidad = f.id_funcionalidad
			where @id_rol = r.id_rol

	)