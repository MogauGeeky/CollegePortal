using CollegePortal.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegePortal.Controllers
{
    public class HomeController : Controller
    {
        protected readonly ICollegePortalManager collegePortalManager;
        public HomeController(ICollegePortalManager collegePortalManager)
        {
            this.collegePortalManager = collegePortalManager;
        }

        public ActionResult Index(int? studentId = 0, int? courseId = 0)
        {
            ViewBag.Students = collegePortalManager.GetStudents();
            ViewBag.Courses = collegePortalManager.GetCourses();

            var data = collegePortalManager.GetStudentWithCourseInfo();

            if(studentId != 0)
                data.Where(c => c.StudentId == studentId);

            if(courseId != 0)
                data.Where(c => c.CourseId == courseId);

            return View(data);
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
    }
}