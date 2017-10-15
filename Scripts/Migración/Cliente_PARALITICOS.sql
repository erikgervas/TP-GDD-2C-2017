SELECT DISTINCT p1.[Cliente-Dni], p1.[Cliente-Apellido], p1.[Cliente-Nombre], p1.Cliente_Mail, p1.[Cliente-Fecha_Nac], p1.Cliente_Direccion, p1.Cliente_Codigo_Postal

FROM			gd_esquema.Maestra p1, gd_esquema.Maestra p2

WHERE			p1.[Cliente-Dni] != p2.[Cliente-Dni] AND p1.Cliente_Mail = p2.Cliente_Mail;