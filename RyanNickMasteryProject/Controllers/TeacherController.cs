using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RyanNickMasteryProject.BizLogic;
using RyanNickMasteryProject.Models.CourseModels;
using RyanNickMasteryProject.Repositories;

namespace RyanNickMasteryProject.Controllers
{
    public class TeacherController : Controller
    {
        [Authorize(Roles="Teacher")]
        public ActionResult CourseInformation(int courseId)
        {
            ViewBag.CourseId = courseId;
            var results = TeacherOperations.GetCourseInfo(courseId);
            return View(results);
        }

        public ActionResult CourseRoster(int courseId)
        {
            
            var viewModel = TeacherOperations.GetCourseRoster(courseId);
            
            return View(viewModel);
        }

        public ActionResult CourseGradebook(int courseId)
        {
            var viewModel = TeacherOperations.GetGradebookData(courseId);
            return View(viewModel);
        }

        public ActionResult AddAssignment(int courseId)
        {
            var viewModel = new Assignment {CourseId = courseId};
            return View(viewModel);
        }

        //[HttpPost]
        //public JsonResult Search(AddStudentSearchResult tempSearch)
        //{
        //    if (string.IsNullOrEmpty(tempSearch.LastName))
        //    {
        //        using (var db = new SWC_LMSEntities())
        //        {
        //            var matches = db.LmsUsers.Where(x => x.GradeLevelId != null);
        //            return Json(matches, JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //    else
        //    {
        //        using (var db = new SWC_LMSEntities())
        //        {
        //            var matches = db.LmsUsers.Where(x => x.GradeLevelId != null);
        //            return Json(matches, JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //}

        [HttpPost]
        public ActionResult AddAssignment(Assignment model)
        {
            using (var db = new SWC_LMSEntities())
            {
                db.Assignments.Add(model);
                db.SaveChanges();               
            }
            return RedirectToAction("CourseGradebook", "Teacher", new{courseId=model.CourseId});
        }

        public ActionResult TeacherDashboard(int id)
        {
            var user = AdminRepo.GetLmsUserById(id);
            return View(user);
        }

        public ActionResult DeleteFromRoster(int userId, int rosterId)
        {
            using (var db = new SWC_LMSEntities())
            {
                var result = db.Rosters.FirstOrDefault(x => x.UserId == userId && x.RosterId == rosterId);
                if (result != null) result.IsDeleted = true;
                db.SaveChanges();
                return RedirectToAction("CourseRoster", "Teacher", new {courseId = result.CourseId});
            }
        }
    }
}