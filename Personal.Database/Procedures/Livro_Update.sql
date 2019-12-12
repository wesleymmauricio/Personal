CREATE PROCEDURE [dbo].[Livro_Update](
	@LivroId INT,
	@Titulo VARCHAR(200),
	@Editora VARCHAR(200),
	@Escritor VARCHAR(200),
	@LastUpdatedBy INT,
	@LastUpdatedDate DATETIME
)
AS
BEGIN
	SET NOCOUNT ON

	UPDATE [Livro] SET
		Titulo = @Titulo,
		Editora = @Editora,
		Escritor = @Escritor,
		LastUpdatedBy = @LastUpdatedBy,
		LastUpdatedDate = @LastUpdatedDate
	WHERE LivroId = @LivroId

END
