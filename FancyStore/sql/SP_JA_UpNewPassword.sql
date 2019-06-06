CREATE PROCEDURE [dbo].[SP_JA_UpNewPassword]
	@Username nvarchar(20),
	@New_PW varbinary(32),
	@Email nvarchar(100),
	@New_GUID nvarchar(36)
AS
	UPDATE Users SET UserPassword=@New_PW,GUID=@New_GUID 
	WHERE UserName = @Username AND Email = @Email
RETURN 0