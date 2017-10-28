INSERT INTO Medio_De_Pago (descripcion)

	SELECT DISTINCT 

		[FormaPagoDescripcion] AS descripcion

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE [FormaPagoDescripcion] IS NOT NULL;