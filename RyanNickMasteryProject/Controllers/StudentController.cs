using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RyanNickMasteryProject.BizLogic;
using RyanNickMasteryProject.Models;
using RyanNickMasteryProject.Models.CourseModels;
using RyanNickMasteryProject.Repositories;

namespace RyanNickMasteryProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [Authorize(Roles="Admin, Parent, Student")]
        public ActionResult StudentGrades( int courseId, int userId)
        {
            var course = StudentOperations.GetStudentCourse(userId, courseId);
            return View(course);
        }

        [Authorize(Roles="Admin, Parent, Student")]
        public ActionResult StudentDashboard(int id)
        {
            var db = new SWC_LMSEntities();
            var student = new LmsUser();
            var user = db.GetUserById(id);
            foreach (var x in user)
            {
                student.FirstName = x.FirstName;
                student.LastName = x.LastName;
                student.UserId = x.UserId;
            }

            
            return View(student);
        }

        public ActionResult ParentDashboard(int id)
        {
            return View();
        }
    }
}