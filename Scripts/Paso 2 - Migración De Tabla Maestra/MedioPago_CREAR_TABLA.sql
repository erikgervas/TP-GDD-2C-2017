CREATE TABLE MedioPago(
		ID INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
		Descripcion nvarchar(50) NOT NULL,
);

INSERT INTO MedioPago (Descripcion)

	SELECT DISTINCT 

		[FormaPagoDescripcion] AS Descripcion

	FROM [GD2C2017].[gd_esquema].[Maestra]

	WHERE [FormaPagoDescripcion] IS NOT NULL;