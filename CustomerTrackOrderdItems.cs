using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ABC_Car_Traders.LoginForm;

namespace ABC_Car_Traders
{
    public partial class CustomerTrackOrderdItems : Form
    {
        private string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";

        public CustomerTrackOrderdItems()
        {
            InitializeComponent();
            CustomerTrackOrderdItemsAdvancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//select row in cel click
            // Set the UserID from the session to the textbox
            CustomerTrackOrderdItemsItemUserIDBox.Text = UserSession.UserID;

            // Load ordered items into the DataGridView
            LoadOrderedItems();
        }

        private void LoadOrderedItems()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to select ordered items
                    string query = @"
                        SELECT
                            o.OrderID,
                            i.ItemCode,
                            i.ItemName,
                            i.ItemPrice,
                            o.OrderDate,
                            o.CustomerComment
                        FROM 
                            [order] o
                        INNER JOIN 
                            item i ON o.ItemCode = i.ItemCode
                        WHERE 
                            o.UserID = @UserID AND o.OrderStatus = 'Placed'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the UserID parameter from this form
                        command.Parameters.AddWithValue("@UserID", CustomerTrackOrderdItemsItemUserIDBox.Text);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Set the data source for the DataGridView
                            CustomerTrackOrderdItemsAdvancedDataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading ordered items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerTrackOrderdItemsAdvancedDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Load to boxes Item code, name, Price
                {
                    DataGridViewRow row = CustomerTrackOrderdItemsAdvancedDataGridView1.Rows[e.RowIndex];

                    CustomerTrackOrderdOrderIDBox.Text = row.Cells["OrderID"].Value.ToString();
                    CustomerTrackOrderdItemsItemNameBox.Text = row.Cells["ItemName"].Value.ToString();
                    CustomerTrackOrderdItemsItemPriceBox.Text = Convert.ToDecimal(row.Cells["ItemPrice"].Value).ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading item details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerTrackOrderdItemsDeleteBtn_Click(object sender, EventArgs e) // Cancel ordered item
        {
            try
            {
                // Get the OrderID and UserID from the text boxes
                string orderID = CustomerTrackOrderdOrderIDBox.Text;
                string userID = CustomerTrackOrderdItemsItemUserIDBox.Text;

                // Check if the OrderID and UserID text boxes are not empty
                if (!string.IsNullOrEmpty(orderID) && !string.IsNullOrEmpty(userID))
                {
                    // Ask for confirmation before canceling the order
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this order?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Update the order status and item status in the database
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            // Update the item status to 'Available' and set the StatusChangedDate
                            string updateItemQuery = "UPDATE item " +
                                                     "SET Status = 'Available', " +
                                                     "StatusChangeDate = @StatusChangeDate " +
                                                     "WHERE ItemCode = (SELECT ItemCode FROM [order] WHERE OrderID = @OrderID AND UserID = @UserID)";

                            // Update the order status to 'Canceled' and set the CancelDate
                            string updateOrderQuery = "UPDATE [order] " +
                                                      "SET OrderStatus = 'Canceled', " +
                                                      "CancelDate = @CancelDate " +
                                                      "WHERE OrderID = @OrderID AND UserID = @UserID AND OrderStatus = 'Placed'";

                            using (SqlCommand itemCommand = new SqlCommand(updateItemQuery, connection))
                            using (SqlCommand orderCommand = new SqlCommand(updateOrderQuery, connection))
                            {
                                DateTime currentDate = DateTime.Now;

                                // Set parameters for item update
                                itemCommand.Parameters.AddWithValue("@StatusChangeDate", currentDate);
                                itemCommand.Parameters.AddWithValue("@OrderID", orderID);
                                itemCommand.Parameters.AddWithValue("@UserID", userID);

                                // Set parameters for order update
                                orderCommand.Parameters.AddWithValue("@CancelDate", currentDate);
                                orderCommand.Parameters.AddWithValue("@OrderID", orderID);
                                orderCommand.Parameters.AddWithValue("@UserID", userID);

                                // Execute the item update command
                                int itemRowsAffected = itemCommand.ExecuteNonQuery();

                                // Execute the order update command
                                int orderRowsAffected = orderCommand.ExecuteNonQuery();

                                if (itemRowsAffected > 0 && orderRowsAffected > 0)
                                {
                                    MessageBox.Show("Order status set to 'Canceled' and item status set to 'Available' successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Refresh the DataGridView to reflect the changes
                                    LoadOrderedItems();

                                    // Clear the text boxes
                                    CustomerTrackOrderdOrderIDBox.Text = "";
                                    CustomerTrackOrderdItemsItemNameBox.Text = "";
                                    CustomerTrackOrderdItemsItemPriceBox.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("No matching record found or the order status is not 'Placed'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an order to cancel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the order and item status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
