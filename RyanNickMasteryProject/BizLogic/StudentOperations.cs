using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.Provider;
using RyanNickMasteryProject.Models;
using RyanNickMasteryProject.Repositories;

namespace RyanNickMasteryProject.BizLogic
{
    public class StudentOperations
    {
        public static StudentModel GetStudentDashboardInfo (int userId)
        {
            
            StudentModel student = new StudentModel();
            student.CourseList = new List<StudentCourse>();

            student.UserId = userId;

            foreach (var x in StudentRepo.GetStudentCourses(userId))
            {
                student.CourseList.Add(x);
            }
            return student;
        }

        public static StudentCourse GetStudentCourse(int userId, int courseId)
        {
            var course = from c in StudentRepo.GetStudentCourses(userId)
                where c.CourseId == courseId
                select c;
            return course.FirstOrDefault();
        }
    }
}