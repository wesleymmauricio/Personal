﻿CREATE PROCEDURE [dbo].[Livro_Delete](@LivroId INT)
AS
BEGIN
	SET NOCOUNT ON
	DELETE FROM [Livro] WHERE LivroId = @LivroId
END