using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CustomerTrackOrders : Form
    {
        private Panel CustomerTrackOrderPendingOrdersPanel;
        private Panel CustomerTrackOrderPanelButton;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTrackOrders));
            CustomerTrackOrderPendingOrdersPanel = new Panel();
            CustomerTrackOrderPanelButton = new Panel();
            CustomerSearchItemV = new Button();
            CustomerTrackOrderStatusbtnsLabel = new Label();
            CustomerTrackOrderRejectOredrItemBtn = new Button();
            CustomerTrackOrderConfirmOredrItemBtn = new Button();
            CustomerTrackOrderOrdersstemBtn = new Button();
            CustomerTrackOrderSearchItemOrderItemBtn = new Button();
            CustomerSearchItemViewFavariotBtn = new Button();
            CustomerTrackOrderExitBtn = new Button();
            CustomerTrackOrderWelcomeLabel = new Label();
            CustomerTrackOrderMenuLabel = new Label();
            CustomerTrackOrderHeaderPannel = new Panel();
            CustomerTrackOrdersLogoPanel = new Panel();
            LogoBox = new PictureBox();
            CustomerTrackOrderDateBox = new TextBox();
            CustomerDashBoardUserIDlabel = new Label();
            CustomerDashBoardNamelabel = new Label();
            CustomerTrackOrderUsernameBox = new TextBox();
            CustomerTrackOrderUserIDBox = new TextBox();
            CustomerTrackOrderPanelButton.SuspendLayout();
            CustomerTrackOrderHeaderPannel.SuspendLayout();
            CustomerTrackOrdersLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // CustomerTrackOrderPendingOrdersPanel
            // 
            CustomerTrackOrderPendingOrdersPanel.BackColor = Color.IndianRed;
            CustomerTrackOrderPendingOrdersPanel.Location = new Point(0, 120);
            CustomerTrackOrderPendingOrdersPanel.Name = "CustomerTrackOrderPendingOrdersPanel";
            CustomerTrackOrderPendingOrdersPanel.Size = new Size(902, 618);
            CustomerTrackOrderPendingOrdersPanel.TabIndex = 1;
            // 
            // CustomerTrackOrderPanelButton
            // 
            CustomerTrackOrderPanelButton.BackColor = Color.Black;
            CustomerTrackOrderPanelButton.Controls.Add(CustomerSearchItemV);
            CustomerTrackOrderPanelButton.Controls.Add(CustomerTrackOrderStatusbtnsLabel);
            CustomerTrackOrderPanelButton.Controls.Add(CustomerTrackOrderRejectOredrItemBtn);
            CustomerTrackOrderPanelButton.Controls.Add(CustomerTrackOrderConfirmOredrItemBtn);
            CustomerTrackOrderPanelButton.Controls.Add(CustomerTrackOrderOrdersstemBtn);
            CustomerTrackOrderPanelButton.Controls.Add(CustomerTrackOrderSearchItemOrderItemBtn);
            CustomerTrackOrderPanelButton.Controls.Add(CustomerSearchItemViewFavariotBtn);
            CustomerTrackOrderPanelButton.Controls.Add(CustomerTrackOrderExitBtn);
            CustomerTrackOrderPanelButton.Location = new Point(900, 120);
            CustomerTrackOrderPanelButton.Name = "CustomerTrackOrderPanelButton";
            CustomerTrackOrderPanelButton.Size = new Size(261, 735);
            CustomerTrackOrderPanelButton.TabIndex = 3;
            // 
            // CustomerSearchItemV
            // 
            CustomerSearchItemV.BackColor = Color.DarkTurquoise;
            CustomerSearchItemV.BackgroundImageLayout = ImageLayout.None;
            CustomerSearchItemV.Font = new Font("Arial Narrow", 12.2264156F, FontStyle.Bold);
            CustomerSearchItemV.Location = new Point(58, 505);
            CustomerSearchItemV.Name = "CustomerSearchItemV";
            CustomerSearchItemV.Size = new Size(150, 40);
            CustomerSearchItemV.TabIndex = 52;
            CustomerSearchItemV.Text = "Clear";
            CustomerSearchItemV.UseVisualStyleBackColor = false;
            CustomerSearchItemV.Click += CustomerSearchItemV_Click;
            // 
            // CustomerTrackOrderStatusbtnsLabel
            // 
            CustomerTrackOrderStatusbtnsLabel.AutoSize = true;
            CustomerTrackOrderStatusbtnsLabel.Font = new Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerTrackOrderStatusbtnsLabel.Location = new Point(9, 249);
            CustomerTrackOrderStatusbtnsLabel.Name = "CustomerTrackOrderStatusbtnsLabel";
            CustomerTrackOrderStatusbtnsLabel.Size = new Size(242, 21);
            CustomerTrackOrderStatusbtnsLabel.TabIndex = 51;
            CustomerTrackOrderStatusbtnsLabel.Text = "Click on below buttons to view ";
            // 
            // CustomerTrackOrderRejectOredrItemBtn
            // 
            CustomerTrackOrderRejectOredrItemBtn.BackColor = Color.IndianRed;
            CustomerTrackOrderRejectOredrItemBtn.BackgroundImageLayout = ImageLayout.None;
            CustomerTrackOrderRejectOredrItemBtn.Font = new Font("Arial Narrow", 12.2264156F, FontStyle.Bold);
            CustomerTrackOrderRejectOredrItemBtn.Location = new Point(58, 407);
            CustomerTrackOrderRejectOredrItemBtn.Name = "CustomerTrackOrderRejectOredrItemBtn";
            CustomerTrackOrderRejectOredrItemBtn.Size = new Size(150, 40);
            CustomerTrackOrderRejectOredrItemBtn.TabIndex = 50;
            CustomerTrackOrderRejectOredrItemBtn.Text = "Reject Order";
            CustomerTrackOrderRejectOredrItemBtn.UseVisualStyleBackColor = false;
            CustomerTrackOrderRejectOredrItemBtn.Click += CustomerTrackOrderRejectOredrItemBtn_Click;
            // 
            // CustomerTrackOrderConfirmOredrItemBtn
            // 
            CustomerTrackOrderConfirmOredrItemBtn.BackColor = Color.IndianRed;
            CustomerTrackOrderConfirmOredrItemBtn.BackgroundImageLayout = ImageLayout.None;
            CustomerTrackOrderConfirmOredrItemBtn.Font = new Font("Arial Narrow", 12.2264156F, FontStyle.Bold);
            CustomerTrackOrderConfirmOredrItemBtn.Location = new Point(58, 342);
            CustomerTrackOrderConfirmOredrItemBtn.Name = "CustomerTrackOrderConfirmOredrItemBtn";
            CustomerTrackOrderConfirmOredrItemBtn.Size = new Size(150, 40);
            CustomerTrackOrderConfirmOredrItemBtn.TabIndex = 49;
            CustomerTrackOrderConfirmOredrItemBtn.Text = "Confirmed Orders";
            CustomerTrackOrderConfirmOredrItemBtn.UseVisualStyleBackColor = false;
            CustomerTrackOrderConfirmOredrItemBtn.Click += CustomerTrackOrderConfirmOredrItemBtn_Click;
            // 
            // CustomerTrackOrderOrdersstemBtn
            // 
            CustomerTrackOrderOrdersstemBtn.BackColor = Color.IndianRed;
            CustomerTrackOrderOrdersstemBtn.BackgroundImageLayout = ImageLayout.None;
            CustomerTrackOrderOrdersstemBtn.Font = new Font("Arial Narrow", 12.2264156F, FontStyle.Bold);
            CustomerTrackOrderOrdersstemBtn.Location = new Point(58, 282);
            CustomerTrackOrderOrdersstemBtn.Name = "CustomerTrackOrderOrdersstemBtn";
            CustomerTrackOrderOrdersstemBtn.Size = new Size(150, 40);
            CustomerTrackOrderOrdersstemBtn.TabIndex = 48;
            CustomerTrackOrderOrdersstemBtn.Text = "Orderd Items";
            CustomerTrackOrderOrdersstemBtn.UseVisualStyleBackColor = false;
            CustomerTrackOrderOrdersstemBtn.Click += CustomerTrackOrderOrdersstemBtn_Click_1;
            // 
            // CustomerTrackOrderSearchItemOrderItemBtn
            // 
            CustomerTrackOrderSearchItemOrderItemBtn.BackColor = Color.LightSteelBlue;
            CustomerTrackOrderSearchItemOrderItemBtn.BackgroundImageLayout = ImageLayout.None;
            CustomerTrackOrderSearchItemOrderItemBtn.Font = new Font("Arial Narrow", 12.2264156F, FontStyle.Bold);
            CustomerTrackOrderSearchItemOrderItemBtn.Location = new Point(58, 75);
            CustomerTrackOrderSearchItemOrderItemBtn.Name = "CustomerTrackOrderSearchItemOrderItemBtn";
            CustomerTrackOrderSearchItemOrderItemBtn.Size = new Size(150, 40);
            CustomerTrackOrderSearchItemOrderItemBtn.TabIndex = 47;
            CustomerTrackOrderSearchItemOrderItemBtn.Text = "Search Items";
            CustomerTrackOrderSearchItemOrderItemBtn.UseVisualStyleBackColor = false;
            CustomerTrackOrderSearchItemOrderItemBtn.Click += CustomerTrackOrderSearchItemOrderItemBtn_Click;
            // 
            // CustomerSearchItemViewFavariotBtn
            // 
            CustomerSearchItemViewFavariotBtn.BackColor = Color.Chartreuse;
            CustomerSearchItemViewFavariotBtn.BackgroundImageLayout = ImageLayout.None;
            CustomerSearchItemViewFavariotBtn.Font = new Font("Arial Narrow", 12.2264156F, FontStyle.Bold);
            CustomerSearchItemViewFavariotBtn.Location = new Point(58, 149);
            CustomerSearchItemViewFavariotBtn.Name = "CustomerSearchItemViewFavariotBtn";
            CustomerSearchItemViewFavariotBtn.Size = new Size(150, 40);
            CustomerSearchItemViewFavariotBtn.TabIndex = 46;
            CustomerSearchItemViewFavariotBtn.Text = "View Favorite";
            CustomerSearchItemViewFavariotBtn.UseVisualStyleBackColor = false;
            CustomerSearchItemViewFavariotBtn.Click += CustomerSearchItemViewFavariotBtn_Click;
            // 
            // CustomerTrackOrderExitBtn
            // 
            CustomerTrackOrderExitBtn.BackColor = Color.Crimson;
            CustomerTrackOrderExitBtn.Location = new Point(58, 12);
            CustomerTrackOrderExitBtn.Name = "CustomerTrackOrderExitBtn";
            CustomerTrackOrderExitBtn.Size = new Size(150, 40);
            CustomerTrackOrderExitBtn.TabIndex = 0;
            CustomerTrackOrderExitBtn.Text = "Exit";
            CustomerTrackOrderExitBtn.UseVisualStyleBackColor = false;
            CustomerTrackOrderExitBtn.Click += CustomerSearchItemExitBtn_Click;
            // 
            // CustomerTrackOrderWelcomeLabel
            // 
            CustomerTrackOrderWelcomeLabel.AutoSize = true;
            CustomerTrackOrderWelcomeLabel.Font = new Font("Segoe UI Historic", 16F, FontStyle.Bold);
            CustomerTrackOrderWelcomeLabel.ForeColor = SystemColors.Desktop;
            CustomerTrackOrderWelcomeLabel.Location = new Point(315, 9);
            CustomerTrackOrderWelcomeLabel.Name = "CustomerTrackOrderWelcomeLabel";
            CustomerTrackOrderWelcomeLabel.Size = new Size(399, 32);
            CustomerTrackOrderWelcomeLabel.TabIndex = 2;
            CustomerTrackOrderWelcomeLabel.Text = "Welcome to ABC Car Traders PVT";
            // 
            // CustomerTrackOrderMenuLabel
            // 
            CustomerTrackOrderMenuLabel.AutoSize = true;
            CustomerTrackOrderMenuLabel.Font = new Font("Segoe UI Historic", 16F, FontStyle.Bold);
            CustomerTrackOrderMenuLabel.ForeColor = SystemColors.Desktop;
            CustomerTrackOrderMenuLabel.Location = new Point(379, 54);
            CustomerTrackOrderMenuLabel.Name = "CustomerTrackOrderMenuLabel";
            CustomerTrackOrderMenuLabel.Size = new Size(224, 32);
            CustomerTrackOrderMenuLabel.TabIndex = 1;
            CustomerTrackOrderMenuLabel.Text = "Track Order Menu";
            // 
            // CustomerTrackOrderHeaderPannel
            // 
            CustomerTrackOrderHeaderPannel.BackColor = Color.IndianRed;
            CustomerTrackOrderHeaderPannel.Controls.Add(CustomerTrackOrdersLogoPanel);
            CustomerTrackOrderHeaderPannel.Controls.Add(CustomerTrackOrderDateBox);
            CustomerTrackOrderHeaderPannel.Controls.Add(CustomerDashBoardUserIDlabel);
            CustomerTrackOrderHeaderPannel.Controls.Add(CustomerTrackOrderMenuLabel);
            CustomerTrackOrderHeaderPannel.Controls.Add(CustomerDashBoardNamelabel);
            CustomerTrackOrderHeaderPannel.Controls.Add(CustomerTrackOrderUsernameBox);
            CustomerTrackOrderHeaderPannel.Controls.Add(CustomerTrackOrderWelcomeLabel);
            CustomerTrackOrderHeaderPannel.Controls.Add(CustomerTrackOrderUserIDBox);
            CustomerTrackOrderHeaderPannel.Dock = DockStyle.Top;
            CustomerTrackOrderHeaderPannel.Location = new Point(0, 0);
            CustomerTrackOrderHeaderPannel.Name = "CustomerTrackOrderHeaderPannel";
            CustomerTrackOrderHeaderPannel.Size = new Size(1157, 114);
            CustomerTrackOrderHeaderPannel.TabIndex = 0;
            // 
            // CustomerTrackOrdersLogoPanel
            // 
            CustomerTrackOrdersLogoPanel.BackColor = Color.Black;
            CustomerTrackOrdersLogoPanel.Controls.Add(LogoBox);
            CustomerTrackOrdersLogoPanel.Location = new Point(900, -8);
            CustomerTrackOrdersLogoPanel.Name = "CustomerTrackOrdersLogoPanel";
            CustomerTrackOrdersLogoPanel.Size = new Size(271, 134);
            CustomerTrackOrdersLogoPanel.TabIndex = 13;
            // 
            // LogoBox
            // 
            LogoBox.Image = (Image)resources.GetObject("LogoBox.Image");
            LogoBox.Location = new Point(3, -19);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(248, 166);
            LogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoBox.TabIndex = 14;
            LogoBox.TabStop = false;
            // 
            // CustomerTrackOrderDateBox
            // 
            CustomerTrackOrderDateBox.BackColor = Color.IndianRed;
            CustomerTrackOrderDateBox.BorderStyle = BorderStyle.None;
            CustomerTrackOrderDateBox.Font = new Font("Algerian", 14.2641506F, FontStyle.Bold);
            CustomerTrackOrderDateBox.Location = new Point(695, 66);
            CustomerTrackOrderDateBox.Name = "CustomerTrackOrderDateBox";
            CustomerTrackOrderDateBox.Size = new Size(164, 28);
            CustomerTrackOrderDateBox.TabIndex = 12;
            // 
            // CustomerDashBoardUserIDlabel
            // 
            CustomerDashBoardUserIDlabel.AutoSize = true;
            CustomerDashBoardUserIDlabel.Font = new Font("Segoe UI Emoji", 10.18868F, FontStyle.Bold);
            CustomerDashBoardUserIDlabel.Location = new Point(5, 66);
            CustomerDashBoardUserIDlabel.Name = "CustomerDashBoardUserIDlabel";
            CustomerDashBoardUserIDlabel.Size = new Size(101, 20);
            CustomerDashBoardUserIDlabel.TabIndex = 11;
            CustomerDashBoardUserIDlabel.Text = "Your user ID";
            // 
            // CustomerDashBoardNamelabel
            // 
            CustomerDashBoardNamelabel.AutoSize = true;
            CustomerDashBoardNamelabel.Font = new Font("Segoe UI Emoji", 10.18868F, FontStyle.Bold);
            CustomerDashBoardNamelabel.Location = new Point(53, 30);
            CustomerDashBoardNamelabel.Name = "CustomerDashBoardNamelabel";
            CustomerDashBoardNamelabel.Size = new Size(53, 20);
            CustomerDashBoardNamelabel.TabIndex = 10;
            CustomerDashBoardNamelabel.Text = "Name";
            // 
            // CustomerTrackOrderUsernameBox
            // 
            CustomerTrackOrderUsernameBox.BackColor = Color.IndianRed;
            CustomerTrackOrderUsernameBox.BorderStyle = BorderStyle.None;
            CustomerTrackOrderUsernameBox.Font = new Font("Algerian", 14.2641506F, FontStyle.Bold);
            CustomerTrackOrderUsernameBox.Location = new Point(116, 27);
            CustomerTrackOrderUsernameBox.Name = "CustomerTrackOrderUsernameBox";
            CustomerTrackOrderUsernameBox.ReadOnly = true;
            CustomerTrackOrderUsernameBox.Size = new Size(178, 28);
            CustomerTrackOrderUsernameBox.TabIndex = 8;
            // 
            // CustomerTrackOrderUserIDBox
            // 
            CustomerTrackOrderUserIDBox.BackColor = Color.IndianRed;
            CustomerTrackOrderUserIDBox.BorderStyle = BorderStyle.None;
            CustomerTrackOrderUserIDBox.Font = new Font("Algerian", 14.2641506F, FontStyle.Bold);
            CustomerTrackOrderUserIDBox.Location = new Point(116, 63);
            CustomerTrackOrderUserIDBox.Name = "CustomerTrackOrderUserIDBox";
            CustomerTrackOrderUserIDBox.Size = new Size(69, 28);
            CustomerTrackOrderUserIDBox.TabIndex = 9;
            // 
            // CustomerTrackOrders
            // 
            ClientSize = new Size(1157, 737);
            ControlBox = false;
            Controls.Add(CustomerTrackOrderHeaderPannel);
            Controls.Add(CustomerTrackOrderPendingOrdersPanel);
            Controls.Add(CustomerTrackOrderPanelButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "CustomerTrackOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Track Orders";
            CustomerTrackOrderPanelButton.ResumeLayout(false);
            CustomerTrackOrderPanelButton.PerformLayout();
            CustomerTrackOrderHeaderPannel.ResumeLayout(false);
            CustomerTrackOrderHeaderPannel.PerformLayout();
            CustomerTrackOrdersLogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ResumeLayout(false);
        }

        private void SetupDataGridView(DataGridView gridView, Point location)
        {
            gridView.Location = location;
            gridView.Size = new Size(370, 430);
            gridView.AutoGenerateColumns = true;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void CustomerSearchItemExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerDashBoard customerDashBoard = new CustomerDashBoard();
            customerDashBoard.Show();
        }

        private Label CustomerTrackOrderWelcomeLabel;
        private Label CustomerTrackOrderMenuLabel;
        private Button CustomerTrackOrderExitBtn;
        private Panel CustomerTrackOrderHeaderPannel;
        private Button CustomerTrackOrderSearchItemOrderItemBtn;
        private Button CustomerSearchItemViewFavariotBtn;
        private Label CustomerDashBoardUserIDlabel;
        private Label CustomerDashBoardNamelabel;
        private TextBox CustomerTrackOrderUsernameBox;
        private TextBox CustomerTrackOrderUserIDBox;
        private TextBox CustomerTrackOrderDateBox;
        private DataGridView CustomerTrackOrderPendingOrdersGridView;
        private Button CustomerTrackOrderRejectOredrItemBtn;
        private Button CustomerTrackOrderConfirmOredrItemBtn;
        private Button CustomerTrackOrderOrdersstemBtn;
        private Label CustomerTrackOrderStatusbtnsLabel;
        private Button CustomerSearchItemV;
        private Panel CustomerTrackOrdersLogoPanel;
        private PictureBox LogoBox;
    }
}
