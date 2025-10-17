using System.Data;
using Microsoft.Data.SqlClient;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.DTOs;

namespace AssigementOOADWinForms.Repositries
{
    public class PurchaseOrderRepository
    {
        // Implement data access methods for PurchaseOrder here
        public List<PurchaseOrder> GetAllPurchaseOrders()
        {
            var purchaseOrders = new List<PurchaseOrder>();
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null) throw new Exception("Database connection failed.");
                using (SqlCommand cmd = new SqlCommand("sp_GetAllPurchaseOrders", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            purchaseOrders.Add(new PurchaseOrder
                            {
                                PurchaseID = reader.GetInt32(reader.GetOrdinal("PurchaseID")),
                                SupplierID = reader.IsDBNull(reader.GetOrdinal("SupplierID")) ? null : reader.GetInt32(reader.GetOrdinal("SupplierID")),
                                SupplierName = reader.IsDBNull(reader.GetOrdinal("SupplierName")) ? null : reader.GetString(reader.GetOrdinal("SupplierName")),
                                EmployeeID = reader.IsDBNull(reader.GetOrdinal("EmployeeID")) ? null : reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                EmployeeName = reader.IsDBNull(reader.GetOrdinal("EmployeeName")) ? null : reader.GetString(reader.GetOrdinal("EmployeeName")),
                                OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate")),
                                TotalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount"))
                            });
                        }
                    }
                }
            }
            return purchaseOrders; // Ensure a value is returned in all code paths
        }

        public void Save(PurchaseOrder model)
        {
            // ✅ Check null or empty values before saving
            if (model.SupplierID == null ||
                model.EmployeeID == null ||
                model.OrderDate == default)
            {
                // បង្ហាញសារព្រមាន (សម្រាប់ Windows Form ឬ Console)
                MessageBox.Show("សូមបញ្ចូល SupplierID, EmployeeID, OrderDate និង TotalAmount មុនពេលរក្សាទុក!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // បញ្ចប់មុខងារ
            }
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null)
                    throw new Exception("Database connection failed.");
                using (SqlCommand cmd = new SqlCommand("sp_InsertOrUpdatePurchaseOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;              
                    var purchaseIdParam = new SqlParameter("@PurchaseID", SqlDbType.Int)
                    {
                        Value = model.PurchaseID,
                        Direction = ParameterDirection.InputOutput
                    };
                    cmd.Parameters.Add(purchaseIdParam);
                    cmd.Parameters.AddWithValue("@SupplierID", model.SupplierID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@SupplierName", model.SupplierName ?? "");
                    cmd.Parameters.AddWithValue("@EmployeeID", model.EmployeeID ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@OrderDate", model.OrderDate);
                    cmd.Parameters.AddWithValue("@TotalAmount", model.TotalAmount);
                    cmd.ExecuteNonQuery();
                    // Update the model's PurchaseID with the output value from the stored procedure
                    model.PurchaseID = (int)purchaseIdParam.Value;
                }
            }
        }

        public void Delete(int purchaseID)
        {
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null)
                    throw new Exception("Database connection failed.");
                using (SqlCommand cmd = new SqlCommand("sp_DeletePurchaseOrder", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PurchaseID", purchaseID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
