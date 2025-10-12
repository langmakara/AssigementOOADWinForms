using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;

namespace AssigementOOADWinForms.Services
{
    public class EmployeeService
    {
        public List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();

            try
            {
                using (SqlConnection conn = HandleConnection.GetSqlConnection())
                {
                    if (conn == null)
                        throw new Exception("Database connection failed.");

                    using (SqlCommand cmd = new SqlCommand("sp_GetAllEmployees", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employees.Add(new Employee
                                {
                                    EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName"))
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching employees: {ex.Message}", ex);
            }

            return employees;
        }
    }
}
