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
    
    public partial class Roster
    {
        public Roster()
        {
            this.RosterAssignments = new HashSet<RosterAssignment>();
        }
    
        public int RosterId { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public string CurrentGrade { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual LmsUser LmsUser { get; set; }
        public virtual ICollection<RosterAssignment> RosterAssignments { get; set; }
    }
}
