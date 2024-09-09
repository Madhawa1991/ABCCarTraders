using System;
using System.Windows.Forms;
using static ABC_Car_Traders.LoginForm;

namespace ABC_Car_Traders
{
    public partial class CustomerDashBoard : Form
    {
        public CustomerDashBoard()
        {
            InitializeComponent();
        }

        private void CustomerDashBoard_Load(object sender, EventArgs e)
        {
            // Assign the user details to the text boxes when the form load
            CustomerDashBoardUsernameBox.Text = UserSession.UserName;
            CustomerDashBoardUserIDBox.Text = UserSession.UserID;
            CustomerDashBoardDateBox.Text = UserSession.LoginDate.ToString("MM/dd/yyyy");
        }

        private void CustomerDashboardLogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Are You sure want to Logout!", "Info");//confirm logout
            LoginForm logonForm = new LoginForm();
            logonForm.Show();//when exit from login form, direct to login page
        }

        private void itemSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerItemSearch customerItemSearch = new CustomerItemSearch();
            customerItemSearch.Show();
        }

        private void addToFavoritesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerFavarioutItems customerFavarioutItems = new CustomerFavarioutItems();
            customerFavarioutItems.Show();

        }

        private void viewOrderStatusButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerTrackOrders customerTrackOrders = new CustomerTrackOrders();
            customerTrackOrders.Show();
        }
    }
}
