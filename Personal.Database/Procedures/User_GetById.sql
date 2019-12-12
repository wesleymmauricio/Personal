CREATE PROCEDURE [dbo].[User_GetById](@UserId INT)
AS
BEGIN
	SET NOCOUNT ON

	SELECT 
		Us.UserId,
		Us.PrimeiroNome,
		Us.UltimoNome,
		Us.CreatedBy,
		Ucr.PrimeiroNome + ' ' + Ucr.UltimoNome AS CreatedByName,
		Us.CreatedDate,
		Us.LastUpdatedBy,
		Ulup.PrimeiroNome + ' ' + Ulup.UltimoNome AS LastUpdatedName,
		Us.LastUpdatedDate
	FROM [User] Us (NOLOCK)
	INNER JOIN [User] Ucr (NOLOCK)
		ON Us.UserId = Ucr.UserId
	INNER JOIN [User] Ulup (NOLOCK)
		ON Us.UserId = Ulup.UserId
	WHERE Us.UserId = @UserId
END
