﻿CREATE PROCEDURE [dbo].[Curso_Delete](@CursoId INT)
AS
BEGIN
	SET NOCOUNT ON
	DELETE FROM [Curso] WHERE CursoId = @CursoId
END
