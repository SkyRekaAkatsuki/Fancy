CREATE PROCEDURE [dbo].[SP_JA_NewPasswordCheck]
	@Username nvarchar(20) ,
	@Email nvarchar(100)
AS
	SELECT * FROM Users WHERE UserName = @Username AND Email = @Email
RETURN 0