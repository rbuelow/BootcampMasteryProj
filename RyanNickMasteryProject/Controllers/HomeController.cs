using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RyanNickMasteryProject.Models;
using RyanNickMasteryProject.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RyanNickMasteryProject.Models.CourseModels;


namespace RyanNickMasteryProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Dashboard()
        {
            if (User.IsInRole("Admin"))
            {
              return  RedirectToAction("AdminDashboard", "Admin");
            }
            if (User.IsInRole("Teacher"))
            {
                return RedirectToAction("TeacherDashboard", "Teacher");
            }
            if (User.IsInRole("Parent"))
            {
                return RedirectToAction("ParentDashboard", "Student");
            }
            if (User.IsInRole("Student"))
            {
                return RedirectToAction("StudentDashboard", "Student");
            }

            return RedirectToAction("Index");
        }
    }
}