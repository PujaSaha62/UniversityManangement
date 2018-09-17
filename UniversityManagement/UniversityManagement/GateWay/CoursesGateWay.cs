using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniversityManagement.Models;

namespace UniversityManagement.GateWay
{
    public class CoursesGateWay:GateWay
    {



        public int Save(Courses  course)
        {



            Query = "INSERT INTO Course_tb (Code,Name,Credit,Description,DepartmentId,Semester) VALUES (@code,@name,@credit,@description,@departmentId,@semester)";
            Command = new SqlCommand(Query, Connection);
            Command.Parameters.Clear();
            Command.Parameters.AddWithValue("code", course.Code);
            Command.Parameters.AddWithValue("name", course.Name);
            Command.Parameters.AddWithValue("credit", course.Credit);
            Command.Parameters.AddWithValue("description", course.Description);
            Command.Parameters.AddWithValue("departmentId", course.DepartmentId);
            Command.Parameters.AddWithValue("semester", course.Semester);
            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
        public bool IsExist(string name)
        {
            Connection.Open();
            string Query = "SELECT * FROM Course_tb WHERE Name='" + name + "'";

            Command = new SqlCommand(Query, Connection);
            SqlDataReader reader = Command.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }

            else
            {
                Connection.Close();
                return false;
            }

        }
         public List<Courses> GetAllCourseses()
        {
            Query = "SELECT * FROM Course_tb";
            Command= new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<Courses> course = new List<Courses>();
            while (Reader.Read())
            {
                Courses courses  = new Courses();

                {
                  courses.Name = Reader["Name"].ToString();
                   courses.Code=Reader["Code"].ToString();
                 //   courses.Credit= (int) Reader["Credit"];
                    courses.Description=Reader["Description"].ToString();
                    //courses.DepartmentId=(int) Reader["DepartmentId"];
                    courses.Semester=Reader["Semester"].ToString();
                };
                course.Add(courses);
            }
            Reader.Close();
            Connection.Close();
            return course;
        }
    }
    }
