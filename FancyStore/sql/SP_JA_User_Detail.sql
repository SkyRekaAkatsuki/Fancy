CREATE PROCEDURE [dbo].[SP_JA_User_Detail]
	@UserID int
AS
	SELECT UserID,Email, Phone, CityName,RegionName,Address, Gender, RegistrationDate,GrandAmout,Photo
	FROM dbo.City INNER JOIN
         dbo.Region ON dbo.City.CityID = dbo.Region.CityID INNER JOIN
         dbo.Users ON dbo.City.CityID = dbo.Users.CityID AND dbo.Region.RegionID = dbo.Users.RegionID
	WHERE UserID = @UserID
RETURN 0