using System.Collections.Generic;
using System.Data.SqlClient;
using UniversityManagement.Models;

namespace UniversityManagement.GateWay
{
    public class DepartmentGateWay : GateWay
    {
        public int Save(Department department)
        {


        
                Query = "INSERT INTO Department_tb (Code,Name) VALUES (@code,@name)";
                Command = new SqlCommand(Query, Connection);
                Command.Parameters.Clear();
                Command.Parameters.AddWithValue("code", department.Code);
                Command.Parameters.AddWithValue("name", department.Name);
                Connection.Open();
               
                int rowAffected = Command.ExecuteNonQuery();
                Connection.Close();
                return rowAffected;
            }
          

        


        public bool IsExist  (string name)
            {
                Connection.Open();
                string Query = "SELECT * FROM Department_tb WHERE Name='" + name + "'";

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

       
           public List<Department> GetAllDepartments ()
           
            {

                Connection.Open();

                string Query = "SELECT * FROM Department_tb";


                Command = new SqlCommand(Query, Connection);

                SqlDataReader reader = Command.ExecuteReader();

                List<Department> departments = new List<Department>();

                Department department = null;

                while (reader.Read())
                {
                    department = new Department();

                    department.Name = reader["Name"].ToString();
                    department.Code = reader["Code"].ToString();

                    departments.Add(department);
                }

                Connection.Close();

                reader.Close();

                return departments;

            }

        }
    }
