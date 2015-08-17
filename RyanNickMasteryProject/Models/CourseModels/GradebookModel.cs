using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace RyanNickMasteryProject.Models.CourseModels
{
    public class GradebookModel
    {
        public int CourseId { get; set; }       
        //public List<Assignments> AssignmentsInCourse { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }
        public decimal Percentage { get; set; }
        public int UserId { get; set; }
        public int AssignmentId { get; set; }
        public decimal PossiblePoints { get; set; }
        public decimal PointsEarned { get; set; }
        public string AssignmentName { get; set; }
    }

    public class AddStudentSearchModel : GradebookModel
    {
        public int GradeLevelKey { get; set; }
        public string GradeLevelName { get; set; }
    }
}