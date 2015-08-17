using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace RyanNickMasteryProject.Models.CourseModels
{
    public class CourseModel
    {
        
        public string CourseName { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int GradeLevel { get; set; }
        public bool IsArchived { get; set; }
        public string CourseDescription { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }
        public List<Assignment> CourseAssignments { get; set; }
    }

    public class Assignment
    {
        public string AssignmentName { get; set; }
        public int AssignmentId { get; set; }
        public int PointsPossible { get; set; }
        public int PointsAwarded { get; set; }
        public string LetterGrade { get; set; }
        public int Percentage { get; set; }
    }
}