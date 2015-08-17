CREATE PROCEDURE GetCourseInfo
	@CourseId int
		AS
SELECT * FROM Course
WHERE CourseId = @CourseId