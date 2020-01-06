CREATE PROCEDURE [dbo].[Livro_Add](
	@Titulo VARCHAR(200),
	@Editora VARCHAR(200),
	@Escritor VARCHAR(200),
	@CreatedBy INT,
	@CreatedDate DATETIME,
	@LastUpdatedBy INT,
	@LastUpdatedDate DATETIME
)
AS
BEGIN
	
	SET NOCOUNT ON

	DECLARE @ReturnTable Table(LivroId INT)

	INSERT INTO [Livro] (
		Titulo,
		Editora,
		Escritor,
		CreatedBy,
		CreatedDate,
		LastUpdatedBy,
		LastUpdatedDate
	)
	OUTPUT inserted.LivroId INTO @ReturnTable
	VALUES(
		@Titulo,
		@Editora,
		@Escritor,
		@CreatedBy,
		@CreatedDate,
		@LastUpdatedBy,
		@LastUpdatedDate
	)

	SELECT LivroId FROM @ReturnTable
END