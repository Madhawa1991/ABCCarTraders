using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ABC_Car_Traders.LoginForm;

namespace ABC_Car_Traders
{
    public partial class AdminSoldOrders : Form
    {
        private BindingSource bindingSource = new BindingSource(); // Declare a BindingSource to bind tables
        public AdminSoldOrders()
        {

            InitializeComponent();
            // Assign the user details to the text boxes when the form loads
            AdminDashboardOrderSoldCustomerNameBox.Text = UserSession.UserName;
            AdminDashboardOrderSoldIdBox.Text = UserSession.UserID;
            AdminDashboardOrderSoldDateBox.Text = UserSession.LoginDate.ToString("MM/dd/yyyy");// dosent show the time , just date

            LoadData(); // Load data to the grid

            // Set the DataGridView to select the entire row when clicked
            AdminDashboardOrderSoldGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Attach the CellClick event handler
            AdminDashboardOrderSoldGridview.CellClick += AdminDashboardOrderSoldGridview_CellContentClick;
        }

        private void AdminDashboardOrderSoldExitBtn_Click(object sender, EventArgs e)
        {
            // Go back to admin home
            this.Close();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void AdminDashboardOrderSoldGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event here
            try
            {
                if (e.RowIndex >= 0) // Ensure the row index is valid
                {
                    DataGridViewRow row = AdminDashboardOrderSoldGridview.Rows[e.RowIndex];

                    // Load the data from the selected row into the text boxes
                    AdminDashboardOrderSoldOrderIDBox.Text = row.Cells["OrderID"].Value?.ToString();
                    AdminDashboardOrderSoldItemCodeBox.Text = row.Cells["ItemCode"].Value?.ToString();
                    AdminDashboardOrderSoldItemPriceBox.Text = row.Cells["ItemPrice"].Value?.ToString();
                    AdminDashboardOrderSoldItemNameBox.Text = row.Cells["ItemName"].Value?.ToString();
                    AdminDashboardOrderSoldCustomerOrderCommentBox.Text = row.Cells["CustomerComment"].Value?.ToString();
                    AdminDashboardOrderSoldAdminOrderCommentBox.Text = row.Cells["CustomerComment"].Value?.ToString();
                    AdminDashboardOrderSoldCustomerNameBox.Text = row.Cells["username"].Value?.ToString();
                    AdminDashboardOrderSoldCustomerNameBox.Text = row.Cells["NIC"].Value?.ToString();
                    AdminDashboardOrderSoldAddressBox.Text = row.Cells["address"].Value?.ToString();
                    AdminDashboardOrderSoldEmailBox.Text = row.Cells["email"].Value?.ToString();
                    AdminDashboardOrderSoldTelephoneBox.Text = row.Cells["telephone"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Order Details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminDashboardOrderSoldClearBtn_Click(object sender, EventArgs e)
        {//clear the all texboxes 
            AdminDashboardOrderSoldOrderIDBox.Text = "";
            AdminDashboardOrderSoldItemCodeBox.Text = "";
            AdminDashboardOrderSoldItemPriceBox.Text = "";
            AdminDashboardOrderSoldItemNameBox.Text = "";
            AdminDashboardOrderSoldCustomerOrderCommentBox.Text = "";
            AdminDashboardOrderSoldAdminOrderCommentBox.Text = "";
            AdminDashboardOrderSoldCustomerNameBox.Text = "";
            AdminDashboardOrderSoldCustomerNameBox.Text = "";
            AdminDashboardOrderSoldAddressBox.Text = "";
            AdminDashboardOrderSoldEmailBox.Text = "";
            AdminDashboardOrderSoldAdminCommentBox.Text = "";
            AdminDashboardOrderSoldTelephoneBox.Text = "";
        }

        private void LoadData() // Load all orders with status 'Placed' from the combined order, customer, and item tables into the DataGridView
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";

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
                        o.AdminComment,
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
                        o.OrderStatus = 'Accepted'"; // Filter orders by status 'Placed'

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    bindingSource.DataSource = dt; // Corrected: Use bindingSource as the variable name
                    AdminDashboardOrderSoldGridview.DataSource = bindingSource; // Bind the BindingSource to the DataGridView
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

        private void AdminDaAdminDashboardOrderSoldCanselOrderBtn_Click(object sender, EventArgs e)
        { 
                try
                {
                    // Get the selected order's OrderID
                    if (AdminDashboardOrderSoldGridview.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = AdminDashboardOrderSoldGridview.SelectedRows[0];
                        string orderID = selectedRow.Cells["OrderID"].Value?.ToString();
                        string adminComment = AdminDashboardOrderSoldAdminCommentBox.Text; // Get admin order/cancel comment

                        if (!string.IsNullOrEmpty(orderID))
                        {
                            // SQL queries to update the order status and item status
                            string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                            // SQL query to update the order status to 'Cancelled'
                            string updateOrderQuery = @"
                    UPDATE [ABC Car Traders].[dbo].[order]
                    SET 
                        OrderStatus = 'Cancelled',
                        CancelDate = @CancelledDate,
                        AdminComment = @AdminComment
                    WHERE 
                        OrderID = @OrderID";

                            // SQL query to update the item status to 'Available'
                            string updateItemQuery = @"
                    UPDATE Item
                    SET 
                        Status = 'Available',
                        StatusChangeDate = @StatusChangeDate
                    WHERE 
                        ItemCode = (SELECT ItemCode FROM [ABC Car Traders].[dbo].[order] WHERE OrderID = @OrderID)";

                            using (SqlConnection con = new SqlConnection(connectionString))
                            {
                                con.Open();

                                // Start a transaction to ensure atomicity
                                using (SqlTransaction transaction = con.BeginTransaction())
                                {
                                    try
                                    {
                                        // Execute the order update
                                        using (SqlCommand cmd = new SqlCommand(updateOrderQuery, con, transaction))
                                        {
                                            // Set the parameters for the order update
                                            cmd.Parameters.AddWithValue("@CancelledDate", DateTime.Now);
                                            cmd.Parameters.AddWithValue("@OrderID", orderID);
                                            cmd.Parameters.AddWithValue("@AdminComment", string.IsNullOrEmpty(adminComment) ? (object)DBNull.Value : adminComment);

                                            int rowsAffectedOrder = cmd.ExecuteNonQuery();

                                            if (rowsAffectedOrder > 0)
                                            {
                                                // Execute the item update
                                                using (SqlCommand itemCmd = new SqlCommand(updateItemQuery, con, transaction))
                                                {
                                                    // Set the parameters for the item update
                                                    itemCmd.Parameters.AddWithValue("@OrderID", orderID);
                                                    itemCmd.Parameters.AddWithValue("@StatusChangeDate", DateTime.Now);

                                                    int rowsAffectedItem = itemCmd.ExecuteNonQuery();

                                                    if (rowsAffectedItem > 0)
                                                    {
                                                        // Commit the transaction if both updates were successful
                                                        transaction.Commit();
                                                        MessageBox.Show("Order has been cancelled and item status set to 'Available'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    }
                                                    else
                                                    {
                                                        // Rollback transaction if item update failed
                                                        transaction.Rollback();
                                                        MessageBox.Show("Failed to update item status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                // Rollback transaction if order update failed
                                                transaction.Rollback();
                                                MessageBox.Show("Failed to update order status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        // Rollback transaction in case of any error
                                        transaction.Rollback();
                                        MessageBox.Show($"An error occurred while updating the order and item status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



            private void AdminDashboardOrderSoldBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected order's OrderID
                if (AdminDashboardOrderSoldGridview.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = AdminDashboardOrderSoldGridview.SelectedRows[0];
                    string orderID = selectedRow.Cells["OrderID"].Value?.ToString();
                    string adminComment = AdminDashboardOrderSoldAdminCommentBox.Text; // Get admin oredr/cansel comment
                    //string acceptedDate = DateTime.Now.ToString();

                    if (!string.IsNullOrEmpty(orderID))
                    {
                        // SQL queries to update the order status and item status
                        string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                        //updating sold status
                        string updateOrderQuery = @"
                    UPDATE [ABC Car Traders].[dbo].[order]
                    SET 
                        OrderStatus = 'Sold',
                        AcceptedDate = @SoldDate,
                        AdminComment = @AdminComment
                    WHERE 
                        OrderID = @OrderID";
                        //when order Sold order states gose to Sold(then customers can't see item)
                        string updateItemQuery = @"
                    UPDATE Item
                    SET 
                        Status = 'Sold',
                        StatusChangeDate = @SoldDate
                    WHERE 
                        ItemCode = (SELECT ItemCode FROM [ABC Car Traders].[dbo].[order] WHERE OrderID = @OrderID)";

                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();

                            // Execute the order update
                            using (SqlCommand cmd = new SqlCommand(updateOrderQuery, con))
                            {
                                // Set the parameters for the order update
                                cmd.Parameters.AddWithValue("@SoldDate", DateTime.Now);
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
                                        itemCmd.Parameters.AddWithValue("@SoldDate", DateTime.Now);

                                        int rowsAffectedItem = itemCmd.ExecuteNonQuery();

                                        if (rowsAffectedItem > 0)
                                        {
                                            MessageBox.Show("Order status updated to 'Sold'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                            con.Close();//closed the opened connection
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

    }
}

