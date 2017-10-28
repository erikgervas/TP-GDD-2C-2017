SET IDENTITY_INSERT Rendicion ON;

INSERT INTO Rendicion (numero_rendicion, importe_comision, fecha_rendicion)

	SELECT DISTINCT
		
		view_numero_rendicion AS numero_rendicion,
		view_importe_comision AS importe_comision,
		view_fecha_rendicion AS fecha_rendicion

	FROM View_Rendicion

	WHERE view_numero_rendicion IS NOT NULL

SET IDENTITY_INSERT Rendicion OFF;