using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class AdminManageCustomers : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public AdminManageCustomers()
        {
            InitializeComponent();
            LoadData(); // Load data to the grid
            AdminManageCustomerGridView.CellClick += AdminManageCustomersDataGridView_CellClick;
            AdminManageCustomerGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//select row in cel click
        }

        private void LoadData() // Load all customers from the customer table into the DataGridView
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";
                //string query = "SELECT userID, username, NIC, address, telephone, email, role, status FROM customer"; // No need for PW
                //only active and deactice customers(delete customers dont show),pw dosent needed
                string query = "SELECT userID, username, NIC, address, telephone, email, role, status FROM customer WHERE status IN ('Active', 'Deactivate')";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    bindingSource.DataSource = dt; // Bind the DataTable to the BindingSource
                    AdminManageCustomerGridView.DataSource = bindingSource; // Bind the BindingSource to the DataGridView
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminManageCustomersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event here
            try
            {
                if (e.RowIndex >= 0) // Ensure the row index is valid
                {
                    DataGridViewRow row = AdminManageCustomerGridView.Rows[e.RowIndex];

                    // Load the data from the selected row into the text boxes
                    AdminManageCustomerNameBox.Text = row.Cells["username"].Value.ToString();
                    AdminManageCustomerNICBox.Text = row.Cells["NIC"].Value.ToString();
                    AdminManageCustomerAddressBox.Text = row.Cells["address"].Value.ToString();
                    AdminManageCustomersTelephoneBox.Text = row.Cells["telephone"].Value.ToString();
                    AdminManageCustomersEmailBox.Text = row.Cells["email"].Value.ToString();
                    AdminManageCustomersRoleBox.Text = row.Cells["role"].Value.ToString();//comboRole
                    AdminMangeCustomerStatusBox.Text = row.Cells["status"].Value.ToString();//comboStatus
                    AdminManageCustomerUserIDbox.Text = row.Cells["userID"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminMangeCustomerSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                string searchQuery = "SELECT userID, username, NIC, address, telephone, email, role, status " +
                     "FROM customer " +
                     "WHERE (username LIKE @Search OR NIC LIKE @Search OR address LIKE @Search OR telephone LIKE @Search OR email LIKE @Search) " +
                     "AND status != 'Deleted'";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(searchQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Search", $"%{AdminMangeCustomersSearchBox.Text}%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        bindingSource.DataSource = dt; // Update the binding source with the search results
                        AdminManageCustomerGridView.DataSource = bindingSource; // Refresh the DataGridView with the search results
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminManageCustomerSearchClearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AdminMangeCustomersSearchBox.Text = string.Empty;
                bindingSource.Filter = null;
                AdminManageCustomerNameBox.Text = string.Empty;
                AdminManageCustomerNICBox.Text = string.Empty;
                AdminManageCustomerAddressBox.Text = string.Empty;
                AdminManageCustomersTelephoneBox.Text = string.Empty;
                AdminManageCustomersEmailBox.Text = string.Empty;
                AdminManageCustomersRoleBox.SelectedIndex = -1;
                AdminMangeCustomerStatusBox.SelectedIndex = -1;
                AdminManageCustomerUserIDbox.Text = string.Empty;

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while clearing the search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminMangeCustomerDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(AdminManageCustomerUserIDbox.Text))
                {
                    string userId = AdminManageCustomerUserIDbox.Text;

                    // Confirm deletion
                    DialogResult result = MessageBox.Show("Are you sure you want to deactivate this customer?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                        string updateQuery = "UPDATE customer SET status = 'Deleted', [Update Date] = @UpdateDate WHERE userID = @UserID";

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@UserID", userId);
                                cmd.Parameters.Add("@UpdateDate", SqlDbType.DateTime).Value = DateTime.Now;

                                con.Open();//open DB con
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Customer 'Deleted' Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update customer status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                con.Close();//con close
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a customer to Delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AdminMangeCustomerDeactiveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(AdminManageCustomerUserIDbox.Text))
                {
                    string userId = AdminManageCustomerUserIDbox.Text;

                    // Confirm deactivation
                    DialogResult result = MessageBox.Show("Are you sure you want to Deactivate this customer?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                        string updateQuery = "UPDATE customer SET status = 'Deactivate', [Update Date] = @UpdateDate WHERE userID = @UserID";

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                            {
                                cmd.Parameters.AddWithValue("@UserID", userId);
                                cmd.Parameters.Add("@UpdateDate", SqlDbType.DateTime).Value = DateTime.Now;

                                con.Open();//open DB connection
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Customer 'Deactivate' Successfully. You can reactivate it later.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update customer status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                con.Close();//close connection
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a customer to deactivate.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AdminManageCustomerUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(AdminManageCustomerUserIDbox.Text))
                {
                    string userId = AdminManageCustomerUserIDbox.Text.Trim();
                    string username = AdminManageCustomerNameBox.Text.Trim();
                    string nic = AdminManageCustomerNICBox.Text.Trim();
                    string address = AdminManageCustomerAddressBox.Text.Trim();
                    string telephone = AdminManageCustomersTelephoneBox.Text.Trim();
                    string email = AdminManageCustomersEmailBox.Text.Trim();
                    string role = AdminManageCustomersRoleBox.SelectedItem?.ToString();
                    string status = AdminMangeCustomerStatusBox.SelectedItem?.ToString();

                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(address) ||
                        string.IsNullOrEmpty(telephone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role) ||
                        string.IsNullOrEmpty(status))
                    {
                        MessageBox.Show("Please fill all the fields before updating.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Confirmation dialog
                    DialogResult result = MessageBox.Show($"Are you sure you want to update this customer with ID {userId}?",
                        "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                        string updateQuery = "UPDATE customer SET username = @Username, NIC = @NIC, address = @Address, " +
                                             "telephone = @Telephone, email = @Email, role = @Role, status = @Status, [Update Date] = @UpdateDate " +
                                             "WHERE userID = @UserID";

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                            {
                                cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                                cmd.Parameters.Add("@NIC", SqlDbType.NVarChar).Value = nic;
                                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;
                                cmd.Parameters.Add("@Telephone", SqlDbType.NVarChar).Value = telephone;
                                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                                cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = role;
                                cmd.Parameters.Add("@Status", SqlDbType.NVarChar).Value = status;
                                cmd.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = userId;
                                cmd.Parameters.Add("@UpdateDate", SqlDbType.DateTime).Value = DateTime.Now;

                                con.Open();//open DB con
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                con.Close();//close DB con
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a customer to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminManageCustomerExitBtn_Click_1(object sender, EventArgs e)
        {//go back to admin home
            this.Close();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }
    }
} 
