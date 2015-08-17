CREATE PROCEDURE LmsUserSelectCourseNameAndCurrentGrade
		@UserId int
	AS

	SELECT CourseName, CurrentGrade
	FROM LmsUser u
		INNER JOIN Roster ON u.UserId = Roster.UserId
		INNER JOIN Course ON Roster.CourseId = Course.CourseId
	WHERE u.UserId = @UserId