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
    public partial class CustomerRejectOrderView : Form
    {
        // Database connection string
        private string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";

        public CustomerRejectOrderView()
        {
            InitializeComponent();

            CustomerTrackOrderdRejectedItemAdvancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//select row in cel click

            // Set the UserID from the session to the textbox
            CustomerTrackOrderdRejectedItemUserIDBox.Text = UserSession.UserID;

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
                            o.CustomerComment,
                            o.AdminComment
                        FROM 
                            [order] o
                        INNER JOIN 
                            item i ON o.ItemCode = i.ItemCode
                        WHERE 
                            o.UserID = @UserID AND o.OrderStatus = 'Rejected'"; // Changed to 'Rejected'

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use the correct control to get the UserID
                        command.Parameters.AddWithValue("@UserID", CustomerTrackOrderdRejectedItemUserIDBox.Text);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Set the data source for the DataGridView
                            CustomerTrackOrderdRejectedItemAdvancedDataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading ordered items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CustomerTrackOrderdRejectedItemAdvancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Load to boxes Item code, name, Price
                {
                    DataGridViewRow row = CustomerTrackOrderdRejectedItemAdvancedDataGridView1.Rows[e.RowIndex]; // Correct control name

                    CustomerTrackOrderdRejectedItemCodeBox.Text = row.Cells["ItemCode"].Value?.ToString(); // Load ItemCode
                    CustomerTrackOrderdRejectedItemsItemNameBox.Text = row.Cells["ItemName"].Value?.ToString(); // Load ItemName
                    CustomerTrackOrderdRejectedItemItemPriceBox.Text = Convert.ToDecimal(row.Cells["ItemPrice"].Value).ToString("F2"); // Load ItemPrice
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading item details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerTrackOrderdRejectedItemDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the ItemCode from the text box
                string itemCode = CustomerTrackOrderdRejectedItemCodeBox.Text;

                // Check if the ItemCode text box is not empty
                if (!string.IsNullOrEmpty(itemCode))
                {
                    // Ask for confirmation before updating
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update the status to 'RejectRemoved'?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Update the record in the database
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string updateQuery = "UPDATE [order] SET OrderStatus = @OrderStatus, RemoveDate = @RemoveDate WHERE ItemCode = @ItemCode AND UserID = @UserID AND OrderStatus = 'Rejected'";

                            using (SqlCommand command = new SqlCommand(updateQuery, connection))
                            {
                                // Set the parameters for the SQL query
                                command.Parameters.AddWithValue("@ItemCode", itemCode);
                                command.Parameters.AddWithValue("@UserID", CustomerTrackOrderdRejectedItemUserIDBox.Text);
                                command.Parameters.AddWithValue("@RemoveDate", DateTime.Now);
                                command.Parameters.AddWithValue("@OrderStatus", "RejectedRemoved");

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Order status updated successfully to 'RejectRemoved'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Refresh the DataGridView to reflect the changes
                                    LoadOrderedItems();

                                    // Clear the text boxes
                                    CustomerTrackOrderdRejectedItemCodeBox.Text = string.Empty;
                                    CustomerTrackOrderdRejectedItemsItemNameBox.Text = string.Empty;
                                    CustomerTrackOrderdRejectedItemItemPriceBox.Text = string.Empty;
                                }
                                else
                                {
                                    MessageBox.Show("No matching record found or the order status is not 'Rejected'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select an item to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

