using WindowsFormsApp1.Models;
using WindowsFormsApp1.Enums;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.DataAccess
{
    public static class DataBase
    {
        public static List<Employee> GetDataFromDatabase()
        {
            var employeeList = new List<Employee>();
            var connectionString = GetConnectionString();

            using (var connection = new SqlConnection(connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandText = "" +
                        $@"SELECT  emp.Name as Name 
                                  ,emp.Surname as Surname 
                                  ,emp.Birthdate as Birthdate 
                                  ,emp.SSN as SSN
                                  ,emp.Gender as Gender
                             FROM dbo.Employee emp";

                connection.Open();
                    
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var employee = new Employee
                        {
                            CommonInfo = new CommonInfo
                            {
                                Name = !reader.IsDBNull(reader.GetOrdinal("Name"))
                                        ? reader.GetString(reader.GetOrdinal("Name"))
                                        : null,
                                Surname = !reader.IsDBNull(reader.GetOrdinal("Surname"))
                                        ? reader.GetString(reader.GetOrdinal("Surname"))
                                        : null,
                                Birthday = !reader.IsDBNull(reader.GetOrdinal("Birthdate"))
                                        ? reader.GetDateTime(reader.GetOrdinal("Birthdate"))
                                        : (DateTime?)null,
                                Ssn = !reader.IsDBNull(reader.GetOrdinal("SSN"))
                                        ? reader.GetString(reader.GetOrdinal("SSN"))
                                        : null,
                                Gender = !reader.IsDBNull(reader.GetOrdinal("Gender"))
                                        ? (GenderEnum)Enum.Parse(typeof(GenderEnum), reader.GetString(reader.GetOrdinal("Gender")))
                                        : GenderEnum.None,
                            }
                        };

                        employeeList.Add(employee);
                    }
                }            
            }

            return employeeList;          
        }

        public static string SaveEmployeeDataToDataBase(List<Employee> employeeList)
        {
            var connectionString = GetConnectionString();

            using(var connection = new SqlConnection(connectionString))
            {
                try
                {
                    var commandInsertEmployee = connection.CreateCommand();

                    connection.Open();

                    foreach (var employee in employeeList)
                    {
                        
                        commandInsertEmployee.CommandText += $"" +
                            $@"INSERT INTO dbo.Employee(Name, Surname, Birthdate, SSN, Gender)
                                VALUES('{ employee.CommonInfo.Name}',
                                       '{employee.CommonInfo.Surname}', 
                                       '{employee.CommonInfo.Birthday}',
                                       '{employee.CommonInfo.Ssn}',
                                       '{employee.CommonInfo.Gender}'); ";
                    }

                    commandInsertEmployee.ExecuteReader();

                    return "Data was successfully saved to database";
                }
                catch (Exception ex)
                {
                    return $"Data wasn't save to database due to error: {ex.Message}";
                }            
            }
        }

        private static string GetConnectionString()
        {
            return "Integrated Security=SSPI;Initial Catalog=test;Data Source=localhost\\SQLEXPRESS;";
        }
    }
}