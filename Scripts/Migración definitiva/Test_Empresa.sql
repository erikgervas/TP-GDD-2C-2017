BEGIN

	DECLARE @nombre NVARCHAR(255)

	DECLARE @i INT = 0;

	WHILE @i < 15

		BEGIN
				
			SET @nombre = 'TestRubro ' + CONVERT(NVARCHAR(255), @i)
				
			INSERT INTO SQL_BOYS.Rubro(descripcion) VALUES (@nombre)

			SET @i = @i + 1;
			
		END

END

GO

BEGIN

	DECLARE @nombre NVARCHAR(255)

	DECLARE @cuit NVARCHAR(50)

	DECLARE @domicilio NVARCHAR(255)

	DECLARE @dia_rendicion INT

	DECLARE @porcentaje_comision INT

	DECLARE @habilitadx BIT

	DECLARE @cantidad_rubros INT = (SELECT COUNT(*) FROM SQL_BOYS.Rubro)

	DECLARE @id_rubro INT

	DECLARE @i INT = 0;

	WHILE @i < 10000

		BEGIN
				
			SET @nombre = 'TestEmpresa ' + CONVERT(NVARCHAR(255), @i)

			SET @cuit = '11-' + CONVERT(NVARCHAR(50), 10000000 + @i) + '-' + CONVERT(NVARCHAR(50), @i % 10)

			SET @domicilio = 'Ni idea ' + CONVERT(NVARCHAR(255), 1000 + @i*2)

			SET @dia_rendicion = 1 + @i % 28

			SET @porcentaje_comision = 1 + @i % 50

			SET @habilitadx = CONVERT(BIT, @i % 2)

			SET @id_rubro = (SELECT id_rubro FROM SQL_BOYS.Rubro WHERE id_rubro = 1 + @i % @cantidad_rubros)
				
			INSERT INTO SQL_BOYS.Empresa(nombre, cuit, domicilio, dia_rendicion, porcentaje_comision, habilitadx, id_rubro)
				
			VALUES(@nombre, @cuit, @domicilio, @dia_rendicion, @porcentaje_comision, @habilitadx, @id_rubro)

			SET @i = @i + 1;
			
		END

	END

GO