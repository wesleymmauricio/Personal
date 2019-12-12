CREATE PROCEDURE [dbo].[Livro_GetById](@LivroId INT)
AS
BEGIN
	SET NOCOUNT ON

	SELECT
		Li.LivroId,
		Li.Titulo,
		Li.Editora,
		Li.Escritor,
		Li.CreatedBy,
		Ucr.PrimeiroNome + ' ' + Ucr.UltimoNome AS CreatedName,
		Li.CreatedDate,
		Li.LastUpdatedBy,
		Ulup.PrimeiroNome + ' ' + Ulup.UltimoNome AS LastUpdatedName,
		Li.LastUpdatedDate
	FROM Livro Li (NOLOCK)
	INNER JOIN [User] Ucr (NOLOCK)
		ON Li.CreatedBy = Ucr.UserId
	INNER JOIN [User] Ulup (NOLOCK)
		ON Li.LastUpdatedBy = Ulup.UserId
	WHERE LivroId = @LivroId
END
