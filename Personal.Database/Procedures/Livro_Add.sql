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

	INSERT INTO [Livro] (
		Titulo,
		Editora,
		Escritor,
		CreatedBy,
		CreatedDate,
		LastUpdatedBy,
		LastUpdatedDate
	)
	VALUES(
		@Titulo,
		@Editora,
		@Escritor,
		@CreatedBy,
		@CreatedDate,
		@LastUpdatedBy,
		@LastUpdatedDate
	)
END