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
                    EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                    EmployeeName = reader.GetString(reader.GetOrdinal("EmployeeName")),
                    TotalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount")),
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
