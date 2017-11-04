CREATE FUNCTION SQL_BOYS.obtenerRubros() RETURNS TABLE

	RETURN SELECT r.id_rubro, r.descripcion FROM SQL_BOYS.Rubro r

GO

CREATE PROCEDURE SQL_BOYS.altaDeEmpresa(@nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @domicilio AS NVARCHAR(255), @dia_rendicion AS INT, @habilitadx AS BIT, @nombre_rubro AS NVARCHAR(50)) AS
	
	BEGIN
		
		BEGIN TRANSACTION

			DECLARE @id_rubro NUMERIC(18,0) = (SELECT r.id_rubro FROM SQL_BOYS.Rubro r WHERE @nombre_rubro = r.descripcion)

			INSERT INTO SQL_BOYS.Empresa (nombre, cuit, domicilio, dia_rendicion, habilitadx, id_rubro)

			VALUES (@nombre, @cuit, @domicilio, @dia_rendicion, @habilitadx, @id_rubro)

		COMMIT

	END

GO

CREATE FUNCTION SQL_BOYS.filtrarEmpresa(@nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @nombre_rubro AS NVARCHAR(50)) RETURNS TABLE

	RETURN
	
		SELECT e.id_empresa, e.nombre, e.cuit, e.domicilio, e.dia_rendicion, r.descripcion , e.habilitadx
		
		FROM SQL_BOYS.Empresa e

		JOIN SQL_BOYS.Rubro r ON r.id_rubro = e.id_rubro

		WHERE

			(@nombre IS NOT NULL AND e.nombre LIKE @nombre + '%') OR

			(e.cuit = @cuit) OR

			(r.descripcion = @nombre_rubro)