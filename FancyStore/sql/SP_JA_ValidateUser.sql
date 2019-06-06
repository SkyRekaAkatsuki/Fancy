CREATE PROCEDURE [dbo].[SP_JA_ValidateUser]
	@UserName nvarchar(20) ,
	@UserPassword varbinary(32),
	@UserID int OUTPUT
AS
	SELECT @UserID = UserID FROM Users 
	WHERE UserName = @Username AND UserPassword = @UserPassword AND Enabled = 1 AND VerificationCode = ''
RETURN 0