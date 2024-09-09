using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ABC_Car_Traders.LoginForm;

namespace ABC_Car_Traders
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
            // Assign the user details to the text boxes when the form loads
            AdminDashboardNameBox.Text = UserSession.UserName;
            AdminDashboarduserIdBox.Text = UserSession.UserID;
            AdminDashboardDateBox.Text = UserSession.LoginDate.ToString("MM/dd/yyyy");
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void AdminHomeAddItemsBtn_Click(object sender, EventArgs e)
        {//AdminManageItems home close and open Add items
            this.Close();
            AdminAddItem adminAddItem = new AdminAddItem();
            adminAddItem.Show();
        }

        private void AdminDashboardEditItemBtn_Click(object sender, EventArgs e)
        {//close Admin dashboard and open manage item
            this.Close();
            AdminManageItems adminManageItems = new AdminManageItems();
            adminManageItems.Show();
        }

        private void AdminDashboardManageUserBtn_Click(object sender, EventArgs e)
        {//admin home close and open manage customers
            this.Close();
            AdminManageCustomers adminManageCustomers = new AdminManageCustomers();
            adminManageCustomers.Show();
        }

        private void AdminDashboardConfirmOrderBtn_Click(object sender, EventArgs e)
        {//admin home close and go to comfirm orders
            this.Close();
            AdminConfirmOrder adminConfirmOrder = new AdminConfirmOrder();
            adminConfirmOrder.Show();
        }

        private void AdminDashboardReportPanelreportBtn_Click(object sender, EventArgs e)
        {//admin home close and go to reports
            this.Close();
            AdminReportsForm adminReports = new AdminReportsForm();
            adminReports.Show();
            
        }

        private void AdminDashboardLogoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You sure want to Logout!", "Info");//confirm logout
            this.Close();

            LoginForm logonForm = new LoginForm();
            logonForm.Show();//when exit from login form, direct to login page
        }

        private void button1_Click(object sender, EventArgs e)
        {//go to sold item menu
            this.Close();
            AdminSoldOrders adminSoldOrders = new AdminSoldOrders();
            adminSoldOrders.Show();
        }
    }
}
