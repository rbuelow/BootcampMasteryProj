using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Security;
using System.Web.Services.Description;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.Provider;
using RyanNickMasteryProject.Models;

namespace RyanNickMasteryProject.Repositories
{
    public class AdminRepo 
    {
        public static List<LmsUserSelectUnassigned_Result> LmsUserSelectUnassigned()
        {
            using (var db = new SWC_LMSEntities())
            {
                var userList = db.LmsUserSelectUnassigned().ToList();
               
                return userList;
            } 
        }

        public static void InsertNewUserToDb(RegisterViewModel rvm, string id)
        {
            using (var db = new SWC_LMSEntities())
            {
                var output = new ObjectParameter("UserId", typeof(int));
                db.LmsUserInsert(id, rvm.FirstName, rvm.LastName, rvm.Email,
                    rvm.GradeLevel, rvm.Role, output);
            }     
        }

        public static string GetId(string email)
        {
            using (var db = new SWC_LMSEntities())
            {
                var results = db.GetGuid(email).FirstOrDefault();
                return results;
            }    
        }

        public static List<string> GetUserRoles(int id)
        {
            var db = new SWC_LMSEntities();
            var roles = db.LmsUserSelectRoleNames(id);
            var userRoles = roles.TakeWhile(n => n != null);
            return userRoles.ToList();
        }

        public static int GetUserIdByEmail(string email)
        {
            var db = new SWC_LMSEntities();
            var id = from l in db.LmsUsers
                where l.Email == email
                select l.UserId;
            return id.FirstOrDefault();

        }

        public static List<AspNetRole> GetAllIdentityUserRoles()
        {
            var db = new SWC_LMSEntities();
            List<AspNetRole> rolesList = new List<AspNetRole>();
            foreach (var x in db.AspNetRoles)
            {
                rolesList.Add(x);
            }
            return rolesList;
        }

        public static LmsUser GetLmsUserById(int id)
        {
            using (var db = new SWC_LMSEntities())
            {
                LmsUser newUser = new LmsUser();
                var user = db.GetUserById(id);

                foreach (var x in user)
                {
                    newUser.UserId = x.UserId;
                    newUser.FirstName = x.FirstName;
                    newUser.LastName = x.LastName;
                    newUser.GradeLevelId = x.GradeLevelId;
                    newUser.SuggestedRole = x.SuggestedRole;
                    newUser.Id = x.Id;
                    newUser.Email = x.Email;
                }
                return newUser;
            }
        }

        //public static void UpdateUser()
        //{
        //    using (var db = new SWC_LMSEntities())
        //    {
        //        L
        //    }

        //}

        
    }
}