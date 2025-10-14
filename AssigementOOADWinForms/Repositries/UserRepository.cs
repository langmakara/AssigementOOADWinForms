using System.Data;
using Microsoft.Data.SqlClient;
using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.DTOs;

namespace AssigementOOADWinForms.Repositries
{
    public class UserRepository
    {
        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null) throw new Exception("Database connection failed.");
                using (SqlCommand cmd = new SqlCommand("sp_GetAllUsers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash")),
                                Role = reader.GetString(reader.GetOrdinal("Role")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt"))
                            });
                        }
                    }
                }
            }
            return users;
        }

        public void Save(User model)
        {
            // ✅ Check null or empty values before saving
            if (string.IsNullOrWhiteSpace(model.Username) ||
                string.IsNullOrWhiteSpace(model.PasswordHash) ||
                string.IsNullOrWhiteSpace(model.Role))
            {
                // បង្ហាញសារព្រមាន (សម្រាប់ Windows Form ឬ Console)
                MessageBox.Show("សូមបញ្ចូល Username, Password និង Role មុនពេលរក្សាទុក!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // បញ្ចប់មុខងារ
            }

            using (SqlConnection conn = HandleConnection.GetSqlConnection())
            {
                if (conn == null)
                    throw new Exception("Database connection failed.");

                using (SqlCommand cmd = new SqlCommand("sp_InsertOrUpdateUser", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;              

                    var userIdParam = new SqlParameter("@UserID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.InputOutput,
                        Value = model.UserID == 0 ? DBNull.Value : model.UserID
                    };
                    cmd.Parameters.Add(userIdParam);

                    cmd.Parameters.AddWithValue("@Username", model.Username);
                    cmd.Parameters.AddWithValue("@PasswordHash", model.PasswordHash);
                    cmd.Parameters.AddWithValue("@Role", model.Role);

                    cmd.ExecuteNonQuery();

                    if (userIdParam.Value != DBNull.Value)
                        model.UserID = Convert.ToInt32(userIdParam.Value);
                }
            }

            MessageBox.Show("រក្សាទុកទិន្នន័យបានជោគជ័យ!","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        public void Delete(int userId)
        {
            using var conn = HandleConnection.GetSqlConnection();
            using var cmd = new SqlCommand("sp_DeleteUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.ExecuteNonQuery();
        }
    }
}
