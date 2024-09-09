using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using static ABC_Car_Traders.LoginForm;

namespace ABC_Car_Traders
{
    public partial class CustomerItemSearch : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";

        public CustomerItemSearch()
        {
            InitializeComponent();
            CustomerItemSearchCustomerNameBox.Text = UserSession.UserName; // login name
            CustomerItemSearchIDBox.Text = UserSession.UserID; // login ID
            CustomerItemSearchDateBox.Text = DateTime.Now.ToString("yyyy-MM-dd");

            LoadData();
            CustomerItemSearchBox.TextChanged += CustomerItemSearchTextBox_TextChanged;
            this.Load += CustomerSearchItemBox_Load;

        }

        private void CustomerItemSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            try//searching coloums in the item table
            {
                string searchQuery = @"
                    SELECT ItemCode, [Vehicle/Part], ItemName, ItemPrice, Brand, ModelYear, Type, Pricerange, Condition, FuelType, Status, Mileage, Description, [ItemImage] 
                    FROM item 
                    WHERE ([Vehicle/Part] LIKE @Search 
                    OR ItemName LIKE @Search 
                    OR ItemPrice LIKE @Search 
                    OR Brand LIKE @Search 
                    OR Type LIKE @Search 
                    OR Pricerange LIKE @Search 
                    OR Condition LIKE @Search 
                    OR FuelType LIKE @Search 
                    OR Description LIKE @Search 
                    OR Status LIKE @Search) 
                    AND Status = 'Available'";//satus available item only can search

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(searchQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Search", $"%{CustomerItemSearchBox.Text}%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        bindingSource.DataSource = dt;
                        CustomerItemSearchGridView.DataSource = bindingSource;
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

        private void LoadData()
        {//load data in tot he grid view
            try
            {//SWL query
                string query = @"
                    SELECT ItemCode, [Vehicle/Part], ItemName, ItemPrice, Brand, ModelYear, Type, Pricerange, Condition, FuelType, Mileage, Description, ItemImage 
                    FROM item 
                    WHERE Status = 'Available'";

                using (SqlConnection con = new SqlConnection(connectionString))
                {//calling the connection string and geta data in to Data table
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //boinding data to the grid view
                    bindingSource.DataSource = dt;
                    CustomerItemSearchGridView.DataSource = bindingSource;
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

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = CustomerItemSearchGridView.Rows[e.RowIndex];

                    CustomerItemSearchItemCodeBox.Text = row.Cells["ItemCode"].Value.ToString();
                    CustomerItemSearchVehiclePartBox.Text = row.Cells["Vehicle/Part"].Value.ToString();
                    CustomerItemSearchItemNameBox.Text = row.Cells["ItemName"].Value.ToString();
                    CustomerItemSearchPriceBox.Text = Convert.ToDecimal(row.Cells["ItemPrice"].Value).ToString("F2");
                    CustomerItemSearchTypeBox.Text = row.Cells["Type"].Value.ToString();
                    CustomerItemSearchConditionBox.Text = row.Cells["Condition"].Value.ToString();
                    CustomerItemSearchFuelTypeBox.Text = row.Cells["FuelType"].Value.ToString();
                    CustomerItemSearchMileageBox.Text = row.Cells["Mileage"].Value.ToString();
                    CustomerItemSearchDescriptionBox.Text = row.Cells["Description"].Value.ToString();
                    CustomerItemSearchModelYearBox.Text = row.Cells["ModelYear"].Value.ToString();
                    CustomerItemSearchBrandBox.Text = row.Cells["Brand"].Value.ToString();

                    if (row.Cells["ItemImage"].Value != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])row.Cells["ItemImage"].Value;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            CustomerItemSearchPicBox.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        CustomerItemSearchPicBox.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading item details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerSearchItemBox_Load(object sender, EventArgs e)
        {
            CustomerItemSearchDateBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void CustomerSearchItemExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerDashBoard customerDashBoard = new CustomerDashBoard();
            customerDashBoard.Show();
        }

        private void CustomerSearchItemClearBtn_Click(object sender, EventArgs e)
        {
            CustomerItemSearchItemCodeBox.Text = string.Empty;
            CustomerItemSearchItemNameBox.Text = string.Empty;
            CustomerItemSearchVehiclePartBox.Text = string.Empty;
            CustomerItemSearchBrandBox.Text = string.Empty;
            CustomerItemSearchModelYearBox.Text = string.Empty;
            CustomerItemSearchFuelTypeBox.Text = string.Empty;
            CustomerItemSearchConditionBox.Text = string.Empty;
            CustomerItemSearchMileageBox.Text = string.Empty;
            CustomerItemSearchDescriptionBox.Text = string.Empty;
            CustomerItemSearchPriceBox.Text = string.Empty;
            CustomerItemSearchTypeBox.Text = string.Empty;
            CustomerItemSearchBox.Text = string.Empty;
            CustomerItemSearchPicBox.Image = Properties.Resources.image_placeholder; // Replace with your actual default image
        }

        private void CustomerSearchItemFavoriotBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerItemSearchIDBox.Text))
            {
                MessageBox.Show("Please enter a User ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(CustomerItemSearchItemCodeBox.Text))
            {
                MessageBox.Show("Please select a Vehicle/Item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userID = CustomerItemSearchIDBox.Text; // UserID
            string itemCode = CustomerItemSearchItemCodeBox.Text; // ItemCode

            // Check if the item is already added to favorites
            if (IsItemAlreadyFavorited(userID, itemCode))
            {
                MessageBox.Show("This item is already added to favorites.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Warning message for already added to favorites
            }

            // Generate a new order ID and insert the order if it's not already favorited
            string orderID = GenerateOrderNumber();
            string orderStatus = "Favorite"; // Only favorited items

            InsertOrderIntoDatabase(orderID, itemCode, userID, orderStatus);

            MessageBox.Show("Item added to favorites.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method to check if an item is already added to favorites
        private bool IsItemAlreadyFavorited(string userID, string itemCode)
        {// I. connection to the database using the connection string, with two Permeates  
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();// II. Open the connection to the database

                // III. Query to check if a favorite entry already exists for the given userID and itemCode
                string query = "SELECT COUNT(*) FROM [order] WHERE UserID = @userID AND ItemCode = @itemCode AND OrderStatus = 'Favorite'";
                // IV. Create a command 
                using (SqlCommand command = new SqlCommand(query, connection))
                {// V. passing parameater values to DB
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@itemCode", itemCode);

                    // VI. Execute the query and get the result
                    int count = (int)command.ExecuteScalar();

                    // VII. If count is greater than 0, it means the item is already favorited
                    return count > 0;
                }
                connection.Close();// VIII.close the SQL connection
            }
        }

        // Method to generate a new favorite order number
        private string GenerateOrderNumber()
        {
            string orderNumberPrefix = "OID"; // Static prefix for all order numbers
            string orderNumber;
            int newCodeNumber = 1; // Default starting number if no existing records are found

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Query to get the highest order number starting with "OID" from the "order" table
                string query = "SELECT MAX(OrderID) FROM [order] WHERE OrderID LIKE @prefix";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@prefix", orderNumberPrefix + "%");

                    // Get the current maximum order number
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        string currentOrderNumber = result.ToString();

                        // Extract the numeric part of the order number
                        string numericPart = currentOrderNumber.Substring(3);

                        // Increment the numeric part to generate a new order number
                        if (int.TryParse(numericPart, out newCodeNumber))
                        {
                            newCodeNumber++;
                        }
                    }
                }
            }

            // Format the new order number as "OID" + a 12-digit number (with leading zeros if necessary)
            orderNumber = orderNumberPrefix + newCodeNumber.ToString("D12");
            return orderNumber;
        }

        // Method to insert a new order into the database
        private void InsertOrderIntoDatabase(string orderID, string itemCode, string userID, string orderStatus)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Insert the new order into the "order" table
                string insertQuery = "INSERT INTO [order] (OrderID, ItemCode, UserID, OrderStatus) VALUES (@OrderID, @ItemCode, @UserID, @OrderStatus)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", orderID);
                    command.Parameters.AddWithValue("@ItemCode", itemCode);
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@OrderStatus", orderStatus);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void CustomerSearchItemtrackOrderBtn_Click_1(object sender, EventArgs e)
        {//gp to track page
            this.Close();
            CustomerTrackOrders customerTrackOrders = new CustomerTrackOrders();
            customerTrackOrders.Show();

        }

        private void CustomerSearchItemViewFavariotBtn_Click(object sender, EventArgs e)
        {// go to favorite page
            this.Close();
            CustomerFavarioutItems customerFavarioutItems = new CustomerFavarioutItems();
            customerFavarioutItems.Show();
        }
    }
}
