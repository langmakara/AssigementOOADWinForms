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
                CommandType = System.Data.CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@InvoiceDetailID", model.InvoiceDetailID == 0 ? DBNull.Value : model.InvoiceDetailID);
            cmd.Parameters.AddWithValue("@InvoiceID", model.InvoiceID);
            cmd.Parameters.AddWithValue("@ProductID", model.ProductID);
            cmd.Parameters.AddWithValue("@Quantity", model.Quantity);
            cmd.Parameters.AddWithValue("@UnitPrice", model.UnitPrice);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // Always get the value returned by your final SELECT @ResultID AS InvoiceDetailID
                return reader.GetInt32(0);
            }

            return model.InvoiceDetailID;
        }

        public List<InvoiceDetailDto> GetByInvoiceID(int invoiceID)
        {
            var list = new List<InvoiceDetailDto>();

            using var conn = HandleConnection.GetSqlConnection();

            var query = @"
    SELECT 
        d.InvoiceDetailID,
        d.InvoiceID,
        d.ProductID,
        d.Quantity,
        d.UnitPrice,
        (d.Quantity * d.UnitPrice) AS TotalPrice,
        p.ProductName
    FROM tbInvoiceDetail d
    INNER JOIN tbProduct p ON d.ProductID = p.ProductID
    WHERE d.InvoiceID = @InvoiceID
    ";

            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@InvoiceID", invoiceID);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new InvoiceDetailDto
                {
                    InvoiceDetailID = reader.GetInt32(reader.GetOrdinal("InvoiceDetailID")),
                    InvoiceID = reader.GetInt32(reader.GetOrdinal("InvoiceID")),
                    ProductID = reader.GetInt32(reader.GetOrdinal("ProductID")),
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
                    ProductName = reader.IsDBNull(reader.GetOrdinal("ProductName"))
                                  ? null
                                  : reader.GetString(reader.GetOrdinal("ProductName"))
                });
            }

            return list;
        }


        public bool Delete(int invoiceDetailID)
        {
            using var conn = HandleConnection.GetSqlConnection();

            using var cmd = new SqlCommand("sp_DeleteInvoiceDetail", conn)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@InvoiceDetailID", invoiceDetailID);

            try
            {
                cmd.ExecuteNonQuery();
                return true; // deletion succeeded
            }
            catch (SqlException ex)
            {
                // optionally log the error
                Console.WriteLine($"Error deleting invoice detail: {ex.Message}");
                return false;
            }
        }

    }

}
