using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePWexit_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void ChangePWButton_Click(object sender, EventArgs e)
        {
            // null values in username, telephone, NIC fields
            if (string.IsNullOrWhiteSpace(ChangePWNameBox.Text))
            {
                MessageBox.Show("Please enter your name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(ChangePWTeliphoneBox.Text))
            {
                MessageBox.Show("Please enter your Telephone.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(ChangePWNICBox.Text))
            {
                MessageBox.Show("Please enter your NIC.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(ChangePWpwBox.Text) || string.IsNullOrWhiteSpace(ChangePWrepwBox.Text))
            {
                MessageBox.Show("Please enter your Password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password minimum length 6
            if (ChangePWpwBox.Text.Length < 6)
            {
                MessageBox.Show("Password is too short. It must be at least 6 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password must contain uppercase, special character, and number
            if (!Regex.IsMatch(ChangePWpwBox.Text, @"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$"))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one number, and one special character.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ChangePWpwBox.Text != ChangePWrepwBox.Text)
            {
                MessageBox.Show("Passwords do not match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Connect to DB
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    // Check if the username, NIC, and telephone match
                    string query = "SELECT COUNT(*) FROM [customer] WHERE username=@username AND NIC=@NIC AND telephone=@telephone";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", ChangePWNameBox.Text);
                    cmd.Parameters.AddWithValue("@NIC", ChangePWNICBox.Text);
                    cmd.Parameters.AddWithValue("@telephone", ChangePWTeliphoneBox.Text);

                    int count = (int)cmd.ExecuteScalar(); // Count the matching records

                    if (count > 0)
                    {
                        // If match is found, update the password
                        string updateQuery = "UPDATE [customer] SET password=@password WHERE username=@username AND NIC=@NIC AND telephone=@telephone";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@username", ChangePWNameBox.Text);
                        updateCmd.Parameters.AddWithValue("@NIC", ChangePWNICBox.Text);
                        updateCmd.Parameters.AddWithValue("@telephone", ChangePWTeliphoneBox.Text);
                        updateCmd.Parameters.AddWithValue("@password", EncryptPassword(ChangePWrepwBox.Text)); // Use the hashed password

                        int rowsAffected = updateCmd.ExecuteNonQuery(); // Execute the update command

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No matching record found. Please check your username, NIC, and telephone.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void ChangePW_Load(object sender, EventArgs e)
        {

        }

        private void ChangePWShowPW_CheckedChanged(object sender, EventArgs e)
        {
            // password visibility 
            if (ChangePWShowPW.Checked)
            {
                ChangePWpwBox.PasswordChar = '\0';    
                ChangePWrepwBox.PasswordChar = '\0'; 
            }
            else
            {
                ChangePWpwBox.PasswordChar = '•';   
                ChangePWrepwBox.PasswordChar = '•';  
            }
        }
    }
}

