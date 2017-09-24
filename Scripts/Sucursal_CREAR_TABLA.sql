CREATE TABLE Sucursal (
	ID int primary key IDENTITY(1, 1) NOT NULL,
	Nombre NVARCHAR(255) NOT NULL,
	Domicilio NVARCHAR(255) NOT NULL,
	Codigo_Postal NVARCHAR(255) NOT NULL UNIQUE,
)

INSERT INTO Sucursal (Nombre, Domicilio, Codigo_Postal)
SELECT DISTINCT
	[Sucursal_Nombre] AS Nombre
    ,[Sucursal_Dirección] AS Domicilio
    ,[Sucursal_Codigo_Postal] AS Codigo_Postal

	from [GD2C2017].[gd_esquema].[Maestra]

	where Sucursal_Nombre IS NOT NULL AND Sucursal_Dirección IS NOT NULL AND Sucursal_Codigo_Postal IS NOT NULL