SET IDENTITY_INSERT Rubro ON
/* Para poder setear la PK con el valor que viene de la tabla maestra. */

INSERT INTO Rubro (id_rubro, descripcion)

	SELECT DISTINCT

	[Empresa_Rubro] AS id_rubro,
	[Rubro_Descripcion] AS descripcion 
		
	FROM [GD2C2017].[gd_esquema].[Maestra];

SET IDENTITY_INSERT Rubro OFF
/* Para no poder setear la PK con otro valor. */