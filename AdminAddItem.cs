using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class AdminAddItem : Form
    {
        public AdminAddItem()
        {
            InitializeComponent();
        }

        private void AddItemSaveButton_Click(object sender, EventArgs e)
        {
            // Check if a radio button is selected or not
            if (!AddItemVehicleradioButton.Checked && !AddItemPartRadioButton.Checked)
            {
                MessageBox.Show("Please select either 'Vehicle' or 'Part'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate fields based on the selected radio button
            if (AddItemVehicleradioButton.Checked)
            {
                if (string.IsNullOrEmpty(AddItemNameBox.Text) || string.IsNullOrEmpty(AddItemPriceBox.Text) ||
                    string.IsNullOrEmpty(AddItemModelYearBox.Text) || AddItemBrandNamecmb.SelectedIndex == -1 ||
                    AddItemTypecmb.SelectedIndex == -1 || AddItemPriceRangecmb.SelectedIndex == -1 ||
                    AddItemConditioncmb.SelectedIndex == -1 || AddItemFuelTypecmb.SelectedIndex == -1 ||
                    AddItemStatuscmb.SelectedIndex == -1 || string.IsNullOrEmpty(AddItemMileageBoxcmb.Text) ||
                    string.IsNullOrEmpty(AddItemDescriptionBox.Text))
                {
                    MessageBox.Show("All fields are mandatory for a Vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (AddItemPartRadioButton.Checked)
            {
                if (string.IsNullOrEmpty(AddItemNameBox.Text) || string.IsNullOrEmpty(AddItemPriceBox.Text) 
                   // || string.IsNullOrEmpty(AddItemModelYearBox.Text)//model year can be null for part
                    || AddItemBrandNamecmb.SelectedIndex == -1 ||
                    AddItemTypecmb.SelectedIndex == -1 || AddItemPriceRangecmb.SelectedIndex == -1 ||
                    AddItemConditioncmb.SelectedIndex == -1 || AddItemStatuscmb.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(AddItemDescriptionBox.Text))
                {
                    MessageBox.Show("All fields except 'Model Year','Fuel Type' and 'Mileage' are mandatory for a Part.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Generate the new Item Code based on the selected radio button
            string newItemCode = GenerateNewItemCode(AddItemVehicleradioButton.Checked);

            // Proceed with saving the data
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();
                    string query = @"INSERT INTO Item ([Itemcode], [Vehicle/Part], [ItemName], [ItemPrice], [Brand], [ModelYear], [Type], [PriceRange], [Condition], [FuelType], [Status], [Mileage], [Description], [ItemImage], [AddDate])
                         VALUES (@Itemcode, @VehiclePart, @ItemName, @ItemPrice, @Brand, @ModelYear, @Type, @PriceRange, @Condition, @FuelType, @Status, @Mileage, @Description, @ItemImage, @AddDate)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {//assign db values to boxes
                        cmd.Parameters.AddWithValue("@Itemcode", newItemCode);
                        cmd.Parameters.AddWithValue("@VehiclePart", AddItemVehicleradioButton.Checked ? "Vehicle" : "Part");
                        cmd.Parameters.AddWithValue("@ItemName", AddItemNameBox.Text);
                        cmd.Parameters.AddWithValue("@ItemPrice", Convert.ToDecimal(AddItemPriceBox.Text));
                        cmd.Parameters.AddWithValue("@Brand", AddItemBrandNamecmb.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@ModelYear", AddItemModelYearBox.Text);
                        cmd.Parameters.AddWithValue("@Type", AddItemTypecmb.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@PriceRange", AddItemPriceRangecmb.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@Condition", AddItemConditioncmb.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@FuelType", AddItemVehicleradioButton.Checked ? AddItemFuelTypecmb.SelectedItem?.ToString() : (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Status", AddItemStatuscmb.SelectedItem?.ToString());
                        cmd.Parameters.AddWithValue("@Mileage", AddItemVehicleradioButton.Checked ? (object)Convert.ToInt32(AddItemMileageBoxcmb.Text) : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Description", AddItemDescriptionBox.Text);
                        

                        // Image handling
                        if (AddItempicture.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                AddItempicture.Image.Save(ms, AddItempicture.Image.RawFormat);
                                byte[] imageBytes = ms.ToArray();
                                cmd.Parameters.AddWithValue("@ItemImage", imageBytes);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ItemImage", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@AddDate", DateTime.Now);

                        cmd.ExecuteNonQuery();

                        // Show success message with the new Item Code
                        MessageBox.Show($"Item added successfully! The Item Code is: {newItemCode}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();//close the db connection
                }
            }
            catch (SqlException ex)
            {
                // Additional error handling to show specific issues
                MessageBox.Show("An error occurred while saving the item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateNewItemCode(bool isVehicle)
        {
            string itemType = isVehicle ? "Vehicle" : "Part"; // Determine item type
            int newCodeNumber = 1; // Initialize code number

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                {
                    con.Open();//open swl connection
                    string query = @"SELECT TOP 1 ItemCode FROM Item WHERE ItemCode LIKE @ItemCodePrefix ORDER BY ItemCode DESC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ItemCodePrefix", itemType + "%");
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string lastItemCode = result.ToString();

                            // Find the numeric part of the code
                            string numericPart = new string(lastItemCode.Skip(itemType.Length).TakeWhile(char.IsDigit).ToArray());

                            // Parse the numeric part
                            if (int.TryParse(numericPart, out int lastNumber))
                            {
                                newCodeNumber = lastNumber + 1; // Increment the last number by 1
                            }
                        }
                    }
                    con.Close();//close swl connection
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the Item Code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Format the new code with leading zeros for consistency
            return $"{itemType}{newCodeNumber:D3}"; // D3 ensures three digits, e.g., Vehicle001
        }


        private void AddItemClearBtn_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            AddItemNameBox.Text = string.Empty;
            AddItemPriceBox.Text = string.Empty;
            AddItemDescriptionBox.Text = string.Empty;
            AddItemMileageBoxcmb.Text = string.Empty;
            AddItemModelYearBox.Text = string.Empty;

            // Reset dropdowns to default value
            AddItemBrandNamecmb.SelectedIndex = -1;
            AddItemTypecmb.SelectedIndex = -1;
            AddItemPriceRangecmb.SelectedIndex = -1;
            AddItemConditioncmb.SelectedIndex = -1;
            AddItemStatuscmb.SelectedIndex = -1;

            // Clear radio buttons and set to default state
            AddItemVehicleradioButton.Checked = false;
            AddItemPartRadioButton.Checked = false;

            // Clear fuel type 
            AddItemFuelTypecmb.SelectedIndex = -1;

            // Set default image
            AddItempicture.Image = Properties.Resources.ImageCar; // Replace 'ImageCar' with your actual default image
        }

        public void AddItemPicUploadbtn_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {//only JPG,png files allowed to upload as image
                        openFileDialog.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Set the selected image to the PictureBox
                            AddItempicture.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error uploading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void AddItemCanselBtn_Click_1(object sender, EventArgs e)
        {//go back to admin home
            this.Close();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }
    }
}
