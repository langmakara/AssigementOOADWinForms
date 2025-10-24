using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigementOOADWinForms.Repositries
{
    public class PaymentRepository
    {
        public void Save(Payment model)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_InsertOrUpdatePayment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PaymentID", model.PaymentID == 0 ? (object)DBNull.Value : model.PaymentID);
            cmd.Parameters.AddWithValue("@InvoiceID", model.InvoiceID == 0 ? (object)DBNull.Value : model.InvoiceID);
            cmd.Parameters.AddWithValue("@PaymentDate", model.PaymentDate == DateTime.MinValue ? (object)DBNull.Value : model.PaymentDate);
            cmd.Parameters.AddWithValue("@PaymentMethod", string.IsNullOrEmpty(model.PaymentMethod) ? (object)DBNull.Value : model.PaymentMethod);
            cmd.Parameters.AddWithValue("@AmountPaid", model.AmountPaid == 0 ? (object)DBNull.Value : model.AmountPaid);
            cmd.ExecuteNonQuery();
        }

        public DataTable GetAllPayment()
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("SELECT * FROM tbPayment", conn);
            using var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
