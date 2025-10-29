using Microsoft.Data.SqlClient;
namespace AssigementOOADWinForms.DATAs;
public static class HandleConnection
{
    private static readonly string ConnectionString = @"Data Source=DESKTOP-RB2972R\MSSQLSERVER2022;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False";
    public static SqlConnection GetSqlConnection()
    {
        var conn = new SqlConnection(ConnectionString);
        try
        {
            conn.Open();  // must open
            return conn;  // always valid
        }
        catch (SqlException ex)
        {
            conn.Dispose();
            throw new InvalidOperationException("Cannot open SQL connection.", ex);
        }
    }

}

