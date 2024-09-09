using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using static ABC_Car_Traders.LoginForm;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace ABC_Car_Traders
{
    public partial class CustomerFavarioutItems : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";
        private string OrderID = string.Empty;
        public CustomerFavarioutItems()
        {
            InitializeComponent();
            CustomerFavorioutitemsUsernameBox.Text = UserSession.UserName; // login name
            CustomerFavorioutitemsUserIDBox.Text = UserSession.UserID; // login ID
            CustomerFavorioutitemsTimeBox.Text = DateTime.Now.ToString("yyyy-MM-dd");

            CustomerFavorioutitemGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//select row in cel click

            LoadData(); // Call the LoadData method to populate the DataGridView

            // Subscribe to the TextChanged event to trigger the search when text changes
            CustomerFavorioteSearchBox.TextChanged += CustomerFavorioutitemSearchBox_TextChanged;
        }

        private void CustomerFavoriotExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerDashBoard customerDashBoard = new CustomerDashBoard();
            customerDashBoard.Show();
        }

        // Method to load favorite items into CustomerFavorioutitemGridview
        private void LoadData(string searchQuery = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // SQL query to load item details for the current user's favorite items
                    string query = @"
                        SELECT
                            o.OrderID,
                            i.ItemCode, 
                            i.[Vehicle/Part], 
                            i.ItemName, 
                            i.ItemPrice, 
                            i.Brand, 
                            i.ModelYear, 
                            i.Type, 
                            i.Condition, 
                            i.FuelType, 
                            i.Mileage, 
                            i.Description, 
                            i.ItemImage 
                        FROM 
                            item i
                        INNER JOIN 
                            [order] o ON i.ItemCode = o.ItemCode
                        WHERE 
                            o.UserID = @UserID 
                            AND o.OrderStatus = 'Favorite' 
                            AND i.Status = 'Available'";

                    // search box searching
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query += @"
                            AND (i.ItemCode LIKE @Search 
                            OR i.ItemName LIKE @Search 
                            OR i.Brand LIKE @Search 
                            OR i.ModelYear LIKE @Search 
                            OR i.Type LIKE @Search 
                            OR i.Condition LIKE @Search 
                            OR i.FuelType LIKE @Search 
                            OR i.Description LIKE @Search)";
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use the current user's ID to filter the results
                        command.Parameters.AddWithValue("@UserID", UserSession.UserID);

                        // Add the search parameter if there's a search query
                        if (!string.IsNullOrEmpty(searchQuery))
                        {
                            command.Parameters.AddWithValue("@Search", $"%{searchQuery}%");
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            bindingSource.DataSource = dataTable;
                            CustomerFavorioutitemGridview.DataSource = bindingSource;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading favorite items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for search box text change to filter the grid view
        private void CustomerFavorioutitemSearchBox_TextChanged(object sender, EventArgs e)
        {
            // Call LoadData with the search text to filter the grid view based on the search text
            LoadData(CustomerFavorioteSearchBox.Text);
        }

        private void itemSearchButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Go to customer search menu
            CustomerItemSearch customerItemSearch = new CustomerItemSearch();
            customerItemSearch.Show();
        }

        private void CustomerFavorioutitemGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = CustomerFavorioutitemGridview.Rows[e.RowIndex];

                    CustomerFavorioteSearchItemCodeBox.Text = row.Cells["ItemCode"].Value.ToString();
                    CustomerFavorioteSearchVehiclePartBox.Text = row.Cells["Vehicle/Part"].Value.ToString();
                    CustomerFavorioteNameBox.Text = row.Cells["ItemName"].Value.ToString();
                    CustomerFavorioteSearchPriceBox.Text = Convert.ToDecimal(row.Cells["ItemPrice"].Value).ToString("F2");
                    CustomerFavorioteSearchTypeBox.Text = row.Cells["Type"].Value.ToString();
                    CustomerFavorioteSearchConditionBox.Text = row.Cells["Condition"].Value.ToString();
                    CustomerFavorioteearchFuelTypeBox.Text = row.Cells["FuelType"].Value.ToString();
                    CustomerFavorioteSearchMileageBox.Text = row.Cells["Mileage"].Value.ToString();
                    CustomerFavorioteDescriptionBox.Text = row.Cells["Description"].Value.ToString();
                    CustomerFavorioteSearchModelYearBox.Text = row.Cells["ModelYear"].Value.ToString();
                    CustomerFavorioteSearchBrandBox.Text = row.Cells["Brand"].Value.ToString();
                    OrderID = row.Cells["OrderID"].Value.ToString();//getting  order id

                    if (row.Cells["ItemImage"].Value != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])row.Cells["ItemImage"].Value;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            CustomerFavorioteSearchPicBox.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        CustomerFavorioteSearchPicBox.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading item details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerFavorioteTrackOrdersBtn_Click(object sender, EventArgs e)
        {//rout track orders form favorite
            this.Close();
            CustomerTrackOrders customerTrackOrders = new CustomerTrackOrders();
            customerTrackOrders.Show();
        }

        private void CustomerFavorioteClearBtn_Click(object sender, EventArgs e)
        {
            CustomerFavorioteSearchItemCodeBox.Text = string.Empty;
            CustomerFavorioteNameBox.Text = string.Empty;
            CustomerFavorioteSearchVehiclePartBox.Text = string.Empty;
            CustomerFavorioteSearchBrandBox.Text = string.Empty;
            CustomerFavorioteSearchModelYearBox.Text = string.Empty;
            CustomerFavorioteearchFuelTypeBox.Text = string.Empty;
            CustomerFavorioteSearchConditionBox.Text = string.Empty;
            CustomerFavorioteSearchMileageBox.Text = string.Empty;
            CustomerFavorioteDescriptionBox.Text = string.Empty;
            CustomerFavorioteSearchPriceBox.Text = string.Empty;
            CustomerFavorioteSearchBox.Text = string.Empty;
            CustomerFavorioteSearchTypeBox.Text = string.Empty;
            CustomerFavorioteSearchPicBox.Image = Properties.Resources.image_placeholder;//default image
            OrderID = String.Empty;//clear the order id
            CustomerFavorioteCommentBox.Text = string.Empty;//comment box null
        }

        private void CustomerFavorioteRemoveFromFavoriteBtn_Click(object sender, EventArgs e)
        {
            // Check if the OrderID is valid
            if (string.IsNullOrEmpty(OrderID))
            {
                MessageBox.Show("Please select an item to remove from favorites.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to remove the item from favorites
                    string query = "DELETE FROM [order] WHERE OrderID = @OrderID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item removed from favorites.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear the OrderID
                            OrderID = string.Empty;

                            // Reload data to refresh the DataGridView
                            LoadData(); // Call LoadData to refresh the grid view
                        }
                        else
                        {
                            MessageBox.Show("No item found with the specified OrderID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
        private void CustomerFavorioteConfirmOrderBtn_Click(object sender, EventArgs e)
        {
            // Check if OrderID is set
            if (string.IsNullOrEmpty(OrderID))
            {
                MessageBox.Show("Please select an item to confirm the order.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Retrieve the customer comment and current date
            string customerComment = CustomerFavorioteCommentBox.Text;
            //string orderDate = DateTime.Now(); // Order placed date, no formact need now time is ok

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Update the OrderStatus to "Placed" and add the customer comment and order date
                    string updateOrderQuery = @"
                UPDATE [order]
                SET OrderStatus = 'Placed',
                    CustomerComment = @CustomerComment,
                    OrderDate = @OrderDate
                WHERE OrderID = @OrderID";

                    // Update the Item status to "Placed" and set the status change date
                    string updateItemQuery = @"
                UPDATE Item
                SET Status = 'Placed',
                    StatusChangeDate = @StatusChangeDate                
                WHERE ItemCode = (SELECT ItemCode FROM [order] WHERE OrderID = @OrderID)";

                    using (SqlCommand command = new SqlCommand(updateOrderQuery, connection))
                    {
                        // Add parameters for order update
                        command.Parameters.AddWithValue("@OrderID", OrderID);
                        command.Parameters.AddWithValue("@CustomerComment", string.IsNullOrEmpty(customerComment) ? (object)DBNull.Value : customerComment);
                        command.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                        int rowsAffectedOrder = command.ExecuteNonQuery();

                        if (rowsAffectedOrder > 0)
                        {
                            using (SqlCommand itemCommand = new SqlCommand(updateItemQuery, connection))
                            {
                                // Add parameters for item update
                                itemCommand.Parameters.AddWithValue("@OrderID", OrderID);
                                itemCommand.Parameters.AddWithValue("@StatusChangeDate", (DateTime.Now)); // Ensure the date parameter is added

                                int rowsAffectedItem = itemCommand.ExecuteNonQuery();

                                if (rowsAffectedItem > 0)
                                {
                                    // Order placed message
                                    MessageBox.Show("Order placed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData(); // Call LoadData to refresh the grid view
                                    CustomerFavorioteClearBtn_Click(sender, e); // Call clear button method
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update item status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No order found with the specified OrderID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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



    }
}

