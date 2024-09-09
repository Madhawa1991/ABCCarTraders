using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static class UserSession
        {
            // Static properties to store user information to access in any calss
            public static string UserName { get; set; }//login name
            public static string UserID { get; set; }//login User ID
            public static DateTime LoginDate { get; set; }//loged date now(linked to last login date)
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //---no need
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle label click event if needed
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Check for null values in username and password fields
            if (string.IsNullOrWhiteSpace(LoginNameBox.Text))
            {
                MessageBox.Show("Please enter your username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(LoginPasswordBox.Text))
            {
                MessageBox.Show("Please enter your password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hash the entered password
            string hashedPassword = HashPassword(LoginPasswordBox.Text);

            // Connect to the database
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-M9JEPR6\\VS_SERVER;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;TrustServerCertificate=True"))
                {
                    con.Open();

                    // Query to fetch role and userID based on username and password
                    string query = "SELECT [role], UserID FROM [customer] WHERE status=@status AND username=@username AND password=@password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@status", "Active"); // only active customers can login
                    cmd.Parameters.AddWithValue("@username", LoginNameBox.Text); // check username
                    cmd.Parameters.AddWithValue("@password", hashedPassword); // Use the hashed password

                    // Execute the query and get the role and userID
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["role"].ToString();
                        string userID = reader["UserID"].ToString();

                        // Set the session variables
                        UserSession.UserName = LoginNameBox.Text;
                        UserSession.UserID = userID;
                        UserSession.LoginDate = DateTime.Now;

                        // Display message based on role
                        if (role == "Customer")
                        {
                            this.Hide();//hide until exit form user dash board
                            MessageBox.Show("Welcome, Customer!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);//welcome message
                            CustomerDashBoard customerDashBoard = new CustomerDashBoard();
                            customerDashBoard.ShowDialog();
                        }
                        else if (role == "Admin")
                        {
                            this.Hide();//hide until exit form admin dash board
                            MessageBox.Show("Welcome, Admin!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);//welcome message
                            AdminHome adminForm = new AdminHome();
                            adminForm.ShowDialog();
                        }
                        else
                        {
                            this.Hide();//if not user or admin, this for other user , now we dont have aditional feature 
                            MessageBox.Show("Welcome, User!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Login failed message
                        MessageBox.Show("Login unsuccessful. Please check your username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();//close DB good pratcise
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

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            LoginPasswordBox.PasswordChar = ShowPasswordCheckBox.Checked ? '\0' : '*';
        }

    

        private void RegisterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Open the registration form
            Registor registerForm = new Registor();
            registerForm.ShowDialog();

            // Show the login form again after registration form is closed
            this.Show();
        }

        private void LoginChangePWLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           this.Hide();
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();

        }


        private string HashPassword(string password)
        {
            byte[] data = Encoding.UTF8.GetBytes(password);
            using (var md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(data);
                return Convert.ToBase64String(hash);
            }
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            // Closes the entire application
            Application.Exit();
        }


        private void TemporyPagetestButon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminReportsForm adminAddItem = new AdminReportsForm();
            adminAddItem.Show();
        }
    }
}
