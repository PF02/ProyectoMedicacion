USE [C:\PROYECTOMEDICACION\PROYECTOMEDICACION\MEDICACION.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[AgregarMedicamentoConRetorno]
		@Nombre_Medicamento = N'Culitan300mg',
		@Fecha_Expiracion = N'02/06/19',
		@Indicacion = N'fsdfdsf',
		@Dosis = N'2',
		@Contenedor_Medicamento = N'Tabletas'

SELECT	@return_value as 'Return Value'

GO
select *from Medicamento