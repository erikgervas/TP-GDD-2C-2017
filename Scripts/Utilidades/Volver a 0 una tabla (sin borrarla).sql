DELETE FROM dbo.NOMBRE_TABLA
DBCC CHECKIDENT ('NOMBRE_TABLA', RESEED, 0);