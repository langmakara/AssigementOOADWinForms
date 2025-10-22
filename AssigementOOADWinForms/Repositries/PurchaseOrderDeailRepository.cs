using System.Data;
using Microsoft.Data.SqlClient;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.DTOs;

namespace AssigementOOADWinForms.Repositries
{
    public class PurchaseOrderDeailRepository
    {
        public List<PurchaseOrderDetail> GetAllPurchaseOrderDetails()
        {
            var PurchaseOrderDeail = new List<PurchaseOrderDetail>();
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null) throw new Exception("Database connection failed.");
                using (SqlCommand cmd = new SqlCommand("sp_GetAllPurchaseDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PurchaseOrderDeail.Add(new PurchaseOrderDetail
                            {
                                PurchaseDetailID = reader.GetInt32(reader.GetOrdinal("PurchaseDetailID")),
                                PurchaseID = reader.GetInt32(reader.GetOrdinal("PurchaseID")),
                                ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                                UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
                            });
                        }
                    }
                }
            }
            return PurchaseOrderDeail; // Ensure a value is returned in all code paths
        }

        public void Save(PurchaseOrderDetail model)
        {
            if(model.PurchaseID == 0 ||
                model.ProductID == 0 ||
                model.Quantity == 0 ||
                model.UnitPrice == 0)
            {
                // បង្ហាញសារព្រមាន (សម្រាប់ Windows Form ឬ Console)
                MessageBox.Show("សូមបញ្ចូល PurchaseID, ProductID, Quantity និង UnitPrice មុនពេលរក្សាទុក!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // បញ្ចប់មុខងារ
            }
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null)
                    throw new Exception("Database connection failed.");
                using (SqlCommand cmd = new SqlCommand("sp_InsertOrUpdatePurchaseDetail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;              
                    var purchaseDetailIdParam = new SqlParameter("@PurchaseDetailID", SqlDbType.Int)
                    {
                        Value = model.PurchaseDetailID
                    };
                    cmd.Parameters.Add(purchaseDetailIdParam);
                    cmd.Parameters.Add(new SqlParameter("@PurchaseID", SqlDbType.Int) { Value = model.PurchaseID });
                    cmd.Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int) { Value = model.ProductID });
                    cmd.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int) { Value = model.Quantity });
                    cmd.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Decimal) { Value = model.UnitPrice });
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Delete(int purchaseDetailID)
        {
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null)
                    throw new Exception("Database connection failed.");
                using (SqlCommand cmd = new SqlCommand("sp_DeletePurchaseDetail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@PurchaseDetailID", SqlDbType.Int) { Value = purchaseDetailID });
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
