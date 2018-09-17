using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagement.Models
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
        public int credit { get; set; }
        public string description { get; set; }
        public string semester { get; set; }
        public int DepartmentId { get; set; }
       
    }
}