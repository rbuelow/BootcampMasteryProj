using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using RyanNickMasteryProject.Models.CourseModels;

namespace RyanNickMasteryProject.Models
{
    public class StudentModel
    {
        public int UserId { get; set; }
        public List<StudentCourse> CourseList { get; set; }
    }
    public class StudentCourse : CourseModel
    {
        public List<Models.CourseModels.Assignment> StudentAssignments { get; set; }
        public string CurrentGrade { get; set; }
    }

   
    
       
    

}