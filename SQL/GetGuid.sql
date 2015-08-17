CREATE PROCEDURE GetGuid
		@Email varchar(50)
	AS
SELECT Id
FROM AspNetUsers
WHERE Email = @Email