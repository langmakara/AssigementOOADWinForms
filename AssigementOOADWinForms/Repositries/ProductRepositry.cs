using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.DTOs;

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
            using var reader = cmd.ExecuteReader();

            int idCol = reader.GetOrdinal("ProductID");
            int nameCol = reader.GetOrdinal("ProductName");
            int priceCol = reader.GetOrdinal("UnitPrice");

            while (reader.Read())
            {
                list.Add(new ProductDto
                {
                    ProductID = reader.GetInt32(idCol),
                    ProductName = reader.IsDBNull(nameCol) ? string.Empty : reader.GetString(nameCol),
                    UnitPrice = reader.GetDecimal(priceCol)
                });
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
                WHERE QuantityInStock BETWEEN 5 AND 10";

            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            int idCol = reader.GetOrdinal("ProductID");
            int nameCol = reader.GetOrdinal("ProductName");
            int priceCol = reader.GetOrdinal("UnitPrice");
            int qtyCol = reader.GetOrdinal("QuantityInStock");

            while (reader.Read())
            {
                list.Add(new ProductDto
                {
                    ProductID = reader.GetInt32(idCol),
                    ProductName = reader.GetString(nameCol),
                    UnitPrice = reader.GetDecimal(priceCol),
                    QuantityInStock = reader.GetInt32(qtyCol)
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

            int nameCol = reader.GetOrdinal("ProductName");
            int priceCol = reader.GetOrdinal("UnitPrice");

            while (reader.Read())
            {
                list.Add(new ProductDto
                {
                    ProductName = reader.GetString(nameCol),
                    UnitPrice = reader.GetDecimal(priceCol)
                });
            }

            return list;
        }
    }
}
