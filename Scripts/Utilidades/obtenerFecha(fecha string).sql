create function SQL_BOYS.obtenerFecha(@fecha_actual nvarchar(10))
returns date
as begin

	return (select convert(date, @fecha_actual))

end