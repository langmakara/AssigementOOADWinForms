using Microsoft.Data.SqlClient;
namespace AssigementOOADWinForms.DATAs;
public static class HandleConnection
{
    private static readonly string ConnectionString =@"Data Source=DESKTOP-IBQJ98S\SQLEXPRESS;Initial Catalog=InventoryDB;Integrated Security=True;Encrypt=False";
    public static SqlConnection GetSqlConnection()
    {
        SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error opening SQL connection: " + ex.Message);
                conn.Dispose(); 
                return null;
            }
        }
    }

