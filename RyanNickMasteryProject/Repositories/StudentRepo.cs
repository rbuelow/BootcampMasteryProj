using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.WebSockets;
using Microsoft.Owin.Security.Provider;
using RyanNickMasteryProject.Models;
using RyanNickMasteryProject.Models.CourseModels;


namespace RyanNickMasteryProject.Repositories
{
    public class StudentRepo
    {
        public static List<LmsUserSelectCourseNameAndCurrentGrade_Result> GetCourseAndGrade(int userId)
        {
            using (var db = new SWC_LMSEntities())
            {
                var results = db.LmsUserSelectCourseNameAndCurrentGrade(userId).ToList();
                return results;
            }
        }

        public static List<LmsUserAndCourseIdSelectGradesForCourse_Result>
            GetAssignmentNamePercentageScoredAndLetterGrade(int userId, int courseId)
        {
            using (var db = new SWC_LMSEntities())
            {
                var results = db.LmsUserAndCourseIdSelectGradesForCourse(userId, courseId).ToList();
                return results;
            }   
        }

        public static List<StudentCourse> GetStudentCourses(int userId)
        {
            var db = new SWC_LMSEntities();
            var courseList = new List<StudentCourse>();
            var courses = from r in db.Rosters
                where r.UserId == userId
                select r;

            foreach (var x in courses)
            {
                var c = new StudentCourse
                {
                    CourseId = x.CourseId,
                    CurrentGrade = x.CurrentGrade,
                    CourseName = GetCourseNameByCourseId(x.CourseId)

                };

                courseList.Add(c);
            }
            return courseList;
        }

        public static string GetCourseNameByCourseId(int courseId)
        {
            var db = new SWC_LMSEntities();
            var id = from c in db.Courses
                where c.CourseId == courseId
                select c.CourseName;


            return id.FirstOrDefault();
        }


    }
}