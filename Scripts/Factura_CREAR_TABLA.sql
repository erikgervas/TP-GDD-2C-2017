SELECT [Nro_Factura]
      ,[Factura_Fecha]
      ,[Factura_Total]
      ,[Factura_Fecha_Vencimiento]

      ,[ItemFactura_Monto]
      ,[ItemFactura_Cantidad]

	  ,[Pago_nro]
      ,[Pago_Fecha]

      ,[ItemPago_nro]
      ,[Total]

      ,[FormaPagoDescripcion]

	  FROM [GD2C2017].[gd_esquema].[Maestra]

CREATE TABLE Factura (
	Numero int primary key NOT NULL,
	Alta DateTime NOT NULL,
	Pago DateTime, /* Hacer tabla? */
	Pago_Numero int, /* Hacer tabla? */
	Vencimiento DateTime NOT NULL,
	Total Numeric(18, 2) NOT NULL,
	FormaPagoDescripcion NVARCHAR(255) NOT NULL,
	Id_Cliente int foreign key REFERENCES Cliente(ID) NOT NULL,
	Id_Empresa int foreign key REFERENCES Empresa(ID) NOT NULL,
	Id_Sucursal int foreign key REFERENCES Sucursal(ID) NOT NULL,
	Id_Rendicion int foreign key REFERENCES Rendicion(ID) NOT NULL
)

/* TODO */