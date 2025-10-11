using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json; // Install with: Install-Package Newtonsoft.Json

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlUser : UserControl
    {
        private readonly HttpClient _httpClient;

        public UserControlUser()
        {
            InitializeComponent();
            DesignHelper.StyleDataGridView(dgvuser);

            // Set base address of your ASP.NET API
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7247/api/")
            };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbSeach.Clear();
            cbRole1.Select();
        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //Get data from your form controls
                var newUser = new
                {
                    UserID = tbID.Text,
                    Username = tbUsername.Text,
                    Role = cbRole1.Text,
                    CreatedAt = true
                };

                // Convert object to JSON
                var json = JsonConvert.SerializeObject(newUser);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // 🟢 Send POST request to your API
                var response = await _httpClient.PostAsync("users", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("✅ User inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadUsersAsync(); // reload data
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"❌ Insert failed: {response.StatusCode}\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"⚠️ Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🟣 Load all users from API
        private async Task LoadUsersAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("users");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var users = JsonConvert.DeserializeObject<List<User>>(json);

                dgvuser.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load users: " + ex.Message);
            }
        }

        //user model for deserialization
        private class User
        {
            public int UserId { get; set; }
            public string Username { get; set; }
            public string PasswordHash { get; set; }
            public string Role { get; set; }
            public DateTime CreatedAt { get; set; } = DateTime.Now;
        }
    }
}
