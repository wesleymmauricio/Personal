﻿CREATE PROCEDURE [dbo].[User_Delete](@UserId INT)
AS
BEGIN
	SET NOCOUNT ON
	DELETE FROM [User] WHERE UserId = @UserId
END