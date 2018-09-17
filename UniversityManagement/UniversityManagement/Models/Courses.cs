using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagement.Models
{
    public class Courses
    {
        public int Id { get; set; } 
        public string Code { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public string Description { get; set; }
        public string Semester { get; set; }
        public int DepartmentId { get; set; }
    }
}