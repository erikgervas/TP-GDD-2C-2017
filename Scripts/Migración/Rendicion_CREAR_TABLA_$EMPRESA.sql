CREATE TABLE Rendicion (
	Nro_Rendicion int primary key IDENTITY (1,1) NOT NULL,
	Importe_Comision numeric(18,2) NOT NULL,
	Fecha_Rendicion DateTime NOT NULL,
)

SET IDENTITY_INSERT Rendicion ON;

INSERT INTO Rendicion (Nro_Rendicion, Importe_Comision, Fecha_Rendicion)

	SELECT DISTINCT
		
		[Rendicion_Nro] AS Nro_Rendicion,
		[ItemRendicion_Importe] AS Importe_Comision,
		[Rendicion_Fecha] AS Fecha_Rendicion

	FROM

		[GD2C2017].[gd_esquema].[Maestra] m

	WHERE Rendicion_Nro IS NOT NULL

	SET IDENTITY_INSERT Rendicion OFF;