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
    }
}
