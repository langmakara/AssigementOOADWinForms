using AssigementOOADWinForms.DATAs;
using AssigementOOADWinForms.DTOs;
using AssigementOOADWinForms.Models;
using AssigementOOADWinForms.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AssigementOOADWinForms.Controls
{
    public partial class UserControlUser : UserControl
    {
        private List<UserDto> usersList = new();
        private readonly UserService _userService = new();
        public UserControlUser()
        {
            InitializeComponent();
            // UI design helpers
            DesignHelper.MakeAllInputs(this);
            DesignHelper.ApplyRoundedStyle(panel1, borderRadius: 5);
            DesignHelper.ApplyRoundedStyle(panel2, borderRadius: 5);
            DesignHelper.StyleDataGridView(dgvuser);
            // DataGridView config
            dgvuser.SelectionChanged += SelectionRowChanges;
            dgvuser.CellPainting += DesignHelper.dataGridView1_CellPainting;
            dgvuser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvuser.AutoGenerateColumns = true;
            // Events
            btClear.Click += HandleClearTextBox;
            btSave.Click += HandleSaveUser;
            btRemove.Click += HandleRemoveUser;
            tbSeachName.TextChanged += (s, e) => FilterUsers();
            this.Load += (s, e) => LoadUsers();

            // Initialize Role ComboBox
            cbRole.Items.Clear();
            cbRole.Items.Add("All");
            cbRole.Items.AddRange(new object[] { "Admin", "Manager", "Staff" });
            cbRole.SelectedIndex = 0;
            cbRole.SelectedIndexChanged += (s, e) => FilterUsers();
            cbRole1.Items.Clear();
            cbRole1.Items.Add("All");
            cbRole1.Items.AddRange(new object[] { "Admin", "Manager", "Staff" });
            cbRole1.SelectedIndex = 0;
        }
        // ===============================
        // Load Users from database
        // ===============================
        private void LoadUsers()
        {
            try
            {
                var users = _userService.GetAllUsers();
                usersList = users.Select(u => new UserDto
                {
                    UserID = u.UserID,
                    Username = u.Username,
                    PasswordHash = u.PasswordHash,
                    Role = u.Role,
                    CreatedAt = u.CreatedAt
                }).ToList();
                dgvuser.DataSource = usersList;
                HideSensitiveColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ===============================
        // Hide Password Column
        // ===============================
        private void HideSensitiveColumns()
        {
            if (dgvuser.Columns["PasswordHash"] != null)
                dgvuser.Columns["PasswordHash"].Visible = false;
        }
        // ===============================
        // Filter Users by Username & Role
        // ===============================
        private void FilterUsers()
        {
            try
            {
                if (usersList == null || usersList.Count == 0)
                    return;

                var filtered = usersList.AsEnumerable();

                // Filter by Username
                var searchName = tbSeachName.Text?.Trim();
                if (!string.IsNullOrEmpty(searchName))
                {
                    filtered = filtered.Where(u => u.Username != null &&
                                                   u.Username.Contains(searchName, StringComparison.OrdinalIgnoreCase));
                }

                // Filter by Role (ComboBox)
                if (cbRole.SelectedItem is string selectedRole && selectedRole != "All")
                {
                    filtered = filtered.Where(u => u.Role == selectedRole);
                }

                // Update DataGridView
                dgvuser.DataSource = null;
                dgvuser.DataSource = filtered.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while filtering users:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ===============================
        // Clear input fields
        // ===============================
        private void HandleClearTextBox(object sender, EventArgs e)
        {
            tbSeachName.Clear();
            tbID.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            cbRole1.SelectedIndex = -1;
        }
        // ===============================
        // Handle row selection changes
        // ===============================
        private void SelectionRowChanges(object sender, EventArgs e)
        {
            if (dgvuser.SelectedRows.Count > 0)
            {
                var selectedRow = dgvuser.SelectedRows[0];
                var user = selectedRow.DataBoundItem as UserDto;
                if(user != null)
                {
                    tbID.Text = user.UserID.ToString();
                    tbUsername.Text = user.Username;
                    cbRole1.Text = user.Role;
                }

            }
        }
        // ===============================
        // CRUD Logic
        // ===============================
        private void HandleSaveUser(object sender, EventArgs e)
        {
            try
            {
                if (cbRole1.SelectedIndex <= 0 || cbRole1.SelectedItem == null)
                {
                    MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var model = new User
                {
                    UserID = string.IsNullOrWhiteSpace(tbID.Text) ? 0 : int.Parse(tbID.Text),
                    Username = tbUsername.Text,
                    PasswordHash = tbPassword.Text, // In real app, hash the password
                    Role = cbRole1.Text,
                };
                // Call service that executes sp_InsertOrUpdateUser
                _userService.SaveUser(model);
                //MessageBox.Show("User saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save user:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HandleRemoveUser(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbID.Text) || !int.TryParse(tbID.Text, out int userId))
                {
                    MessageBox.Show("Please select a valid user to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _userService.RemoveUser(userId);
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete user:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
