using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RyanNickMasteryProject.Models
{
    public class TeacherModel
    {
        public int UserId { get; set; }
        public int CurrentCourses { get; set; }
        public int ArchivedCourses { get; set; }
        public List<TeacherCourses> CourseList { get; set; }
    }

    public class TeacherCourses
    {
        public int NumOfStudentsInCourse { get; set; }
        public string CourseName { get; set; }
        public int CourseId { get; set; }
        //public int SubjectId { get; set; }
        //public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }
        //public string GradeLevel { get; set; }
        //public bool IsArchived { get; set; }
        //public string CourseDescription { get; set; }
    }

}