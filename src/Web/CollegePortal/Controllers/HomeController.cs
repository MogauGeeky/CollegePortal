using CollegePortal.Business;
using CollegePortal.Business.Dto;
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
            ViewBag.Students = collegePortalManager.GetStudents().Select(c => new SelectListItem {
                Value = c.StudentId.ToString(),
                Text = $"{c.FirstName} {c.Surname}"
            }).ToList();

            ViewBag.Courses = collegePortalManager.GetCourses().Select(c => new SelectListItem {
                Value = c.CourseId.ToString(),
                Text = c.CourseName 
            }).ToList();

            var data = collegePortalManager.GetStudentWithCourseInfo().ToList();

            if(studentId != 0)
                data = data.Where(c => c.StudentId == studentId).ToList();

            if(courseId != 0)
                data = data.Where(c => c.CourseId == courseId).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult AddStudentCourse()
        {
            ViewBag.Students = collegePortalManager.GetStudents().Select(c => new SelectListItem {
                Value = c.StudentId.ToString(),
                Text = $"{c.FirstName} {c.Surname}"
            }).ToList();

            ViewBag.Courses = collegePortalManager.GetCourses().Select(c => new SelectListItem {
                Value = c.CourseId.ToString(),
                Text = c.CourseName 
            }).ToList();

            return View();
        }

        [HttpPost]
        public ActionResult AddStudentCourse(StudentCourseDto studentCouseDto)
        {
            try
            {
                collegePortalManager.AddStudentCourse(studentCouseDto);
                ViewData["Success"] = "Student Course Added";
            }catch (Exception e) 
            {
                // Not recommended for production use
                ModelState.AddModelError(string.Empty, e.Message);
                return View(studentCouseDto);
            }
           
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddCourse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCourse(CourseDto couseDto)
        {
            try
            {
                collegePortalManager.AddCourse(couseDto);
                ViewData["Success"] = "Course Added";
            }catch (Exception e) 
            {
                // Not recommended for production use
                ModelState.AddModelError(string.Empty, e.Message);
                return View(couseDto);
            }
           
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(StudentDto studentDto)
        {
            try
            {
                collegePortalManager.AddStudent(studentDto);
                ViewData["Success"] = "Student Added";
            }catch (Exception e) 
            {
                // Not recommended for production use
                ModelState.AddModelError(string.Empty, e.Message);
                return View(studentDto);
            }
           
            return RedirectToAction("Index");
        }
    }
}
