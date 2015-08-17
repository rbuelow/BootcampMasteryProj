using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanNickMasteryProject.Repositories
{
    interface IlmsDbRepo
    {
        GetAssignmentGrades_Result GetAssignmentGrades(int RosterId);
        GetAssignmentsInCourse_Result GetAssignmentsInCourse(int CourseId);
        GetRosterAssignments_Result GetRosterAssignments(int RosterId);
        GetStudentAndRosterId_Result GetStudentAndRosterId(int CourseId);
        GetStudentsInCourse_Result GetStudentsInCourse(int CourseId);
        
        GradeLevelSelectAll_Result GradeLevelSelectAll();
        
        LmsUserSelectByAspNetId_Result LmsUserSelectByAspNetId(int AspNetId);
        LmsUserSelectByUserId_Result LmsUserSelectByUserId(int UserId);
        LmsUserSelectUnassigned_Result LmsUserSelectUnassigned(int UserId);
        
        void UpdateAssignmentGrade(int RosterAssignmentId, decimal PointsEarned, decimal Percentage, int GradeLetter);
        void UpdateRosterCurrentGrade();

    }
}
