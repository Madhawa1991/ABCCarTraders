using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static ABC_Car_Traders.LoginForm;

namespace ABC_Car_Traders
{
    public partial class AdminManageItems : Form
    {

        private bool isDataChanged = false; // Flag to track if data has changed

        public AdminManageItems()
        {
            InitializeComponent();
            // Assign the user details to the text boxes when the form loads
            AdminDashboardNameBox.Text = UserSession.UserName;
            AdminDashboarduserIdBox.Text = UserSession.UserID;
            AdminDashboardDateBox.Text = UserSession.LoginDate.ToString("MM/dd/yyyy");
            LoadData();

            AdminManageItemGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Select row in cell click

            AdminManageItemGridView.CellClick += AdminManageItemGridView_CellClick;


            // change events for text boxes and combo boxes
            ManageItemItemNameBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemItemPriceBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemVehiclePartBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemItemTypeBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemPriceRangeBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemConditionBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemFuelTypeBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemStatusBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemMileageBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemDescriptionBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemModelYearBox.TextChanged += (s, e) => isDataChanged = true;
            ManageItemBrandBox.TextChanged += (s, e) => isDataChanged = true;


            // Search box event
            AdminItemSearchBox.TextChanged += AdminItemSearchBox_TextChanged; // Event handler for search
        }
        private void AdminItemSearchBox_TextChanged(object sender, EventArgs e)
            {
                LoadData(AdminItemSearchBox.Text); // Pass the search text to the LoadData method
            }


        private void LoadData(string searchTerm = "") // Load all items or search results into the DataGridView
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";
                string query = @"SELECT ItemCode, [Vehicle/Part], ItemName, ItemPrice, Brand, ModelYear, Type, PriceRange, Condition, FuelType, Status, Mileage, Description, [ItemImage] 
                         FROM Item 
                         WHERE Status != 'Deleted'";//no deleted items loding

                // If searchTerm is provided, modify the query to use the LIKE function
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += @" AND ([Vehicle/Part] LIKE @SearchTerm
                        OR ItemName LIKE @SearchTerm
                        OR ItemPrice LIKE @SearchTerm
                        OR Brand LIKE @SearchTerm
                        OR Type LIKE @SearchTerm
                        OR PriceRange LIKE @SearchTerm
                        OR Condition LIKE @SearchTerm
                        OR FuelType LIKE @SearchTerm
                        OR Description LIKE @SearchTerm
                        OR Status LIKE @SearchTerm)";
                }
                //connectiong string calling
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%"); // Add wildcard for LIKE search
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        AdminManageItemGridView.DataSource = dt;//data to grid
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


        private void AdminManageItemGridView_CellClick(object sender, DataGridViewCellEventArgs e) // Load selected row data into the form fields
        {
            try
            {
                if (e.RowIndex >= 0) // Ensure the row index is valid
                {
                    DataGridViewRow row = AdminManageItemGridView.Rows[e.RowIndex]; // Use the correct grid name

                    // Load the data from the selected row into the text boxes
                    ManageItemItemCodeBox.Text = row.Cells["ItemCode"].Value?.ToString() ?? string.Empty; // Handle null values
                    ManageItemVehiclePartBox.Text = row.Cells["Vehicle/Part"].Value?.ToString() ?? string.Empty;
                    ManageItemItemNameBox.Text = row.Cells["ItemName"].Value?.ToString() ?? string.Empty;
                    ManageItemItemPriceBox.Text = Convert.ToDecimal(row.Cells["ItemPrice"].Value ?? 0).ToString("F2"); // Convert to decimal and two decimal places
                    ManageItemItemTypeBox.Text = row.Cells["Type"].Value?.ToString() ?? string.Empty;
                    ManageItemPriceRangeBox.Text = row.Cells["PriceRange"].Value?.ToString() ?? string.Empty;
                    ManageItemConditionBox.Text = row.Cells["Condition"].Value?.ToString() ?? string.Empty;
                    ManageItemFuelTypeBox.Text = row.Cells["FuelType"].Value?.ToString() ?? string.Empty;
                    ManageItemStatusBox.Text = row.Cells["Status"].Value?.ToString() ?? string.Empty;
                    ManageItemMileageBox.Text = row.Cells["Mileage"].Value?.ToString() ?? string.Empty;
                    ManageItemDescriptionBox.Text = row.Cells["Description"].Value?.ToString() ?? string.Empty;
                    ManageItemModelYearBox.Text = row.Cells["ModelYear"].Value?.ToString() ?? string.Empty;
                    ManageItemBrandBox.Text = row.Cells["Brand"].Value?.ToString() ?? string.Empty;

                    // Load the image into the PictureBox
                    if (row.Cells["ItemImage"].Value != DBNull.Value) // Check if there is an image
                    {
                        byte[] imageBytes = (byte[])row.Cells["ItemImage"].Value;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            ManageItemPictureBox.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        ManageItemPictureBox.Image = Properties.Resources.ImageCar; // Set to default image if no image is found
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or display an error message
                MessageBox.Show($"An error occurred while loading item details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageItemEditButon_Click(object sender, EventArgs e) // Update the selected item in the database
        {
            if (!isDataChanged)
            {
                MessageBox.Show("No changes detected.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Item SET ItemName = @ItemName, ItemPrice = @ItemPrice, Type = @Type, PriceRange = @PriceRange, Condition = @Condition, FuelType = @FuelType, Status = @Status, Mileage = @Mileage, Description = @Description, ModelYear = @ModelYear, Brand = @Brand, ItemImage = @ItemImage WHERE ItemCode = @ItemCode";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {//assigning to boxes TO DB
                        cmd.Parameters.AddWithValue("@ItemCode", ManageItemItemCodeBox.Text);
                        cmd.Parameters.AddWithValue("@ItemName", ManageItemItemNameBox.Text);
                        cmd.Parameters.AddWithValue("@ItemPrice", ManageItemItemPriceBox.Text);
                        cmd.Parameters.AddWithValue("@Type", ManageItemItemTypeBox.Text);
                        cmd.Parameters.AddWithValue("@PriceRange", ManageItemPriceRangeBox.Text);
                        cmd.Parameters.AddWithValue("@Condition", ManageItemConditionBox.Text);
                        cmd.Parameters.AddWithValue("@FuelType", ManageItemFuelTypeBox.Text);
                        cmd.Parameters.AddWithValue("@Status", ManageItemStatusBox.Text);
                        cmd.Parameters.AddWithValue("@Mileage", ManageItemMileageBox.Text);
                        cmd.Parameters.AddWithValue("@Description", ManageItemDescriptionBox.Text);
                        cmd.Parameters.AddWithValue("@ModelYear", ManageItemModelYearBox.Text);
                        cmd.Parameters.AddWithValue("@Brand", ManageItemBrandBox.Text);

                        // Save the image
                        if (ManageItemPictureBox.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                ManageItemPictureBox.Image.Save(ms, ManageItemPictureBox.Image.RawFormat);
                                byte[] imageBytes = ms.ToArray();
                                cmd.Parameters.AddWithValue("@ItemImage", imageBytes);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ItemImage", DBNull.Value);
                        }

                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); // Reload the DataGridView to reflect the changes
                        isDataChanged = false;//flag reset
                        con.Open();//once done close the connection
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

            isDataChanged = false; // Reset the flag after saving
        }

        private void AdminManageItemChangePicButon_Click_1(object sender, EventArgs e) // Change the image in the PictureBox
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Set the selected image to the PictureBox
                        ManageItemPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                        isDataChanged = true; // Flag that the image has been changed
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error uploading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageItemDeleteBtn_Click(object sender, EventArgs e) // Change status to "Deleted" and update the status change date
        {
            try
            {
                if (string.IsNullOrEmpty(ManageItemItemCodeBox.Text))
                {
                    MessageBox.Show("Please select an item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;//when no item has been selected error message
                }

                var result = MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)//confirmming message
                {
                    string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {//status changoing to Delete, not toatally removed from DB
                        string query = "UPDATE Item SET Status = @Status, StatusChangeDate = @StatusChangeDate WHERE ItemCode = @ItemCode";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@ItemCode", ManageItemItemCodeBox.Text);
                            cmd.Parameters.AddWithValue("@Status", "Deleted");
                            cmd.Parameters.AddWithValue("@StatusChangeDate", DateTime.Now); // Set the current date and time

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();//onece execute query close the opend connection
                        }
                    }
                    MessageBox.Show("Item marked as 'Deleted' successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Reload the DataGridView 
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

        private void AdminManageItemClearBtn_Click(object sender, EventArgs e) // Clear all input fields and reset the image
        {
            ManageItemItemCodeBox.Clear();//tex boxes clear
            ManageItemItemNameBox.Clear();
            ManageItemItemPriceBox.Text = string.Empty;
            ManageItemVehiclePartBox.SelectedIndex = -1;//combo boxes
            ManageItemItemTypeBox.SelectedIndex = -1;
            ManageItemPriceRangeBox.SelectedIndex = -1;
            ManageItemConditionBox.SelectedIndex = -1;
            ManageItemFuelTypeBox.SelectedIndex = -1;
            ManageItemStatusBox.SelectedIndex = -1;
            ManageItemMileageBox.Clear();
            ManageItemDescriptionBox.Clear();
            ManageItemModelYearBox.Text = string.Empty;
            ManageItemBrandBox.SelectedIndex = -1;
            AdminItemSearchBox.Clear();
            ManageItemPictureBox.Image = Properties.Resources.ImageCar;//defailt imeage

            isDataChanged = false; // Reset the flag after clearing
        }

        private void AdminManageItemExitBtn_Click(object sender, EventArgs e)
        {//rout to home
            this.Close();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }
    }
}
