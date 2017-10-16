CREATE TABLE Rubro (
	ID INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	Descripcion NVARCHAR(50) NOT NULL 
);

SET IDENTITY_INSERT Rubro ON
/* Para poder setear la PK con el valor que viene de la tabla maestra. */

INSERT INTO Rubro (ID, Descripcion)

	SELECT DISTINCT

	[Empresa_Rubro] AS ID,
	[Rubro_Descripcion] AS Descripcion 
		
	FROM [GD2C2017].[gd_esquema].[Maestra];

SET IDENTITY_INSERT Rubro OFF
/* Para no poder setear la PK con otro valor. */