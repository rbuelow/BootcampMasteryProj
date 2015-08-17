using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RyanNickMasteryProject.Models.CourseModels
{
    public class AddAssignmentModel
    {
        public string AssignmentName { get; set; }
        public int PossiblePoints { get; set; }
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        //public CourseModel Course { get; set; }
    }
}