CREATE VIEW SQL_BOYS.Empresa_View_Empresa_Con_Rubro AS

		SELECT e.id_empresa, e.nombre, e.cuit, e.domicilio, e.dia_rendicion, e.porcentaje_comision, e.id_rubro, r.descripcion , e.habilitadx
		
		FROM SQL_BOYS.Empresa e

		JOIN SQL_BOYS.Rubro r ON r.id_rubro = e.id_rubro

GO

CREATE FUNCTION SQL_BOYS.obtenerRubros () RETURNS TABLE

	RETURN SELECT r.id_rubro, r.descripcion FROM SQL_BOYS.Rubro r

GO

CREATE PROCEDURE SQL_BOYS.altaDeEmpresa (@id_empresa AS INT, @nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @domicilio AS NVARCHAR(255), @dia_rendicion AS INT, @porcentaje_comision AS INT, @habilitadx AS BIT, @nombre_rubro AS NVARCHAR(50)) AS
	
	BEGIN
		
		BEGIN TRANSACTION

			DECLARE @id_rubro NUMERIC(18,0) = (SELECT r.id_rubro FROM SQL_BOYS.Rubro r WHERE @nombre_rubro = r.descripcion)

			INSERT INTO SQL_BOYS.Empresa (nombre, cuit, domicilio, dia_rendicion, porcentaje_comision, habilitadx, id_rubro)

			VALUES (@nombre, @cuit, @domicilio, @dia_rendicion, @porcentaje_comision, @habilitadx, @id_rubro)

		COMMIT

	END

GO

CREATE PROCEDURE SQL_BOYS.bajaDeEmpresa (@id_empresa AS INT, @nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @domicilio AS NVARCHAR(255), @dia_rendicion AS INT, @porcentaje_comision AS INT, @habilitadx AS BIT, @nombre_rubro AS NVARCHAR(50)) AS

	BEGIN

		BEGIN TRANSACTION

			UPDATE SQL_BOYS.Empresa

			SET habilitadx = 0

			WHERE id_empresa = @id_empresa

		COMMIT

	END

GO

CREATE PROCEDURE SQL_BOYS.modificacionDeEmpresa (@id_empresa AS INT, @nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @domicilio AS NVARCHAR(255), @dia_rendicion AS INT, @porcentaje_comision AS INT, @habilitadx AS BIT, @nombre_rubro AS NVARCHAR(50)) AS

	BEGIN

		BEGIN TRANSACTION

			UPDATE SQL_BOYS.Empresa

			SET
			
				nombre = @nombre,
				cuit = @cuit,
				domicilio = @domicilio,
				dia_rendicion = @dia_rendicion,
				porcentaje_comision = @porcentaje_comision,
				id_rubro = (SELECT id_rubro FROM SQL_BOYS.Rubro WHERE descripcion = @nombre_rubro)

			WHERE id_empresa = @id_empresa

		COMMIT

	END

GO

CREATE FUNCTION SQL_BOYS.filtrarEmpresa (@nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @nombre_rubro AS NVARCHAR(50)) RETURNS TABLE

	RETURN
	
		SELECT e.id_empresa, e.nombre, e.cuit, e.domicilio, e.dia_rendicion, e.porcentaje_comision, e.id_rubro, e.descripcion , e.habilitadx
		
		FROM SQL_BOYS.Empresa_View_Empresa_Con_Rubro e

		WHERE

			NOT (LEN(@nombre) = 0 AND LEN(@cuit) = 0 AND LEN(@nombre_rubro) = 0)
			
			AND

			(
				(LEN(@nombre) != 0 AND e.nombre LIKE @nombre + '%') OR

				(LEN(@cuit) != 0 AND e.cuit = @cuit) OR

				(LEN(@nombre_rubro) != 0 AND e.descripcion = @nombre_rubro)
			)