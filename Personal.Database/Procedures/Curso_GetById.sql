CREATE PROCEDURE [dbo].[Curso_GetById](@CursoId INT)
AS
BEGIN
	SET NOCOUNT ON

	SELECT
		Cur.CursoId,
		Cur.NomeCurso,
		Cur.DataInicio,
		Cur.DataFinal,
		Cur.CreatedBy,
		Ucr.PrimeiroNome + ' ' + Ucr.UltimoNome AS CreatedName,
		Cur.CreatedDate,
		Cur.LastUpdatedBy,
		Ulup.PrimeiroNome + ' ' + Ulup.UltimoNome AS LastUpdatedName,
		Cur.LastUpdatedDate
	FROM Curso Cur (NOLOCK)
	INNER JOIN [User] Ucr (NOLOCK)
		ON Cur.CreatedBy = Ucr.UserId
	INNER JOIN [User] Ulup (NOLOCK)
		ON Cur.LastUpdatedBy = Ulup.UserId
	WHERE CursoId = @CursoId
END