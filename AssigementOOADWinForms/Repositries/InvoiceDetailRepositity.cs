using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.DTOs.AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using Microsoft.Data.SqlClient;

namespace AssigementOOADWinForms.Repositries
{
    public class InvoiceDetailRepository
    {
        public List<InvoiceDetailDto?> GetAll()
        {
            var list = new List<InvoiceDetailDto>();

            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("SELECT * FROM vwInvoiceDetail", conn);
            cmd.CommandType = CommandType.Text;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new InvoiceDetailDto
                {
                    InvoiceDetailID = reader.GetInt32(reader.GetOrdinal("InvoiceDetailID")),
                    InvoiceID = reader.GetInt32(reader.GetOrdinal("InvoiceID")),
                    ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                    ProductName = reader.IsDBNull(reader.GetOrdinal("ProductName"))
                                      ? null
                                      : reader.GetString(reader.GetOrdinal("ProductName")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
                });
            }

            return list;
        }

        public int SaveInvoiceDetail(InvoiceDetail model)
        {
            using var conn = HandleConnection.GetSqlConnection();

            using var cmd = new SqlCommand("spUpsertInvoiceDetail", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@InvoiceDetailID", model.InvoiceDetailID == 0 ? DBNull.Value : model.InvoiceDetailID);
            cmd.Parameters.AddWithValue("@InvoiceID", model.InvoiceID);
            cmd.Parameters.AddWithValue("@ProductID", model.ProductID);
            cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
            cmd.Parameters.AddWithValue("@UnitPrice", model.UnitPrice);

            object result = cmd.ExecuteScalar(); // Returns new InvoiceDetailID if inserted
            if (result != null && int.TryParse(result.ToString(), out int newID))
            {
                return newID;
            }

            return model.InvoiceDetailID; 
        }

    }
}
