CREATE PROCEDURE [dbo].[Curso_Add](
	@NomeCurso VARCHAR(200),
	@DataInicio VARCHAR(200),
	@DataFinal VARCHAR(200),
	@CreatedBy INT,
	@CreatedDate DATETIME,
	@LastUpdatedBy INT,
	@LastUpdatedDate DATETIME
)
AS
BEGIN
	
	SET NOCOUNT ON

	DECLARE @ReturnTable Table(CursoId INT)

	INSERT INTO [Curso] (
		NomeCurso,
		DataInicio,
		DataFinal,
		CreatedBy,
		CreatedDate,
		LastUpdatedBy,
		LastUpdatedDate
	)
	OUTPUT inserted.CursoId INTO @ReturnTable
	VALUES(
		@NomeCurso, 
		@DataInicio,
		@DataFinal,
		@CreatedBy,
		@CreatedDate,
		@LastUpdatedBy,
		@LastUpdatedDate
	)

	SELECT CursoId FROM @ReturnTable
END