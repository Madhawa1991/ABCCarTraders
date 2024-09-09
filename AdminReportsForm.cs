using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static ABC_Car_Traders.LoginForm;

namespace ABC_Car_Traders
{
    public partial class AdminReportsForm : Form
    {
        public AdminReportsForm()
        {
            InitializeComponent();
            // Assign the user details to the text boxes when the form loads
            AdminReportsNameBox.Text = UserSession.UserName;
            AdminReportsUserIDBox.Text = UserSession.UserID;
            AdminReportsDateBox.Text = UserSession.LoginDate.ToString("MM/dd/yyyy");
        }

        private void AdminReportExitBtn_Click(object sender, EventArgs e)
        {
            //ROUT TO admin home
            this.Close();
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
        }

        private void AdminReportClearBtn_Click(object sender, EventArgs e)
        {
            //clear all the fields
            AdminReportEndDatePicker.Value = new DateTime(2024, 1, 1); //end date default today
            AdminReportStartDatePicker.Value = new DateTime(2024, 1, 1); //date default
            AdminReportEndDatePicker.Checked = true; //checkbox clicked
            AdminReportStartDatePicker.Checked = true; //checkbox clicked
            AdminReportsSelectReportComboBox.SelectedIndex = -1; //dropdown null
            AdminReportQuearyBox.Text = string.Empty;
            AdminReportDataGridView.DataSource = null;
            AdminReportDataGridView.Rows.Clear();
            AdminReportsCSVcheckBox.Checked = false; //nul check box
            AdminReportsPDFcheckBox.Checked = false;
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            // Check if a report type is selected
            if (AdminReportsSelectReportComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a report type from the dropdown menu.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if no selection is made
            }

            // Check if both date checkboxes status
            if (!AdminReportStartDatePicker.Checked || !AdminReportEndDatePicker.Checked)
            {
                MessageBox.Show("Please ensure both start and end dates are selected.", "Date Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if date conditions are not met
            }

            // Define the query string based on the selected report type
            string selectedReport = AdminReportsSelectReportComboBox.SelectedItem.ToString();
            string query = string.Empty;

            if (selectedReport == "order")
            {
                query = "SELECT [OrderID], [ItemCode]," +
                    " [UserID], [OrderStatus], [CustomerComment]," +
                    " [AdminComment], [OrderDate], [RejectDate], [SoldDate]," +
                    " [CancelDate], [RemoveDate], [AcceptedDate]" +
                    " FROM [ABC Car Traders].[dbo].[order]";
            }
            else if (selectedReport == "Item")
            {
                query = "SELECT [ItemCode], [Vehicle/Part], [ItemName], " +
                    "[ItemPrice], [Brand], [ModelYear], [Type], [Pricerange]," +
                    " [Condition], [FuelType], [Status], [Mileage], [Description], " +
                    "[AddDate], [EditDate], " +
                    "[StatusChangeDate] FROM [ABC Car Traders].[dbo].[Item]";//no image
            }
            else if (selectedReport == "customers")
            {
                query = "SELECT [username], [NIC]," +
                    " [address], [telephone], [email], " +
                    "[role], [Registor Date], [Update Date], " +
                    "[userID], [status] FROM [ABC Car Traders].[dbo].[customer]";//no PW
            }

            // Connection string to connect to the SQL Server database
            string connectionString = "Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            try
            {
                // Establishing the SQL connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL command to execute the query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Data adapter
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Data table to hold the query results
                    DataTable dataTable = new DataTable();

                    // Fill the data table with results from the database
                    adapter.Fill(dataTable);

                    // Set the data source of the DataGridView to the data table
                    AdminReportDataGridView.DataSource = dataTable;
                }

                // Show a message indicating the report was successfully generated
                MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("An error occurred while generating the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DownloadReportButton_Click(object sender, EventArgs e)
        {
            // Check if one and only one of the file format checkboxes is selected
            if (AdminReportsCSVcheckBox.Checked == AdminReportsPDFcheckBox.Checked) // Both are true or both are false
            {
                MessageBox.Show("Please select either CSV or PDF file format (not both) to generate the report.", "File Format Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if file format selection is invalid
            }

            // Retrieve the filtered data from DataGridView
            DataTable filteredDataTable = GetFilteredDataTable();

            // Generate and export the report based on the selected format
            if (AdminReportsCSVcheckBox.Checked)
            {
                ExportToCSV(filteredDataTable);
            }
            else if (AdminReportsPDFcheckBox.Checked)
            {
                ExportToPDF(filteredDataTable);
            }

            // Show a message indicating the report was successfully generated
            MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method to get the filtered data from the DataGridView
        private DataTable GetFilteredDataTable()
        {
            DataTable originalTable = (DataTable)AdminReportDataGridView.DataSource;
            DataTable filteredTable = originalTable.Clone(); // Clone to get the same structure

            foreach (DataGridViewRow row in AdminReportDataGridView.Rows)
            {
                if (row.Visible) // Check if the row is visible
                {
                    DataRow newRow = filteredTable.NewRow();
                    for (int i = 0; i < AdminReportDataGridView.Columns.Count; i++)
                    {
                        newRow[i] = row.Cells[i].Value;
                    }
                    filteredTable.Rows.Add(newRow);
                }
            }

            return filteredTable;
        }

        // Method to export DataTable to CSV
        private void ExportToCSV(DataTable dataTable)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Logic to export data to CSV
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Save as CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    // Write the column headers
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        writer.Write(dataTable.Columns[i]);
                        if (i < dataTable.Columns.Count - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    // Write the rows
                    foreach (DataRow row in dataTable.Rows)
                    {
                        for (int i = 0; i < dataTable.Columns.Count; i++)
                        {
                            writer.Write(row[i].ToString());
                            if (i < dataTable.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        // Method to export DataTable to PDF
        private void ExportToPDF(DataTable dataTable)
        {
            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Logic to export data to PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save as PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document document = new Document();
                    PdfWriter.GetInstance(document, stream);
                    document.Open();

                    PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
                    // Adding headers
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        pdfTable.AddCell(new Phrase(column.ColumnName));
                    }
                    // Adding data rows
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var cell in row.ItemArray)
                        {
                            pdfTable.AddCell(new Phrase(cell.ToString()));
                        }
                    }

                    document.Add(pdfTable);
                    document.Close();
                    stream.Close();
                }
            }
        }

        private void AdminReportGenerateReportQuearyButton_Click(object sender, EventArgs e)
        {// Check if a query is provided
            string query = AdminReportQuearyBox.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Please enter a valid SQL query in the query box.", "Query Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if no query is provided
            }

           

            // Connection string to connect to the SQL Server database
            string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            try
            {
                // Establishing the SQL connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the connection
                    connection.Open();

                    // SQL command to execute the query
                    SqlCommand command = new SqlCommand(query, connection);

                    // Data adapter to fetch data from the database
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Data table to hold the query results
                    DataTable dataTable = new DataTable();

                    // Fill the data table with results from the database
                    adapter.Fill(dataTable);

                    // Set the data source of the DataGridView to the data table
                    AdminReportDataGridView.DataSource = dataTable;

                    // Show a message indicating the report was successfully generated
                    MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show("An error occurred while generating the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

