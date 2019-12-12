CREATE PROCEDURE [dbo].[User_Update](
	@UserId INT,
	@PrimeiroNome VARCHAR(50),
	@UltimoNome VARCHAR(50),
	@LastUpdatedBy INT,
	@LastUpdatedDate DATETIME
)
AS
BEGIN
	SET NOCOUNT ON

	UPDATE [User] SET
		PrimeiroNome = @PrimeiroNome,
		UltimoNome = @UltimoNome,
		LastUpdatedBy = @LastUpdatedBy,
		LastUpdatedDate = @LastUpdatedDate
	WHERE UserId = @UserId

END