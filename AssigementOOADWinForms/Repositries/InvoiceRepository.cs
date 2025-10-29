using System.Data;
using Microsoft.Data.SqlClient;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.DTOs;

namespace AssigementOOADWinForms.Repositories
{
    public class InvoiceRepository
    {
        public List<InvoiceDto> GetAll()
        {
            var list = new List<InvoiceDto>();

            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_GetAllInvoices", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new InvoiceDto
                {
                    InvoiceID = reader.GetInt32(reader.GetOrdinal("InvoiceID")),
                    CustomerName = reader.GetString(reader.GetOrdinal("CustomerName")),
                    CustomerPhone = reader.GetString(reader.GetOrdinal("CustomerPhone")),
                    CustomerAddress = reader.GetString(reader.GetOrdinal("CustomerAddress")),
                    EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                    TotalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount")),
                    OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate")),
                     Status = reader.GetString(reader.GetOrdinal("Status")),
                });
            }

            return list;
        }
        public List<InvoiceDto> GetPendingInvoices()
        {
            var list = new List<InvoiceDto>();

            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_GetPendingInvoices", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new InvoiceDto
                {
                    InvoiceID = reader.GetInt32(reader.GetOrdinal("InvoiceID")),
                    CustomerName = reader.IsDBNull(reader.GetOrdinal("CustomerName"))
                                    ? null : reader.GetString(reader.GetOrdinal("CustomerName")),
                    CustomerPhone = reader.IsDBNull(reader.GetOrdinal("CustomerPhone"))
                                    ? null : reader.GetString(reader.GetOrdinal("CustomerPhone")),
                    CustomerAddress = reader.IsDBNull(reader.GetOrdinal("CustomerAddress"))
                                    ? null : reader.GetString(reader.GetOrdinal("CustomerAddress")),
                    EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                    EmployeeName = reader.IsDBNull(reader.GetOrdinal("EmployeeName"))
                                    ? null : reader.GetString(reader.GetOrdinal("EmployeeName")),
                    OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate")),
                    Status = reader.GetString(reader.GetOrdinal("Status")),
                    TotalAmount = reader.IsDBNull(reader.GetOrdinal("TotalAmount"))
                                    ? 0 : reader.GetDecimal(reader.GetOrdinal("TotalAmount"))
                });
            }

            return list;
        }

        // Optional: Mark invoice as delivered
        public void MarkAsDelivered(int invoiceId)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_MarkInvoiceDelivered", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@InvoiceID", invoiceId);
            cmd.ExecuteNonQuery();
        }
        public List<InvoiceDto> GetAllInvoicesLatestFirst()
        {
            var list = new List<InvoiceDto>();
            using var conn = HandleConnection.GetSqlConnection();
            const string query = @"
        SELECT InvoiceID, OrderDate
        FROM tbInvoice
        ORDER BY OrderDate DESC"; // latest first

            using var cmd = new SqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new InvoiceDto
                {
                    InvoiceID = reader.GetInt32(reader.GetOrdinal("InvoiceID")),
                    OrderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"))
                });
            }

            return list;
        }

        public void Save(Invoice model)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_InsertOrUpdateInvoice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            var invoiceIDParam = new SqlParameter("@InvoiceID", SqlDbType.Int)
            {
                Direction = ParameterDirection.InputOutput,
                Value = model.InvoiceID == 0 ? DBNull.Value : model.InvoiceID
            };
            cmd.Parameters.Add(invoiceIDParam);
            cmd.Parameters.AddWithValue("@CustomerName", model.CustomerName);
            cmd.Parameters.AddWithValue("@CustomerPhone", model.CustomerPhone);
            cmd.Parameters.AddWithValue("@CustomerAddress", model.CustomerAddress);
            cmd.Parameters.AddWithValue("@EmployeeID", model.EmployeeID);
            cmd.Parameters.AddWithValue("@OrderDate", model.OrderDate);
            cmd.ExecuteNonQuery();
            if (invoiceIDParam.Value != DBNull.Value)
                model.InvoiceID = Convert.ToInt32(invoiceIDParam.Value);
        }


        public void Delete(int invoiceId)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_DeleteInvoice", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@InvoiceID", invoiceId);
            cmd.ExecuteNonQuery();
        }
    }
}
