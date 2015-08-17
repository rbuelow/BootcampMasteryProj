using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RyanNickMasteryProject.Models.CourseModels;
using RyanNickMasteryProject.Repositories;

namespace RyanNickMasteryProject.Controllers
{
    public class SearchApiController : ApiController
    {
        public List<AddStudentSearchModel> Post(AddStudentSearchModel model)
        {
            var results = TeacherRepo.AddStudentSearch(model.LastName, model.GradeLevelKey);
            return results.Select(x => new AddStudentSearchModel()
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                GradeLevelKey = x.GradeLevelKey,
                GradeLevelName = x.GradeLevelName
            }).ToList();
        } 
    }
}
