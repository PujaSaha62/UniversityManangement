using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniversityManagement.Manager;
using UniversityManagement.Models;

namespace UniversityManagement.Controllers
{
    public class UniversityController : Controller
    {
        

       DepartmentManager departmentManager = new DepartmentManager();

        public string Save(Department department)
        {
            return departmentManager.Save(department);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department department)
        {
        

            return View();
        }

        public ActionResult ShowDepartments(Department department)
        {

            ViewBag.Departments = departmentManager.GetAllDepartments();
            return View();
        }


    }
}