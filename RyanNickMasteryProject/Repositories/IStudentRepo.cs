using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanNickMasteryProject.Repositories
{
    interface IStudentRepo
    {
        LmsUserAndCourseIdSelectGradesForCourse_Result GetAssignmentNamePercentageScoredAndLetterGrade(int userId, int courseId);
        LmsUserSelectCourseNameAndCurrentGrade_Result GetCourseAndGrade(int userId);
    }
}
