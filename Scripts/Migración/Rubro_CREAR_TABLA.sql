CREATE TABLE Rubro (
	ID INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	Descripcion NVARCHAR(50) NOT NULL 
);

SET IDENTITY_INSERT Rubro ON

INSERT INTO Rubro (ID, Descripcion)

	SELECT DISTINCT

	[Empresa_Rubro] AS ID,
	[Rubro_Descripcion] AS Descripcion 
		
	FROM [GD2C2017].[gd_esquema].[Maestra];

SET IDENTITY_INSERT Rubro OFF