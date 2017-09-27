CREATE TABLE Empresa (
	ID INT PRIMARY KEY IDENTITY(1, 1) NOT NULL,
	Nombre NVARCHAR(255) NOT NULL,
	Cuit NVARCHAR(50) NOT NULL UNIQUE,
	Domicilio NVARCHAR(255) NOT NULL,
	Habilitada BIT,
	Rubro INT FOREIGN KEY REFERENCES Rubro(ID)
);

INSERT INTO Empresa (Nombre, Cuit, Domicilio, Habilitada, Rubro)

	SELECT DISTINCT 

		[Empresa_Nombre] AS Nombre,
		[Empresa_Cuit] AS Cuit,
		[Empresa_Direccion] AS Domicilio,
		Habilitado = 1,
		[Empresa_Rubro] AS Rubro

	FROM [GD2C2017].[gd_esquema].[Maestra];