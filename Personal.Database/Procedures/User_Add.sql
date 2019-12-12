CREATE PROCEDURE User_Add(
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

	INSERT INTO [User] (
		PrimeiroNome,
		UltimoNome,
		CreatedBy,
		CreatedDate,
		LastUpdatedBy,
		LastUpdatedDate
	)
	VALUES(
		@PrimeiroNome,
		@UltimoNome,
		@CreatedBy,
		@CreatedDate,
		@LastUpdatedBy,
		@LastUpdatedDate
	)
END
