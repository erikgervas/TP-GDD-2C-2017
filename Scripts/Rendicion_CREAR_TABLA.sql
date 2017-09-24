CREATE TABLE Rendicion (
	ID int primary key IDENTITY(1, 1) NOT NULL,
	CuandoFueRendida DateTime NOT NULL,
	Id_Empresa int foreign key REFERENCES Empresa(ID) NOT NULL
)

INSERT INTO Rendicion (CuandoFueRendida, Id_Empresa)

	SELECT

		Rendicion_Fecha AS CuandoFueRendida,
		(SELECT ID FROM Empresa where TablaMaestra.Empresa_Cuit = Empresa.Cuit) AS Id_Empresa

	FROM [GD2C2017].[gd_esquema].[Maestra] as TablaMaestra

	WHERE Rendicion_Fecha IS NOT NULL