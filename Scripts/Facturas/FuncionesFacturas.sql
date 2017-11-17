USE GD2C2017

GO

CREATE FUNCTION SQL_BOYS.obtenerEmpresa(@unCuit NVARCHAR(255)) RETURNS INT AS
	
	BEGIN

		RETURN (SELECT id_empresa FROM SQL_BOYS.Empresa WHERE cuit = @unCuit)

	END

GO

CREATE PROCEDURE SQL_BOYS.altaDeFactura (@numero_factura NUMERIC(18, 0), @factura_monto_total NUMERIC(18, 2), @factura_fecha_alta DATETIME, @factura_fecha_vencimiento DATETIME, @habilitadx BIT, @dni_cliente NUMERIC(18, 0), @cuit_empresa NVARCHAR(255)) AS
	
	BEGIN
		
		BEGIN TRANSACTION

			INSERT INTO SQL_BOYS.Factura(numero_factura, factura_monto_total, factura_fecha_alta, factura_fecha_vencimiento, habilitadx, dni_cliente, id_empresa)

				VALUES (@numero_factura, @factura_monto_total, @factura_fecha_alta, @factura_fecha_vencimiento, @habilitadx, @dni_cliente, SQL_BOYS.obtenerEmpresa(@cuit_empresa))

		COMMIT

	END

GO

CREATE PROCEDURE SQL_BOYS.altaDeItem (@nombre NVARCHAR(255), @monto NUMERIC(18, 2), @cantidad INT, @numero_factura NUMERIC(18, 0)) AS
	
	BEGIN

		BEGIN TRANSACTION

			INSERT INTO SQL_BOYS.Item(nombre, monto, cantidad, numero_factura)

				VALUES (@nombre, @monto, @cantidad, @numero_factura)

		COMMIT

	END

GO

CREATE PROCEDURE SQL_BOYS.bajaDeFactura (@id_empresa AS INT, @nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @domicilio AS NVARCHAR(255), @dia_rendicion AS INT, @porcentaje_comision AS INT, @habilitadx AS BIT, @nombre_rubro AS NVARCHAR(50)) AS

	BEGIN

		BEGIN TRANSACTION

			/* TODO */

		COMMIT

	END

GO

CREATE PROCEDURE SQL_BOYS.modificacionDeFactura (@id_empresa AS INT, @nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @domicilio AS NVARCHAR(255), @dia_rendicion AS INT, @porcentaje_comision AS INT, @habilitadx AS BIT, @nombre_rubro AS NVARCHAR(50)) AS

	BEGIN

		BEGIN TRANSACTION

			/* TODO */

		COMMIT

	END

GO

CREATE FUNCTION SQL_BOYS.filtrarFactura (@nombre AS NVARCHAR(255), @cuit AS NVARCHAR(50), @nombre_rubro AS NVARCHAR(50)) RETURNS TABLE

	/* TODO */