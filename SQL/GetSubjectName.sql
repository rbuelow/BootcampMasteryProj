CREATE PROCEDURE GetSubjectName
	@SubjectId int
		AS
SELECT SubjectName
FROM Subject
WHERE SubjectId = @SubjectId 