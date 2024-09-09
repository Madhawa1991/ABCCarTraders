using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ABC_Car_Traders.LoginForm;

namespace ABC_Car_Traders
{
    public partial class CustomerTrackConfirmedItems : Form
    {
        private string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True";

        // Declare the totalPrice variable here to make it accessible in the constructor
        private decimal totalPrice = 0;

        public CustomerTrackConfirmedItems()
        {
            InitializeComponent();

            // Set the UserID from the session to the textbox
            CustomerCunfirmedOrderCustomerIdBox.Text = UserSession.UserID;

            CustomerCunfirmedOrderView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//select row in cel click

            // Load ordered items into the DataGridView
            LoadOrderedItems();

            // Set the total price text after loading the items
            CustomerCunfirmedOrderTotalPriceBox.Text = $"Total Price   Rs: {totalPrice}";// display total amount of the confiremd items
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
                            o.UserID = @UserID AND o.OrderStatus = 'Accepted'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the UserID parameter from this form
                        command.Parameters.AddWithValue("@UserID", CustomerCunfirmedOrderCustomerIdBox.Text);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Set the data source for the DataGridView
                            CustomerCunfirmedOrderView1.DataSource = dataTable;

                            // Reset total price before recalculating
                            totalPrice = 0;

                            // Calculate the total price
                            foreach (DataRow row in dataTable.Rows)
                            {
                                totalPrice += Convert.ToDecimal(row["ItemPrice"]);//calculate all items
                            }

                            // Update the total price textbox
                            CustomerCunfirmedOrderTotalPriceBox.Text = "{totalPrice:Rs}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading ordered items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerCunfirmedOrderView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Load to boxes Item code, name, Price
                {
                    DataGridViewRow row = CustomerCunfirmedOrderView1.Rows[e.RowIndex];

                    CustomerCunfirmedOrderItemsItemCodeBox.Text = row.Cells["OrderID"].Value.ToString();
                    CustomerCunfirmedOrdertemsItemNameBox.Text = row.Cells["ItemName"].Value.ToString();
                    CustomerCunfirmedOrderItemPriceBox.Text = Convert.ToDecimal(row.Cells["ItemPrice"].Value).ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading item details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
