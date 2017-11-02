CREATE FUNCTION SQL_BOYS.esFechaValida(@fecha datetime, @anio int, @trimestre int)
RETURNS bit
AS
BEGIN

	declare @mes int

	set @mes = month(@fecha)

	declare @trimesteDelAnio int

		if(@mes >= 0 and @mes <= 2)
			SET @trimesteDelAnio = 1

		if(@mes >= 3 and @mes <= 5)
			SET @trimesteDelAnio = 2

		if(@mes >= 6 and @mes <= 8)
			SET @trimesteDelAnio = 3
		
		if(@mes >= 9 and @mes <= 11)
			SET @trimesteDelAnio = 4

	if(year(@fecha) = @anio and @trimesteDelAnio = @trimestre)
		return 1

	return 0

END