using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniversityManagement.GateWay;
using UniversityManagement.Models;

namespace UniversityManagement.Manager
{
    public class DepartmentManager
    {
       DepartmentGateWay departmentGateWay = new DepartmentGateWay();

       public bool IsExist(string name)
       {
           return departmentGateWay.IsExist(name);
       }

        public string Save(Department department)
        {
            if (IsExist(department.Name))
            {
                return "Name already Exist";
            }
            if (departmentGateWay.Save(department) > 0)
            {
                return "Department saved";
            }
            return "Code must be between 2 to 7 characters";
        }

        public List<Department> GetAllDepartments()
        {
            return departmentGateWay.GetAllDepartments();
        }

       

    }
}