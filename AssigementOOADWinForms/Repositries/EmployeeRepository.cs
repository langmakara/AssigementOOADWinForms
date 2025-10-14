using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigementOOADWinForms.Repositries
{
    public class EmployeeRepository
    {

        public void Save(Employee model)
        {
            // ✅ Check null or empty values before saving
            if (string.IsNullOrWhiteSpace(model.EmployeeName) ||
                string.IsNullOrWhiteSpace(model.Position))
            {
                // បង្ហាញសារព្រមាន (សម្រាប់ Windows Form ឬ Console)
                System.Windows.Forms.MessageBox.Show("សូមបញ្ចូល Employee Name និង Position មុនពេលរក្សាទុក!", "Warning", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                return; // បញ្ចប់មុខងារ
            }
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null)
                    throw new Exception("Database connection failed.");
                using (SqlCommand cmd = new SqlCommand("sp_InsertOrUpdateEmployee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    var employeeIdParam = new SqlParameter("@EmployeeID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(employeeIdParam);
                    // Do not add cmd.Parameters.AddWithValue("@EmployeeID", ...);
                    cmd.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                    cmd.Parameters.AddWithValue("@Phone", (object?)model.Phone ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object?)model.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Address", (object?)model.Address ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Position", (object?)model.Position ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@HireDate", model.HireDate);
                    cmd.ExecuteNonQuery();
                    model.EmployeeID = (int)employeeIdParam.Value;
                }
            }
            MessageBox.Show("រក្សាទុកទិន្នន័យបានជោគជ័យ!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Delete(int employeeId)
        {
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null)
                    throw new Exception("Database connection failed.");
                using (SqlCommand cmd = new SqlCommand("sp_DeleteEmployee", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
