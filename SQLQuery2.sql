USE [C:\PROYECTOMEDICACION\PROYECTOMEDICACION\MEDICACION.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[EliminarAlergia]
		@IdPersona = 2,
		@IdComponente = 4

SELECT	@return_value as 'Return Value'

GO
