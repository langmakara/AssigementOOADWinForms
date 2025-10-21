using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;

namespace AssigementOOADWinForms.Repositories
{
    public class InventoryTransactionRepository
    {
        // -------------------------
        // Insert or Update Transaction
        // -------------------------
        public void SaveTransaction(InventoryTransaction model)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_InsertOrUpdateInventoryTransaction", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@TransactionID", model.TransactionID);
            cmd.Parameters.AddWithValue("@ProductID", model.ProductID);
            cmd.Parameters.AddWithValue("@ProductName", model.ProductName ?? string.Empty);
            cmd.Parameters.AddWithValue("@ProductUnitPrice", model.ProductUnitPrice);
            cmd.Parameters.AddWithValue("@TransactionType", model.TransactionType);
            cmd.Parameters.AddWithValue("@QuantityChange", model.QuantityChange);
            cmd.Parameters.AddWithValue("@TransactionDate", model.TransactionDate);
            cmd.ExecuteNonQuery();
        }

        // -------------------------
        // Delete Transaction
        // -------------------------
        public void DeleteTransaction(int transactionId)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_DeleteInventoryTransaction", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@TransactionID", transactionId);
            cmd.ExecuteNonQuery();
        }

        // -------------------------
        // Get all transactions using stored procedure
        // -------------------------
        public List<InventoryTransactionDto> GetAllTransactions()
        {
            var list = new List<InventoryTransactionDto>();
            using var conn = HandleConnection.GetSqlConnection();

            using var cmd = new SqlCommand("sp_GetAllInventoryTransactions", conn) // stored procedure
            {
                CommandType = CommandType.StoredProcedure
            };

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new InventoryTransactionDto
                {
                    ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                    ProductName = reader.IsDBNull(reader.GetOrdinal("ProductName"))
                                    ? string.Empty
                                    : reader.GetString(reader.GetOrdinal("ProductName")),
                    UnitPrice = reader.IsDBNull(reader.GetOrdinal("ProductUnitPrice"))
                                    ? 0
                                    : reader.GetDecimal(reader.GetOrdinal("ProductUnitPrice")),
                    TransactionType = reader.IsDBNull(reader.GetOrdinal("TransactionType"))
                                    ? string.Empty
                                    : reader.GetString(reader.GetOrdinal("TransactionType")),
                    QuantityChange = reader.IsDBNull(reader.GetOrdinal("QuantityChange"))
                                    ? 0
                                    : reader.GetInt32(reader.GetOrdinal("QuantityChange")),
                    TransactionDate = reader.IsDBNull(reader.GetOrdinal("TransactionDate"))
                                    ? DateTime.MinValue
                                    : reader.GetDateTime(reader.GetOrdinal("TransactionDate")),
                });
            }

            return list;
        }
    }
}
