using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using RyanNickMasteryProject.Models.CourseModels;

namespace RyanNickMasteryProject.Repositories
{
    public class TeacherRepo
    {
        public List<GetCoursesByTeacherId_Result> GetClassesByTeacherId(int userId)
        {
            using (var db = new SWC_LMSEntities())
            {
                var results = db.GetCoursesByTeacherId(userId).ToList();
                return results;
            }
        }

        public int GetCurrentStudentCountInCourse(int courseId)
        {
            using (var db = new SWC_LMSEntities())
            {
                var results = db.GetStudentsInCourse(courseId).Count();
                return results;
            }
        }

        public List<GetCourseInfo_Result> GetCourseInfo(int courseId)
        {
            using (var db = new SWC_LMSEntities())
            {
                var results = db.GetCourseInfo(courseId).ToList();
                return results;
            }
        }

        public string GetSubjectNameSproc(int subjectId)
        {
            using (var db = new SWC_LMSEntities())
            {
                var result = db.GetSubjectName(subjectId);
                return result.FirstOrDefault();
            }
        }

        public static List<CourseRosterModel> GetCourseRosterData(int courseId)
        {
            var db = new SWC_LMSEntities();
            var rosterData = from l in db.LmsUsers
                join r in db.Rosters
                    on l.UserId equals r.UserId
                join c in db.Courses
                    on r.CourseId equals c.CourseId
                where r.CourseId == courseId && r.IsDeleted == false 
                select new
                {
                    l.FirstName,
                    l.LastName,
                    l.Email,
                    r.CourseId,
                    c.CourseName,
                    l.UserId,
                    r.IsDeleted
                };
            var modelList = new List<CourseRosterModel>();
            foreach (var x in rosterData)
            {
                var model = new CourseRosterModel
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.Email,
                    CourseId = x.CourseId,
                    CourseName = x.CourseName,
                    UserId = x.UserId,
                    IsDeleted = x.IsDeleted
                };
                modelList.Add(model);
            }
            return modelList;
        }

        public static List<GradebookModel> GetGradebookDataRepo(int courseId)
        {
            var db = new SWC_LMSEntities();
            var gradebookData = from a in db.Assignments
                join ra in db.RosterAssignments
                    on a.AssignmentId equals ra.AssignmentId
                join r in db.Rosters
                    on ra.RosterId equals r.RosterId
                join l in db.LmsUsers
                    on r.UserId equals l.UserId
                where a.CourseId == courseId
                                select new
                                {
                                    l.FirstName,
                                    l.LastName,
                                    ra.Grade,
                                    ra.Percentage,
                                    l.UserId,
                                    a.AssignmentId,
                                    a.PossiblePoints,
                                    ra.PointsEarned,
                                    a.CourseId,
                                    a.AssignmentName
                                };
            var modelList = new List<GradebookModel>();
            foreach (var x in gradebookData)
            {
                GradebookModel model = new GradebookModel
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Grade = x.Grade,
                    Percentage = Convert.ToDecimal(x.Percentage),
                    PointsEarned = Convert.ToDecimal(x.PointsEarned),
                    PossiblePoints = Convert.ToDecimal(x.PossiblePoints),
                    CourseId = x.CourseId,
                    UserId = x.UserId,
                    AssignmentId = x.AssignmentId,
                    AssignmentName = x.AssignmentName
                };
                modelList.Add(model);
            }
            return modelList;
        }

        public static List<AddStudentSearchModel> AddStudentSearch(string lastName, int gradeLevelKey)
        {
            using (var db = new SWC_LMSEntities())
            {
                var results =
                    from l in db.LmsUsers
                    join g in db.GradeLevels
                        on l.GradeLevelId equals g.GradeLevelId                    
                    select new
                    {
                        l.FirstName,
                        l.LastName,
                        l.GradeLevelId,
                        g.GradeLevelName
                    };
                var modelList = new List<AddStudentSearchModel>();
                foreach (var x in results)
                {
                    var model = new AddStudentSearchModel
                    {
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        GradeLevelKey = Convert.ToInt32(x.GradeLevelId),
                        GradeLevelName = x.GradeLevelName
                    };
                    modelList.Add(model);
                }
                return modelList.Where(x => x.LastName.ToUpper().Contains(lastName.ToUpper()) ||
                                     x.GradeLevelKey == gradeLevelKey).ToList();

            } 
        }

        public static int GetRosterId(int userId, int courseId)
        {
            var result = 0;
            using (var db = new SWC_LMSEntities())
            {
                var firstOrDefault = db.Rosters.FirstOrDefault(x => x.UserId == userId && x.CourseId == courseId);
                if (firstOrDefault != null)
                {
                    result = firstOrDefault.RosterId;
                }
            }
            return result;
        }
    }
}