CREATE PROCEDURE [dbo].[Curso_Update](
	@CursoId INT,
	@NomeCurso VARCHAR(200),
	@DataInicio VARCHAR(200),
	@DataFinal VARCHAR(200),
	@LastUpdatedBy INT,
	@LastUpdatedDate DATETIME
)
AS
BEGIN
	SET NOCOUNT ON

	UPDATE [Curso] SET
		NomeCurso = @NomeCurso,
		DataInicio = @DataInicio,
		DataFinal = @DataFinal,
		LastUpdatedBy = @LastUpdatedBy,
		LastUpdatedDate = @LastUpdatedDate
	WHERE CursoId = @CursoId

END
