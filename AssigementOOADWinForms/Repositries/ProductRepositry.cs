using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;


namespace AssigementOOADWinForms.Repositories
{
    public class ProductRepository
    {
        public List<ProductDto> GetIDandName()
        {
            var list = new List<ProductDto>();
            using var conn = HandleConnection.GetSqlConnection();
            const string query = "SELECT ProductID, ProductName, UnitPrice FROM tbProduct";
            using var cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var product = new ProductDto
                {
                    ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                    ProductName = reader.IsDBNull(reader.GetOrdinal("ProductName"))
                        ? string.Empty // ✅ Avoid null warning
                        : reader.GetString(reader.GetOrdinal("ProductName")),
                    UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
                };

                list.Add(product);
            }
            return list;
        }
        public List<ProductDto> GetProductLowStock()
        {
            var list = new List<ProductDto>();

            using var conn = HandleConnection.GetSqlConnection();
            const string query = @"
        SELECT ProductID, ProductName, UnitPrice, QuantityInStock 
        FROM tbProduct 
        WHERE QuantityInStock >= 5 AND QuantityInStock <= 10";

            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ProductDto
                {
                    ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                    ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                    QuantityInStock = reader.GetInt32(reader.GetOrdinal("QuantityInStock")),
                    UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
                });
            }

            return list;
        }
        public List<ProductDto> GetProductOutOfStock()
        {
            var list = new List<ProductDto>();

            using var conn = HandleConnection.GetSqlConnection();
            const string query = @"
        SELECT ProductName, UnitPrice
        FROM tbProduct
        WHERE QuantityInStock = 0";

            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new ProductDto
                {
                    ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                    UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice"))
                });
            }

            return list;
        }

        public void Save(Product model)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_InsertOrUpdateProduct", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductID", model.ProductID == 0 ? (object)DBNull.Value : model.ProductID);
            cmd.Parameters.AddWithValue("@ProductName", model.ProductName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@SupplierID", model.SupplierID == null ? (object)DBNull.Value : model.SupplierID);
            cmd.Parameters.AddWithValue("@SupplierName", model.SupplierName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@UnitPrice", model.UnitPrice);
            cmd.Parameters.AddWithValue("@QuantityInStock", model.QuantityInStock);
            cmd.ExecuteNonQuery();
        }
        public DataTable GetAllProduct()
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("SELECT * FROM tbProduct", conn);
            using var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
