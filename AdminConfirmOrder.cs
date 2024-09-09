using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ABC_Car_Traders.LoginForm;

namespace ABC_Car_Traders
{
    public partial class AdminConfirmOrder : Form
    {
        private BindingSource bindingSource = new BindingSource(); // Declare a BindingSource

        public AdminConfirmOrder()
        {
            InitializeComponent();

            // Assign the user details to the text boxes when the form loads
            AdminDashboardConfirmOrderNameBox.Text = UserSession.UserName;
            AdminDashboardConfirmOrderIdBox.Text = UserSession.UserID;
            AdminDashboardConfirmOrderDateBox.Text = UserSession.LoginDate.ToString("MM/dd/yyyy");// dosent show the time , just date

            LoadData(); // Load data to the grid

            // Set the DataGridView to select the entire row when clicked
            AdminDashboardConfirmOrderGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Attach the CellClick event handler
            AdminDashboardConfirmOrderGridview.CellClick += AdminDashboardConfirmOrderGridview_CellContentClick;
        }

        private void LoadData() // Load all orders with status 'Placed' from the combined order, customer, and item tables into the DataGridView
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                // SQL query to join the order, customer, and item tables
                string query = @"
                    SELECT 
                        o.OrderID,
                        o.ItemCode,
                        o.UserID,
                        c.username,
                        c.NIC,
                        c.telephone,
                        c.email,
                        c.address,
                        o.CustomerComment,
                        o.OrderDate,
                        i.ItemName,
                        i.ItemPrice
                    FROM 
                        [ABC Car Traders].[dbo].[order] o
                    INNER JOIN 
                        [ABC Car Traders].[dbo].[customer] c ON o.UserID = c.userID
                    INNER JOIN 
                        [ABC Car Traders].[dbo].[Item] i ON o.ItemCode = i.ItemCode
                    WHERE 
                        o.OrderStatus = 'Placed'"; // Filter orders by status 'Placed'

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    bindingSource.DataSource = dt; // Corrected: Use bindingSource as the variable name
                    AdminDashboardConfirmOrderGridview.DataSource = bindingSource; // Bind the BindingSource to the DataGridView
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

        private void CustomerFavoriotExitBtn_Click(object sender, EventArgs e)
        {
            // Go back to admin home
            this.Close();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void AdminDashboardConfirmOrderGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event here
            try
            {
                if (e.RowIndex >= 0) // Ensure the row index is valid
                {
                    DataGridViewRow row = AdminDashboardConfirmOrderGridview.Rows[e.RowIndex];

                    // Load the data from the selected row into the text boxes
                    AdminDashboardConfirmOrderOrderIDBox.Text = row.Cells["OrderID"].Value?.ToString();
                    AdminDashboardConfirmOrderItemCodeBox.Text = row.Cells["ItemCode"].Value?.ToString();
                    AdminDashboardConfirmOrderPriceBox.Text = row.Cells["ItemPrice"].Value?.ToString();
                    AdminDashboardConfirmOrderItemNameBox.Text = row.Cells["ItemName"].Value?.ToString();
                    AdminDashboardConfirmOrderCustomerOrderCommentBox.Text = row.Cells["CustomerComment"].Value?.ToString();
                    AdminDashboardConfirmOrderCustomernameBox.Text = row.Cells["username"].Value?.ToString();
                    AdminDashboardConfirmOrderNICBox.Text = row.Cells["NIC"].Value?.ToString();
                    AdminDashboardConfirmOrderAddressBox.Text = row.Cells["address"].Value?.ToString();
                    AdminDashboardConfirmOrderEmailBox.Text = row.Cells["email"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Order Details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDashboardConfirmOrderOrderRejectOrderBtn_Click(object sender, EventArgs e)
        { 
            try
            {
                // Check if an order is selected in the DataGridView
                if (AdminDashboardConfirmOrderGridview.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = AdminDashboardConfirmOrderGridview.SelectedRows[0];
                    string orderID = selectedRow.Cells["OrderID"].Value?.ToString(); // Get selected OrderID
                    string adminComment = AdminDashboardConfirmOrderAdminCommentBox.Text; // Get admin comment
                    string userID = selectedRow.Cells["UserID"].Value?.ToString(); // Assuming UserID is also a column in your grid view

                    // Validate the orderID and userID
                    if (!string.IsNullOrEmpty(orderID) && !string.IsNullOrEmpty(userID))
                    {
                        string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                        // SQL query to update the order status and reject date
                        string updateOrderQuery = @"
                    UPDATE [ABC Car Traders].[dbo].[order]
                    SET 
                        OrderStatus = 'Rejected',
                        RejectDate = @RejectDate,
                        AdminComment = @AdminComment
                    WHERE 
                        OrderID = @OrderID";

                        // SQL query to update the item status
                        string updateItemQuery = @"
                    UPDATE [ABC Car Traders].[dbo].[item]
                    SET 
                        Status = 'Available',
                        StatusChangeDate = @StatusChangeDate
                    WHERE 
                        ItemCode = (SELECT ItemCode FROM [ABC Car Traders].[dbo].[order] 
                                    WHERE OrderID = @OrderID AND UserID = @UserID)";

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open(); // Open the connection once

                            // Command to update order status
                            using (SqlCommand cmd = new SqlCommand(updateOrderQuery, con))
                            {
                                // Set the parameters for the order update
                                cmd.Parameters.AddWithValue("@RejectDate", DateTime.Now);
                                cmd.Parameters.AddWithValue("@OrderID", orderID);
                                cmd.Parameters.AddWithValue("@AdminComment", adminComment);

                                int orderRowsAffected = cmd.ExecuteNonQuery();

                                if (orderRowsAffected > 0)
                                {
                                    // Command to update item status if order update is successful
                                    using (SqlCommand itemCommand = new SqlCommand(updateItemQuery, con))
                                    {
                                        // Set parameters for item update
                                        itemCommand.Parameters.AddWithValue("@StatusChangeDate", DateTime.Now);
                                        itemCommand.Parameters.AddWithValue("@OrderID", orderID);
                                        itemCommand.Parameters.AddWithValue("@UserID", userID);

                                        int itemRowsAffected = itemCommand.ExecuteNonQuery();

                                        if (itemRowsAffected > 0)
                                        {
                                            MessageBox.Show("You have rejected the order, It will availbale in search menu.", "Success",
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);//ok message when rejected
                                            LoadData(); // Refresh the DataGridView to reflect changes
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to update item status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update order status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            con.Close(); // Cloz connection
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No order selected. Please select an order to reject.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


        private void AdminDashboardConfirmOrderConfirmOredrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected order's OrderID
                if (AdminDashboardConfirmOrderGridview.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = AdminDashboardConfirmOrderGridview.SelectedRows[0];
                    string orderID = selectedRow.Cells["OrderID"].Value?.ToString();
                    string adminComment = AdminDashboardConfirmOrderAdminCommentBox.Text; // Get admin comment
                    //string acceptedDate = DateTime.Now.ToString();

                    if (!string.IsNullOrEmpty(orderID))
                    {
                        // SQL queries to update the order status and item status
                        string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";

                        string updateOrderQuery = @"
                    UPDATE [ABC Car Traders].[dbo].[order]
                    SET 
                        OrderStatus = 'Accepted',
                        AcceptedDate = @AcceptedDate,
                        AdminComment = @AdminComment
                    WHERE 
                        OrderID = @OrderID";

                        string updateItemQuery = @"
                    UPDATE Item
                    SET 
                        Status = 'Accepted',
                        StatusChangeDate = @AcceptedDate
                    WHERE 
                        ItemCode = (SELECT ItemCode FROM [ABC Car Traders].[dbo].[order] WHERE OrderID = @OrderID)";

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();

                            // Execute the order update
                            using (SqlCommand cmd = new SqlCommand(updateOrderQuery, con))
                            {
                                // Set the parameters for the order update
                                cmd.Parameters.AddWithValue("@AcceptedDate", DateTime.Now);
                                cmd.Parameters.AddWithValue("@OrderID", orderID);
                                cmd.Parameters.AddWithValue("@AdminComment", string.IsNullOrEmpty(adminComment) ? (object)DBNull.Value : adminComment);

                                int rowsAffectedOrder = cmd.ExecuteNonQuery();

                                if (rowsAffectedOrder > 0)
                                {
                                    // Execute the item update
                                    using (SqlCommand itemCmd = new SqlCommand(updateItemQuery, con))
                                    {
                                        // Set the parameters for the item update
                                        itemCmd.Parameters.AddWithValue("@OrderID", orderID);
                                        itemCmd.Parameters.AddWithValue("@AcceptedDate", DateTime.Now);

                                        int rowsAffectedItem = itemCmd.ExecuteNonQuery();

                                        if (rowsAffectedItem > 0)
                                        {
                                            MessageBox.Show("Order and item status updated to 'Accepted'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to update item status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update order status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            // Refresh the DataGridView to reflect changes
                            LoadData();

                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select an order.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No order selected. Please select an order to accept.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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



        private void AdminDashboardConfirmOrderClearBtn_Click(object sender, EventArgs e)
            {//clear all the boxe whn this butn click
                AdminDashboardConfirmOrderOrderIDBox.Text = "";
                AdminDashboardConfirmOrderItemCodeBox.Text = "";
                AdminDashboardConfirmOrderPriceBox.Text = "";
                AdminDashboardConfirmOrderItemNameBox.Text = "";
                AdminDashboardConfirmOrderCustomerOrderCommentBox.Text = "";
                AdminDashboardConfirmOrderCustomernameBox.Text = "";
                AdminDashboardConfirmOrderNICBox.Text = "";
                AdminDashboardConfirmOrderAddressBox.Text = "";
                AdminDashboardConfirmOrderEmailBox.Text = "";
                AdminDashboardConfirmOrderAdminCommentBox.Text = "";//admin comment null
            }

        }
} 
