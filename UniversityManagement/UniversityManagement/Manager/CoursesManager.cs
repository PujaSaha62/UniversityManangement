using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagement.GateWay;
using UniversityManagement.Models;

namespace UniversityManagement.Manager
{
    public class CoursesManager
    {
        CoursesGateWay coursesGateWay=new CoursesGateWay();

        public bool IsExist(string name)
        {
            return coursesGateWay.IsExist(name);
        }
        public List<Courses> GetAllCourses()
        {
            return coursesGateWay.GetAllCourseses();
        }
        public string Save(Courses courses)
        {
            if (IsExist(courses.Name))
            {
                return "Course Name already Exist";
            }
            if (coursesGateWay.Save(courses) > 0)
            {
                return "Course  saved";
            }
            return "failed";
        }
    }
}