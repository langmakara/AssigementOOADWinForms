using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.DATAs;

namespace AssigementOOADWinForms.Repositories
{
    public class StockAdjustmentRepository
    {
        // Get all stock adjustments
        public List<StockAdjustment> GetAll()
        {
            var list = new List<StockAdjustment>();

            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_GetAllStockAdjustments", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new StockAdjustment
                {
                    AdjustmentID = reader.GetInt32(reader.GetOrdinal("AdjustmentID")),
                    ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                    EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                    AdjustmentType = reader.GetString(reader.GetOrdinal("AdjustmentType")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Reason = reader.IsDBNull(reader.GetOrdinal("Reason")) ? null : reader.GetString(reader.GetOrdinal("Reason")),
                    AdjustmentDate = reader.GetDateTime(reader.GetOrdinal("AdjustmentDate"))
                });
            }

            return list;
        }

        // Save or update a stock adjustment
        public void Save(StockAdjustment model)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_InsertOrUpdateStockAdjustment", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            var paramID = new SqlParameter("@AdjustmentID", SqlDbType.Int)
            {
                Direction = ParameterDirection.InputOutput,
                Value = model.AdjustmentID == 0 ? DBNull.Value : model.AdjustmentID
            };
            cmd.Parameters.Add(paramID);

            cmd.Parameters.AddWithValue("@ProductID", model.ProductID);
            cmd.Parameters.AddWithValue("@EmployeeID", model.EmployeeID);
            cmd.Parameters.AddWithValue("@AdjustmentType", model.AdjustmentType);
            cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
            cmd.Parameters.AddWithValue("@Reason", (object?)model.Reason ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@AdjustmentDate", model.AdjustmentDate);

            cmd.ExecuteNonQuery();

            if (paramID.Value != DBNull.Value)
                model.AdjustmentID = Convert.ToInt32(paramID.Value);
        }

        // Delete a stock adjustment by ID
        public void Delete(int adjustmentID)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_DeleteStockAdjustment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AdjustmentID", adjustmentID);
            cmd.ExecuteNonQuery();
        }

        // Optional: Get adjustments by ProductID
        public List<StockAdjustment> GetByProductID(int productID)
        {
            var list = new List<StockAdjustment>();

            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_GetStockAdjustmentsByProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductID", productID);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new StockAdjustment
                {
                    AdjustmentID = reader.GetInt32(reader.GetOrdinal("AdjustmentID")),
                    ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                    EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                    AdjustmentType = reader.GetString(reader.GetOrdinal("AdjustmentType")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Reason = reader.IsDBNull(reader.GetOrdinal("Reason")) ? null : reader.GetString(reader.GetOrdinal("Reason")),
                    AdjustmentDate = reader.GetDateTime(reader.GetOrdinal("AdjustmentDate"))
                });
            }

            return list;
        }
    }
}
