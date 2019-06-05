CREATE PROCEDURE [dbo].[SP_JA_GetGUID]
	@Username nvarchar(20),
	@GUID nvarchar(36) OutPut
AS
	SELECT @GUID = GUID FROM Users WHERE UserName = @Username
RETURN 0