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
    public class SupplierRepository
    {
        public void Save(Supplier model)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_InsertOrUpdate_Supplier", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SupplierID", model.SupplierID == 0 ? (object)DBNull.Value : model.SupplierID);
            cmd.Parameters.AddWithValue("@SupplierName", model.SupplierName ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ContactName", (object?)model.ContactName ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Phone", (object?)model.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object?)model.Email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", (object?)model.Address ?? DBNull.Value);
            cmd.ExecuteNonQuery();
        }
        public DataTable GetAllSupplier()
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("SELECT * FROM tbSupplier", conn);
            using var adapter = new SqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
