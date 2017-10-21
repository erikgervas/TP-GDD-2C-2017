SET IDENTITY_INSERT Rendicion ON;

INSERT INTO Rendicion (numero_rendicion, importe_comision, fecha)

	SELECT DISTINCT
		
		[Rendicion_Nro] AS numero_rendicion,
		[ItemRendicion_Importe] AS importe_comision,
		[Rendicion_Fecha] AS fecha

	FROM

		[GD2C2017].[gd_esquema].[Maestra] m

	WHERE Rendicion_Nro IS NOT NULL

	SET IDENTITY_INSERT Rendicion OFF;