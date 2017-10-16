CREATE TABLE Factura (
	Numero_Factura INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Monto_Total NUMERIC(18, 2) NOT NULL,
	Fecha_Alta DATETIME NOT NULL,
	Fecha_Vencimiento DATETIME NOT NULL,
	Id_Cliente INT FOREIGN KEY REFERENCES Cliente(ID) NOT NULL,
	Id_Empresa INT FOREIGN KEY REFERENCES Empresa(ID) NOT NULL,
	Id_Rendicion INT FOREIGN KEY REFERENCES Rendicion(Nro_Rendicion),
	Habilitada BIT
)

SET IDENTITY_INSERT Factura ON;

INSERT INTO Factura (Numero_Factura, Monto_Total, Fecha_Alta, Fecha_Vencimiento, Id_Cliente, Id_Empresa, Id_Rendicion, Habilitada)

	SELECT DISTINCT
		
		[Nro_Factura] AS Numero_Factura,
		[Factura_Total] AS Monto_Total,
		[Factura_Fecha] AS Fecha_Alta,
		[Factura_Fecha_Vencimiento] AS Fecha_Vencimiento,
		c.ID AS Id_Cliente,
		e.ID AS Id_Empresa,
		r.Nro_Rendicion AS Id_Rendicion,
		Habilitada = 1

	FROM

		[GD2C2017].[gd_esquema].[Maestra] m

	JOIN Cliente c ON m.[Cliente-Dni] = c.Dni
	JOIN Empresa e ON m.Empresa_Cuit = e.Cuit
	JOIN Rendicion r ON m.Rendicion_Nro = r.Nro_Rendicion;

SET IDENTITY_INSERT Factura OFF;