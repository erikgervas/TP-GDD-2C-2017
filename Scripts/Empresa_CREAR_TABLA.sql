CREATE TABLE Empresa (
	ID int primary key IDENTITY(1, 1) NOT NULL,
	Nombre NVARCHAR(255) NOT NULL,
	Cuit NVARCHAR(50) NOT NULL UNIQUE,
	Domicilio NVARCHAR(255) NOT NULL,
	Rubro int NOT NULL,
	Rubro_Descripcion NVARCHAR(50) NOT NULL
)

INSERT INTO Empresa (Nombre, Cuit, Domicilio, Rubro, Rubro_Descripcion)
SELECT DISTINCT 

	[Empresa_Nombre] AS Nombre
	,[Empresa_Cuit] AS Cuit
	,[Empresa_Direccion] AS Domicilio
	,[Empresa_Rubro] AS Rubro
	,[Rubro_Descripcion] AS Descripcion 

	from [GD2C2017].[gd_esquema].[Maestra]