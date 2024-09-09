using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Registor : Form
    {
        public Registor()
        {
            InitializeComponent();
        }



        private void LoginInfoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();//route to about us page
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }

        private void LoginRegistorButton_Click(object sender, EventArgs e)
        {
            // Name Min length 4, only English characters
            if (string.IsNullOrWhiteSpace(RegistorNameTex.Text) || RegistorNameTex.Text.Length < 4 || !Regex.IsMatch(RegistorNameTex.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Please enter a valid name (English characters only).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // NIC min 10, Max 12
            if (string.IsNullOrWhiteSpace(RegistorNICTex.Text) || RegistorNICTex.Text.Length < 10 || RegistorNICTex.Text.Length > 12)
            {
                MessageBox.Show("Please enter a valid NIC (length between 10 and 12 characters).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //min lenght 10
            if (string.IsNullOrWhiteSpace(RegistorAddressTex.Text) || RegistorAddressTex.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid address (minimum length of 10 characters).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  10 digits
            if (string.IsNullOrWhiteSpace(RegistorTelephoneTex.Text) || RegistorTelephoneTex.Text.Length != 10 || !Regex.IsMatch(RegistorTelephoneTex.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter a valid telephone number (Ex: 0711234567).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Minimum length 10
            if (string.IsNullOrWhiteSpace(LoginEmailText.Text) || LoginEmailText.Text.Length < 10)
            {
                MessageBox.Show("Please enter a valid email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password validation
            if (string.IsNullOrWhiteSpace(RegistorPasswordTex.Text) || string.IsNullOrWhiteSpace(RegistorRePasswordTex.Text))
            {
                MessageBox.Show("Please enter and confirm your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password minimum length 6
            if (RegistorPasswordTex.Text.Length < 6)
            {
                MessageBox.Show("Password is too short. It must be at least 6 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password must contain uppercase, special character, and number
            if (!Regex.IsMatch(RegistorPasswordTex.Text, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$"))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one number, and one special character.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm Password Match
            if (RegistorPasswordTex.Text != RegistorRePasswordTex.Text)
            {
                MessageBox.Show("Passwords do not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    // Step 1: Get the last userID
                    string getLastUserIDQuery = "SELECT TOP 1 userID FROM [customer] ORDER BY userID DESC";
                    SqlCommand getLastUserIDCmd = new SqlCommand(getLastUserIDQuery, con);
                    string lastUserID = (string)getLastUserIDCmd.ExecuteScalar();

                    // Step 2: Increment the userID
                    string newUserID = "User1"; // Default if no users exist

                    if (!string.IsNullOrEmpty(lastUserID))
                    {
                        int lastNumber = int.Parse(Regex.Match(lastUserID, @"\d+").Value); // Extract the numeric part
                        newUserID = "User" + (lastNumber + 1).ToString();
                    }

                    // Step 3: Insert user data into the database with the new userID
                    string query = "INSERT INTO [customer] (userID, username, password, NIC, address, telephone, email, Role, [Registor Date], status) " +
                                   "VALUES (@userID, @username, @password, @NIC, @address, @telephone, @email, @Role, @RegistorDate, @status)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userID", newUserID);
                    cmd.Parameters.AddWithValue("@username", RegistorNameTex.Text);
                    cmd.Parameters.AddWithValue("@password", EncryptPassword(RegistorPasswordTex.Text)); // Encrypt the password
                    cmd.Parameters.AddWithValue("@NIC", RegistorNICTex.Text);
                    cmd.Parameters.AddWithValue("@address", RegistorAddressTex.Text);
                    cmd.Parameters.AddWithValue("@telephone", RegistorTelephoneTex.Text);
                    cmd.Parameters.AddWithValue("@email", LoginEmailText.Text);
                    cmd.Parameters.AddWithValue("@Role", "Customer"); // Default role is Customer
                    cmd.Parameters.AddWithValue("@RegistorDate", DateTime.Now); // Current date and time
                    cmd.Parameters.AddWithValue("@status", "Active");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistorShowPW_CheckedChanged(object sender, EventArgs e)
        {
            // visibility PW
            bool showPassword = RegistorShowPW.Checked;

            RegistorPasswordTex.PasswordChar = showPassword ? '\0' : '*';
            RegistorRePasswordTex.PasswordChar = showPassword ? '\0' : '*';
        }

        private string EncryptPassword(string password)
        {
            //  encryption to MD5

            byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] hash = md5.ComputeHash(data);
                return Convert.ToBase64String(hash);
            }
        }

        private void LoginExitButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {

        }

 
    }
}
