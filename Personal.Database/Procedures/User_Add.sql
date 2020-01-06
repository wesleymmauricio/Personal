CREATE PROCEDURE [dbo].[User_Add](
	@PrimeiroNome VARCHAR(50),
	@UltimoNome VARCHAR(50),
	@CreatedBy INT,
	@CreatedDate DATETIME,
	@LastUpdatedBy INT,
	@LastUpdatedDate DATETIME
)
AS
BEGIN
	
	SET NOCOUNT ON

	DECLARE @ReturnTable TABLE(UserId INT)

	INSERT INTO [User] (
		PrimeiroNome,
		UltimoNome,
		CreatedBy,
		CreatedDate,
		LastUpdatedBy,
		LastUpdatedDate
	)
	OUTPUT inserted.UserId INTO @ReturnTable
	VALUES(
		@PrimeiroNome,
		@UltimoNome,
		@CreatedBy,
		@CreatedDate,
		@LastUpdatedBy,
		@LastUpdatedDate
	)

	SELECT UserId FROM @ReturnTable
END