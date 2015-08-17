//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RyanNickMasteryProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
        public Course()
        {
            this.Assignments = new HashSet<Assignment>();
            this.Rosters = new HashSet<Roster>();
        }
    
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public int SubjectId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public byte GradeLevel { get; set; }
        public bool IsArchived { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual LmsUser LmsUser { get; set; }
        public virtual ICollection<Roster> Rosters { get; set; }
    }
}