using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using RyanNickMasteryProject.Models;
using RyanNickMasteryProject.Models.CourseModels;
using RyanNickMasteryProject.Repositories;

namespace RyanNickMasteryProject.BizLogic
{
    public class TeacherOperations
    {
        public static TeacherModel GetTeacherDashboardInfo(int userId)
        {
            TeacherRepo teacherRepo = new TeacherRepo();
            TeacherModel teacherModel = new TeacherModel();
            teacherModel.CourseList = new List<TeacherCourses>();
            //TeacherCourses teacherCourses = new TeacherCourses();

            teacherModel.CurrentCourses = teacherRepo.GetClassesByTeacherId(userId).Count(x => x.IsArchived = true);
            teacherModel.ArchivedCourses = teacherRepo.GetClassesByTeacherId(userId).Count(x => x.IsArchived = false);
            teacherModel.UserId = userId;
            foreach (var x in teacherRepo.GetClassesByTeacherId(userId))
            {
                TeacherCourses tempTC = new TeacherCourses();
                tempTC.CourseName = x.CourseName;
                tempTC.NumOfStudentsInCourse = teacherRepo.GetCurrentStudentCountInCourse(x.CourseId);
                tempTC.CourseId = x.CourseId;
                teacherModel.CourseList.Add(tempTC);
            }
            return teacherModel;
        }

        public static CourseModel GetCourseInfo(int courseId)
        {
            TeacherRepo teacherRepo = new TeacherRepo();
            CourseModel courseModel = new CourseModel();

            foreach (var x in teacherRepo.GetCourseInfo(courseId))
            {
                courseModel.CourseName = x.CourseName;
                courseModel.CourseDescription = x.CourseDescription;
                courseModel.EndDate = x.EndDate;
                courseModel.GradeLevel = x.GradeLevel;
                courseModel.IsArchived = x.IsArchived;
                courseModel.StartDate = x.StartDate;
                courseModel.SubjectId = x.SubjectId;
                courseModel.UserId = x.UserId;
                courseModel.SubjectName = teacherRepo.GetSubjectNameSproc(x.SubjectId);
                courseModel.CourseId = x.CourseId;
            }
            return courseModel;
        }

        public static CourseRosterViewModel GetCourseRoster(int courseId)
        {
            CourseRosterViewModel crvm = new CourseRosterViewModel
            {
                CourseRosterData = TeacherRepo.GetCourseRosterData(courseId),
                ListForReturnAddStudentSearchResults = new List<AddStudentSearchResult>()
            };
            return crvm;
        }

        public static List<GradebookModel> GetGradebookData(int courseId)
        {
            var tempData = TeacherRepo.GetGradebookDataRepo(courseId);
           
            return tempData;
        }
    }
}