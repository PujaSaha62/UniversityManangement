using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagement.Manager;
using UniversityManagement.Models;

namespace UniversityManagement.Controllers
{
    public class CourseController : Controller
    {
        //
        // GET: /Course/
        DepartmentManager departmentManager = new DepartmentManager();
        CoursesManager coursesManager = new CoursesManager();

        public string Save(Courses courses)
        {
            return coursesManager.Save(courses);
        }

        public ActionResult SaveCourse(Courses courses)
        {
            ViewBag.departments = departmentManager.GetAllDepartments();
            ViewBag.courses = coursesManager.GetAllCourses();
            return View();
        }
    }
}