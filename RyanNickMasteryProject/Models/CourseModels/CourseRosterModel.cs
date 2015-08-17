using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RyanNickMasteryProject.Models.CourseModels
{
    public class CourseRosterModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class AddStudentSearchResult : CourseRosterModel
    {
        public int GradeLevelKey { get; set; }
    }

    public class CourseRosterViewModel
    {
        public int CourseId { get; set; }
        public AddStudentSearchResult SearchModel { get; set; }
        public List<CourseRosterModel> CourseRosterData { get; set; } 
        public List<AddStudentSearchResult> ListForReturnAddStudentSearchResults { get; set; }
    }
}