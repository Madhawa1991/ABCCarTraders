using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static ABC_Car_Traders.LoginForm;

namespace ABC_Car_Traders
{
    public partial class CustomerTrackOrders : Form
    {
        private string connectionString = "Data Source=DESKTOP-UJJH25V;Initial Catalog=\"ABC Car Traders\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public CustomerTrackOrders()
        {
            InitializeComponent();

            // Assign the user details to the text boxes when the form loads
            CustomerTrackOrderUsernameBox.Text = UserSession.UserName;
            CustomerTrackOrderUserIDBox.Text = UserSession.UserID;
            CustomerTrackOrderDateBox.Text = UserSession.LoginDate.ToString("MM/dd/yyyy");
            //load information form in to the panel as default
            CustomerTrackOrderInformation customerTrackOrderInformation = new CustomerTrackOrderInformation();
            CustomerTrackOrderPendingOrdersPanel.Controls.Clear();
            customerTrackOrderInformation.TopLevel = false;
            customerTrackOrderInformation.Dock = DockStyle.Fill;
            CustomerTrackOrderPendingOrdersPanel.Controls.Add(customerTrackOrderInformation);
            customerTrackOrderInformation.Show();

        }


        private void CustomerTrackOrderConfirmOredrItemBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the FavoriteItemsForm
            CustomerTrackConfirmedItems customerTrackConfirmedItems = new CustomerTrackConfirmedItems();

            // Set the TopLevel property to false to allow embedding
            customerTrackConfirmedItems.TopLevel = false;

            // Remove any existing controls from the panel (optional, to avoid duplicates)
            CustomerTrackOrderPendingOrdersPanel.Controls.Clear();

            // Set form's DockStyle to Fill to occupy the entire panel space
            customerTrackConfirmedItems.Dock = DockStyle.Fill;

            // Add the form to the panel
            CustomerTrackOrderPendingOrdersPanel.Controls.Add(customerTrackConfirmedItems);

            // Show the form
            customerTrackConfirmedItems.Show();
        }

        private void CustomerTrackOrderSearchItemOrderItemBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerItemSearch customerItemSearch = new CustomerItemSearch();
            customerItemSearch.Show();
        }

        private void CustomerSearchItemViewFavariotBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerFavarioutItems customerFavarioutItems = new CustomerFavarioutItems();
            customerFavarioutItems.Show();
        }

        private void CustomerTrackOrderRejectOredrItemBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the RejectItemsForm
            CustomerRejectOrderView customerRejectOrderView = new CustomerRejectOrderView();

            // Set the TopLevel property to false to allow embedding
            customerRejectOrderView.TopLevel = false;

            // Remove any existing controls from the panel (optional, to avoid duplicates)
            CustomerTrackOrderPendingOrdersPanel.Controls.Clear();

            // Set form's DockStyle to Fill to occupy the entire panel space
            customerRejectOrderView.Dock = DockStyle.Fill;

            // Add the form to the panel
            CustomerTrackOrderPendingOrdersPanel.Controls.Add(customerRejectOrderView);

            // Show the form
            customerRejectOrderView.Show();
        }

        private void CustomerTrackOrderOrdersstemBtn_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the FavoriteItemsForm
            CustomerTrackOrderdItems customerTrackOrderdItems = new CustomerTrackOrderdItems();

            // Set the TopLevel property to false to allow embedding
            customerTrackOrderdItems.TopLevel = false;

            // Remove any existing controls from the panel (optional, to avoid duplicates)
            CustomerTrackOrderPendingOrdersPanel.Controls.Clear();

            // Set form's DockStyle to Fill to occupy the entire panel space
            customerTrackOrderdItems.Dock = DockStyle.Fill;

            // Add the form to the panel
            CustomerTrackOrderPendingOrdersPanel.Controls.Add(customerTrackOrderdItems);

            // Show the form
            customerTrackOrderdItems.Show();
        }

        private void CustomerSearchItemV_Click(object sender, EventArgs e)
        {
            CustomerTrackOrderPendingOrdersPanel.Controls.Clear();//clear the panel and load defalult information
            CustomerTrackOrderInformation customerTrackOrderInformation = new CustomerTrackOrderInformation();
            customerTrackOrderInformation.TopLevel = false;
            customerTrackOrderInformation.Dock = DockStyle.Fill;
            CustomerTrackOrderPendingOrdersPanel.Controls.Add(customerTrackOrderInformation);
            customerTrackOrderInformation.Show();

        }

    }
}


