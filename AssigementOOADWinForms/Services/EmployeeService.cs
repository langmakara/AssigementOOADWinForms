using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;
using Microsoft.Data.SqlClient;
using AssigementOOADWinForms.Repositries;
using System;
using System.Collections.Generic;
using System.Data;

namespace AssigementOOADWinForms.Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();

            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null) throw new Exception("Database connection failed.");

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
                                EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                                Phone = reader.IsDBNull(reader.GetOrdinal("Phone")) ? null : reader.GetString(reader.GetOrdinal("Phone")),
                                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.IsDBNull(reader.GetOrdinal("Address")) ? null : reader.GetString(reader.GetOrdinal("Address")),
                                Position = reader.IsDBNull(reader.GetOrdinal("Position")) ? null : reader.GetString(reader.GetOrdinal("Position")),
                                HireDate = reader.GetDateTime(reader.GetOrdinal("HireDate"))
                            });
                        }
                    }
                }
            }

            return employees;
        }
        public void SaveEmployee(Employee model) => _employeeRepository.Save(model);
        public void RemoveEmployee(int employeeId) => _employeeRepository.Delete(employeeId);
    }
}
