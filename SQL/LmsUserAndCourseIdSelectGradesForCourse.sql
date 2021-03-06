CREATE PROCEDURE LmsUserAndCourseIdSelectGradesForCourse
		@UserId int,
		@CourseId int
	AS
SELECT CourseName, AssignmentName, Percentage, Grade
FROM LmsUser u
	INNER JOIN Roster ON u.UserId = Roster.UserId
	INNER JOIN Course ON Roster.CourseId = Course.CourseId
	INNER JOIN Assignment ON Course.CourseId = Assignment.CourseId 
	INNER JOIN RosterAssignment ON RosterAssignment.AssignmentId = Assignment.AssignmentId
WHERE u.UserId = @UserId AND Course.CourseId = @CourseId
