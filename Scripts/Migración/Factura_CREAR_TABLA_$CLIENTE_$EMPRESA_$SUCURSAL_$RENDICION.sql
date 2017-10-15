CREATE TABLE Factura (
	Numero_Factura INT PRIMARY KEY NOT NULL,
	Monto_Total NUMERIC(18, 2) NOT NULL,
	Fecha_Alta DATETIME NOT NULL,
	Fecha_Vencimiento DATETIME NOT NULL,
	Id_Cliente INT FOREIGN KEY REFERENCES Cliente(ID) NOT NULL,
	Id_Empresa INT FOREIGN KEY REFERENCES Empresa(ID) NOT NULL,
	Habilitada BIT
)


INSERT INTO Factura (Numero_Factura, Monto_Total, Fecha_Alta, Fecha_Vencimiento, Id_Cliente, Id_Empresa, Habilitada)

	SELECT DISTINCT
		
		[Nro_Factura] AS Numero_Factura,
		[Factura_Total] AS Monto_Total,
		[Factura_Fecha] AS Fecha_Alta,
		[Factura_Fecha_Vencimiento] AS Fecha_Vencimiento,


		Habilitada = 1

		

	FROM [GD2C2017].[gd_esquema].[Maestra]
	
	WHERE
	;
/* TODO */