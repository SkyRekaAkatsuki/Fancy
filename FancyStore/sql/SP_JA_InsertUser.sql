CREATE PROCEDURE [dbo].[SP_JA_InsertUser]
	@UserName nvarchar(20) ,
	@UserPassword varbinary(32),
	@Email nvarchar(100),
	@Phone nvarchar(10),
	@Gender bit,
	@CityID nvarchar(1),
	@RegionID int,
	@Address nvarchar(100),
	@GUID nvarchar(36),
	@VerificationCode nvarchar(36)
AS
	INSERT INTO Users(UserName,UserPassword,Email,Phone,Gender,CityID,RegionID,Address,GUID,VerificationCode) 
	Values(@UserName,@UserPassword,@Email,@Phone,@Gender,@CityID,@RegionID,@Address,@GUID,@VerificationCode) 
RETURN 0