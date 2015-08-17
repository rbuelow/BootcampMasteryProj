using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
//using RyanNickMasteryProject.Models;
using RyanNickMasteryProject.Repositories;

namespace RyanNickMasteryProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [Authorize (Roles = "Admin")]
        public ActionResult AdminDashboard()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult UserDetails(int id)
        {
            var user = AdminRepo.GetLmsUserById(id);
            return View(user);
            
        }
        [HttpPost]
        public ActionResult EditUser(LmsUser user)
        {
            var db = new SWC_LMSEntities();
            db.UpdateUser(user.LastName, user.FirstName, user.SuggestedRole, user.UserId);

            return RedirectToAction("AdminDashboard");
        }
    }
}