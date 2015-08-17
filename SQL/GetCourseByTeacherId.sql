CREATE PROCEDURE GetCoursesByTeacherId
	@UserId int
		AS
SELECT *
FROM Course
WHERE UserId = @UserId