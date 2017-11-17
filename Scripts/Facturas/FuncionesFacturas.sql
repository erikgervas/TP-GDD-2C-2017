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

CREATE PROCEDURE SQL_BOYS.bajaDeFactura (@numero_factura NUMERIC(18, 0), @factura_monto_total NUMERIC(18, 2), @factura_fecha_alta DATETIME, @factura_fecha_vencimiento DATETIME, @habilitadx BIT, @dni_cliente NUMERIC(18, 0), @cuit_empresa NVARCHAR(255)) AS

	BEGIN

		BEGIN TRANSACTION

			UPDATE SQL_BOYS.Factura

				SET habilitadx = 0

				WHERE numero_factura = @numero_factura

		COMMIT

	END

GO

CREATE PROCEDURE SQL_BOYS.modificacionDeFactura (@numero_factura NUMERIC(18, 0), @factura_monto_total NUMERIC(18, 2), @factura_fecha_alta DATETIME, @factura_fecha_vencimiento DATETIME, @habilitadx BIT, @dni_cliente NUMERIC(18, 0), @cuit_empresa NVARCHAR(255)) AS
	
	BEGIN

		BEGIN TRANSACTION

			UPDATE SQL_BOYS.Factura

				SET

					factura_monto_total = @factura_monto_total,
					factura_fecha_alta = @factura_fecha_alta,
					factura_fecha_vencimiento = @factura_fecha_vencimiento,
					habilitadx = @habilitadx,
					dni_cliente = @dni_cliente,
					id_empresa = SQL_BOYS.obtenerEmpresa(@cuit_empresa)

				WHERE
				
					numero_factura = @numero_factura

		COMMIT

	END

GO

CREATE FUNCTION SQL_BOYS.filtrarFactura (@numero_factura NUMERIC(18, 0), @cuit_empresa NVARCHAR(255), @dni_cliente NUMERIC(18, 0), @pagada BIT, @rendida BIT, @habilitadx BIT) RETURNS TABLE AS
	
	RETURN

		SELECT
		
			f.numero_factura,
			f.factura_monto_total,
			f.factura_fecha_alta,
			f.factura_fecha_vencimiento,
			f.habilitadx,
			f.dni_cliente,
			f.id_empresa,
			f.numero_rendicion

		FROM SQL_BOYS.Factura f

		WHERE

			f.numero_factura = @numero_factura OR
			f.id_empresa = SQL_BOYS.obtenerEmpresa(@cuit_empresa) OR
			f.dni_cliente = @dni_cliente OR
			(@pagada = 1 AND f.numero_factura IN (SELECT numero_factura FROM Item_Pago)) OR
			(@rendida = 1 AND f.numero_factura IN (SELECT numero_factura FROM Item_Rendicion)) OR
			f.habilitadx = @habilitadx