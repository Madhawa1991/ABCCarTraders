namespace ABC_Car_Traders
{
    partial class CustomerDashBoard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashBoard));
            CustomerDashBoardDateBox = new TextBox();
            CustomerDashBoardUsernameBox = new TextBox();
            CustomerDashBoardUserIDBox = new TextBox();
            CustomerDashBoardHeaderPannel = new Panel();
            CustomerDashBoardDatelabel = new Label();
            LogoBox = new PictureBox();
            CustomerDashboardLabel = new Label();
            CustomerDashboardLogoutBtn = new Button();
            CustomerDashboardWelcomeLabel = new Label();
            CustomerDashBoardUserIDlabel = new Label();
            CustomerDashBoardNamelabel = new Label();
            CustomerDashBoardMainPanel = new Panel();
            itemSearchPanel = new Panel();
            CustomerDashboardItemSearchDescription = new Label();
            CustomerDashbordItemSearchlabel = new Label();
            itemSearchLabel = new Label();
            itemSearchButton = new Button();
            favoritesPanel = new Panel();
            CustomerDashboardItemFavorioutDescription = new Label();
            favoritesLabel = new Label();
            addToFavoritesButton = new Button();
            orderTrackPanel = new Panel();
            label3 = new Label();
            TrackOrderLabel = new Label();
            viewOrderStatusButton = new Button();
            CustomerDashBoardHeaderPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            CustomerDashBoardMainPanel.SuspendLayout();
            itemSearchPanel.SuspendLayout();
            favoritesPanel.SuspendLayout();
            orderTrackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerDashBoardDateBox
            // 
            CustomerDashBoardDateBox.BackColor = SystemColors.GradientInactiveCaption;
            CustomerDashBoardDateBox.BorderStyle = BorderStyle.None;
            CustomerDashBoardDateBox.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            CustomerDashBoardDateBox.Location = new Point(105, 90);
            CustomerDashBoardDateBox.Name = "CustomerDashBoardDateBox";
            CustomerDashBoardDateBox.Size = new Size(164, 24);
            CustomerDashBoardDateBox.TabIndex = 2;
            // 
            // CustomerDashBoardUsernameBox
            // 
            CustomerDashBoardUsernameBox.BackColor = SystemColors.GradientInactiveCaption;
            CustomerDashBoardUsernameBox.BorderStyle = BorderStyle.None;
            CustomerDashBoardUsernameBox.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            CustomerDashBoardUsernameBox.Location = new Point(105, 9);
            CustomerDashBoardUsernameBox.Name = "CustomerDashBoardUsernameBox";
            CustomerDashBoardUsernameBox.ReadOnly = true;
            CustomerDashBoardUsernameBox.Size = new Size(178, 24);
            CustomerDashBoardUsernameBox.TabIndex = 3;
            // 
            // CustomerDashBoardUserIDBox
            // 
            CustomerDashBoardUserIDBox.BackColor = SystemColors.GradientInactiveCaption;
            CustomerDashBoardUserIDBox.BorderStyle = BorderStyle.None;
            CustomerDashBoardUserIDBox.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            CustomerDashBoardUserIDBox.Location = new Point(105, 44);
            CustomerDashBoardUserIDBox.Name = "CustomerDashBoardUserIDBox";
            CustomerDashBoardUserIDBox.Size = new Size(69, 24);
            CustomerDashBoardUserIDBox.TabIndex = 5;
            // 
            // CustomerDashBoardHeaderPannel
            // 
            CustomerDashBoardHeaderPannel.BackColor = SystemColors.GradientInactiveCaption;
            CustomerDashBoardHeaderPannel.BorderStyle = BorderStyle.Fixed3D;
            CustomerDashBoardHeaderPannel.Controls.Add(CustomerDashBoardDatelabel);
            CustomerDashBoardHeaderPannel.Controls.Add(LogoBox);
            CustomerDashBoardHeaderPannel.Controls.Add(CustomerDashboardLabel);
            CustomerDashBoardHeaderPannel.Controls.Add(CustomerDashboardWelcomeLabel);
            CustomerDashBoardHeaderPannel.Controls.Add(CustomerDashBoardUserIDlabel);
            CustomerDashBoardHeaderPannel.Controls.Add(CustomerDashBoardNamelabel);
            CustomerDashBoardHeaderPannel.Controls.Add(CustomerDashBoardDateBox);
            CustomerDashBoardHeaderPannel.Controls.Add(CustomerDashBoardUsernameBox);
            CustomerDashBoardHeaderPannel.Controls.Add(CustomerDashBoardUserIDBox);
            CustomerDashBoardHeaderPannel.Dock = DockStyle.Top;
            CustomerDashBoardHeaderPannel.Location = new Point(0, 0);
            CustomerDashBoardHeaderPannel.Name = "CustomerDashBoardHeaderPannel";
            CustomerDashBoardHeaderPannel.Size = new Size(969, 137);
            CustomerDashBoardHeaderPannel.TabIndex = 0;
            // 
            // CustomerDashBoardDatelabel
            // 
            CustomerDashBoardDatelabel.AutoSize = true;
            CustomerDashBoardDatelabel.Font = new Font("Segoe UI Emoji", 10.18868F, FontStyle.Bold);
            CustomerDashBoardDatelabel.Location = new Point(54, 90);
            CustomerDashBoardDatelabel.Name = "CustomerDashBoardDatelabel";
            CustomerDashBoardDatelabel.Size = new Size(45, 20);
            CustomerDashBoardDatelabel.TabIndex = 15;
            CustomerDashBoardDatelabel.Text = "Date";
            // 
            // LogoBox
            // 
            LogoBox.Image = (Image)resources.GetObject("LogoBox.Image");
            LogoBox.Location = new Point(726, -34);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(241, 197);
            LogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoBox.TabIndex = 14;
            LogoBox.TabStop = false;
            // 
            // CustomerDashboardLabel
            // 
            CustomerDashboardLabel.AutoSize = true;
            CustomerDashboardLabel.Font = new Font("Segoe UI Historic", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerDashboardLabel.ForeColor = SystemColors.Highlight;
            CustomerDashboardLabel.Location = new Point(361, 90);
            CustomerDashboardLabel.Name = "CustomerDashboardLabel";
            CustomerDashboardLabel.Size = new Size(270, 35);
            CustomerDashboardLabel.TabIndex = 10;
            CustomerDashboardLabel.Text = "Customer Dashboard";
            // 
            // CustomerDashboardLogoutBtn
            // 
            CustomerDashboardLogoutBtn.BackColor = Color.Red;
            CustomerDashboardLogoutBtn.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerDashboardLogoutBtn.ForeColor = SystemColors.InactiveCaptionText;
            CustomerDashboardLogoutBtn.Location = new Point(841, 4);
            CustomerDashboardLogoutBtn.Name = "CustomerDashboardLogoutBtn";
            CustomerDashboardLogoutBtn.Size = new Size(114, 43);
            CustomerDashboardLogoutBtn.TabIndex = 9;
            CustomerDashboardLogoutBtn.Text = "Logout";
            CustomerDashboardLogoutBtn.UseVisualStyleBackColor = false;
            CustomerDashboardLogoutBtn.Click += CustomerDashboardLogoutBtn_Click;
            // 
            // CustomerDashboardWelcomeLabel
            // 
            CustomerDashboardWelcomeLabel.AutoSize = true;
            CustomerDashboardWelcomeLabel.Font = new Font("Segoe UI Historic", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerDashboardWelcomeLabel.ForeColor = SystemColors.Highlight;
            CustomerDashboardWelcomeLabel.Location = new Point(289, 21);
            CustomerDashboardWelcomeLabel.Name = "CustomerDashboardWelcomeLabel";
            CustomerDashboardWelcomeLabel.Size = new Size(422, 35);
            CustomerDashboardWelcomeLabel.TabIndex = 8;
            CustomerDashboardWelcomeLabel.Text = "Wellcome to ABC Car Traders PVT";
            // 
            // CustomerDashBoardUserIDlabel
            // 
            CustomerDashBoardUserIDlabel.AutoSize = true;
            CustomerDashBoardUserIDlabel.Font = new Font("Segoe UI Emoji", 10.18868F, FontStyle.Bold);
            CustomerDashBoardUserIDlabel.Location = new Point(-2, 48);
            CustomerDashBoardUserIDlabel.Name = "CustomerDashBoardUserIDlabel";
            CustomerDashBoardUserIDlabel.Size = new Size(101, 20);
            CustomerDashBoardUserIDlabel.TabIndex = 7;
            CustomerDashBoardUserIDlabel.Text = "Your user ID";
            // 
            // CustomerDashBoardNamelabel
            // 
            CustomerDashBoardNamelabel.AutoSize = true;
            CustomerDashBoardNamelabel.Font = new Font("Segoe UI Emoji", 10.18868F, FontStyle.Bold);
            CustomerDashBoardNamelabel.Location = new Point(46, 10);
            CustomerDashBoardNamelabel.Name = "CustomerDashBoardNamelabel";
            CustomerDashBoardNamelabel.Size = new Size(53, 20);
            CustomerDashBoardNamelabel.TabIndex = 6;
            CustomerDashBoardNamelabel.Text = "Name";
            // 
            // CustomerDashBoardMainPanel
            // 
            CustomerDashBoardMainPanel.BackColor = SystemColors.GradientInactiveCaption;
            CustomerDashBoardMainPanel.Controls.Add(itemSearchPanel);
            CustomerDashBoardMainPanel.Controls.Add(favoritesPanel);
            CustomerDashBoardMainPanel.Controls.Add(orderTrackPanel);
            CustomerDashBoardMainPanel.Controls.Add(CustomerDashboardLogoutBtn);
            CustomerDashBoardMainPanel.Dock = DockStyle.Fill;
            CustomerDashBoardMainPanel.Location = new Point(0, 137);
            CustomerDashBoardMainPanel.Name = "CustomerDashBoardMainPanel";
            CustomerDashBoardMainPanel.Size = new Size(969, 509);
            CustomerDashBoardMainPanel.TabIndex = 1;
            // 
            // itemSearchPanel
            // 
            itemSearchPanel.BackColor = Color.LightSteelBlue;
            itemSearchPanel.Controls.Add(CustomerDashboardItemSearchDescription);
            itemSearchPanel.Controls.Add(CustomerDashbordItemSearchlabel);
            itemSearchPanel.Controls.Add(itemSearchLabel);
            itemSearchPanel.Controls.Add(itemSearchButton);
            itemSearchPanel.Location = new Point(12, 53);
            itemSearchPanel.Name = "itemSearchPanel";
            itemSearchPanel.Size = new Size(297, 444);
            itemSearchPanel.TabIndex = 2;
            // 
            // CustomerDashboardItemSearchDescription
            // 
            CustomerDashboardItemSearchDescription.BackColor = SystemColors.GradientActiveCaption;
            CustomerDashboardItemSearchDescription.BorderStyle = BorderStyle.Fixed3D;
            CustomerDashboardItemSearchDescription.Font = new Font("Segoe UI Historic", 10.18868F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            CustomerDashboardItemSearchDescription.ForeColor = Color.DarkSlateGray;
            CustomerDashboardItemSearchDescription.Location = new Point(10, 129);
            CustomerDashboardItemSearchDescription.Margin = new Padding(15);
            CustomerDashboardItemSearchDescription.Name = "CustomerDashboardItemSearchDescription";
            CustomerDashboardItemSearchDescription.Padding = new Padding(10);
            CustomerDashboardItemSearchDescription.Size = new Size(270, 289);
            CustomerDashboardItemSearchDescription.TabIndex = 3;
            CustomerDashboardItemSearchDescription.Text = resources.GetString("CustomerDashboardItemSearchDescription.Text");
            CustomerDashboardItemSearchDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerDashbordItemSearchlabel
            // 
            CustomerDashbordItemSearchlabel.AutoSize = true;
            CustomerDashbordItemSearchlabel.Location = new Point(40, 168);
            CustomerDashbordItemSearchlabel.Name = "CustomerDashbordItemSearchlabel";
            CustomerDashbordItemSearchlabel.Size = new Size(0, 20);
            CustomerDashbordItemSearchlabel.TabIndex = 2;
            // 
            // itemSearchLabel
            // 
            itemSearchLabel.AutoSize = true;
            itemSearchLabel.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold);
            itemSearchLabel.Location = new Point(20, 20);
            itemSearchLabel.Name = "itemSearchLabel";
            itemSearchLabel.Size = new Size(129, 30);
            itemSearchLabel.TabIndex = 0;
            itemSearchLabel.Text = "Item Search";
            // 
            // itemSearchButton
            // 
            itemSearchButton.BackColor = Color.SteelBlue;
            itemSearchButton.BackgroundImageLayout = ImageLayout.None;
            itemSearchButton.Font = new Font("Arial Narrow", 12.2264156F, FontStyle.Bold);
            itemSearchButton.Location = new Point(20, 60);
            itemSearchButton.Name = "itemSearchButton";
            itemSearchButton.Size = new Size(150, 40);
            itemSearchButton.TabIndex = 1;
            itemSearchButton.Text = "Search Items";
            itemSearchButton.UseVisualStyleBackColor = false;
            itemSearchButton.Click += itemSearchButton_Click;
            // 
            // favoritesPanel
            // 
            favoritesPanel.BackColor = Color.PaleGreen;
            favoritesPanel.Controls.Add(CustomerDashboardItemFavorioutDescription);
            favoritesPanel.Controls.Add(favoritesLabel);
            favoritesPanel.Controls.Add(addToFavoritesButton);
            favoritesPanel.Location = new Point(340, 53);
            favoritesPanel.Name = "favoritesPanel";
            favoritesPanel.Size = new Size(293, 444);
            favoritesPanel.TabIndex = 3;
            // 
            // CustomerDashboardItemFavorioutDescription
            // 
            CustomerDashboardItemFavorioutDescription.BackColor = Color.LightGreen;
            CustomerDashboardItemFavorioutDescription.BorderStyle = BorderStyle.Fixed3D;
            CustomerDashboardItemFavorioutDescription.Font = new Font("Segoe UI Historic", 10.18868F, FontStyle.Bold | FontStyle.Italic);
            CustomerDashboardItemFavorioutDescription.ForeColor = Color.DarkSlateGray;
            CustomerDashboardItemFavorioutDescription.Location = new Point(8, 129);
            CustomerDashboardItemFavorioutDescription.Margin = new Padding(15);
            CustomerDashboardItemFavorioutDescription.Name = "CustomerDashboardItemFavorioutDescription";
            CustomerDashboardItemFavorioutDescription.Padding = new Padding(10);
            CustomerDashboardItemFavorioutDescription.Size = new Size(270, 289);
            CustomerDashboardItemFavorioutDescription.TabIndex = 4;
            CustomerDashboardItemFavorioutDescription.Text = resources.GetString("CustomerDashboardItemFavorioutDescription.Text");
            CustomerDashboardItemFavorioutDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // favoritesLabel
            // 
            favoritesLabel.AutoSize = true;
            favoritesLabel.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold);
            favoritesLabel.Location = new Point(20, 20);
            favoritesLabel.Name = "favoritesLabel";
            favoritesLabel.Size = new Size(145, 30);
            favoritesLabel.TabIndex = 0;
            favoritesLabel.Text = "View Favorite";
            // 
            // addToFavoritesButton
            // 
            addToFavoritesButton.BackColor = Color.Chartreuse;
            addToFavoritesButton.BackgroundImageLayout = ImageLayout.None;
            addToFavoritesButton.Font = new Font("Arial Narrow", 12.2264156F, FontStyle.Bold);
            addToFavoritesButton.Location = new Point(20, 60);
            addToFavoritesButton.Name = "addToFavoritesButton";
            addToFavoritesButton.Size = new Size(150, 40);
            addToFavoritesButton.TabIndex = 1;
            addToFavoritesButton.Text = "View Favorite";
            addToFavoritesButton.UseVisualStyleBackColor = false;
            addToFavoritesButton.Click += addToFavoritesButton_Click;
            // 
            // orderTrackPanel
            // 
            orderTrackPanel.BackColor = Color.LightCoral;
            orderTrackPanel.Controls.Add(label3);
            orderTrackPanel.Controls.Add(TrackOrderLabel);
            orderTrackPanel.Controls.Add(viewOrderStatusButton);
            orderTrackPanel.Location = new Point(660, 53);
            orderTrackPanel.Name = "orderTrackPanel";
            orderTrackPanel.Size = new Size(295, 444);
            orderTrackPanel.TabIndex = 4;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(255, 128, 128);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI Historic", 10.18868F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(10, 129);
            label3.Margin = new Padding(15);
            label3.Name = "label3";
            label3.Padding = new Padding(10);
            label3.Size = new Size(270, 289);
            label3.TabIndex = 5;
            label3.Text = resources.GetString("label3.Text");
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TrackOrderLabel
            // 
            TrackOrderLabel.AutoSize = true;
            TrackOrderLabel.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold);
            TrackOrderLabel.Location = new Point(20, 20);
            TrackOrderLabel.Name = "TrackOrderLabel";
            TrackOrderLabel.Size = new Size(126, 30);
            TrackOrderLabel.TabIndex = 0;
            TrackOrderLabel.Text = "Track Order";
            // 
            // viewOrderStatusButton
            // 
            viewOrderStatusButton.BackColor = Color.IndianRed;
            viewOrderStatusButton.BackgroundImageLayout = ImageLayout.None;
            viewOrderStatusButton.Font = new Font("Arial Narrow", 12.2264156F, FontStyle.Bold);
            viewOrderStatusButton.Location = new Point(20, 60);
            viewOrderStatusButton.Name = "viewOrderStatusButton";
            viewOrderStatusButton.Size = new Size(150, 40);
            viewOrderStatusButton.TabIndex = 1;
            viewOrderStatusButton.Text = "Track Order";
            viewOrderStatusButton.UseVisualStyleBackColor = false;
            viewOrderStatusButton.Click += viewOrderStatusButton_Click;
            // 
            // CustomerDashBoard
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 646);
            ControlBox = false;
            Controls.Add(CustomerDashBoardMainPanel);
            Controls.Add(CustomerDashBoardHeaderPannel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CustomerDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Dashboard";
            Load += CustomerDashBoard_Load;
            CustomerDashBoardHeaderPannel.ResumeLayout(false);
            CustomerDashBoardHeaderPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            CustomerDashBoardMainPanel.ResumeLayout(false);
            itemSearchPanel.ResumeLayout(false);
            itemSearchPanel.PerformLayout();
            favoritesPanel.ResumeLayout(false);
            favoritesPanel.PerformLayout();
            orderTrackPanel.ResumeLayout(false);
            orderTrackPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox CustomerDashBoardDateBox;
        private TextBox CustomerDashBoardUsernameBox;
        private TextBox CustomerDashBoardUserIDBox;
        private Panel CustomerDashBoardHeaderPannel;
        private Panel CustomerDashBoardMainPanel;
        private Panel itemSearchPanel;
        private Panel favoritesPanel;
        private Panel orderTrackPanel;
        private Label itemSearchLabel;
        private Label favoritesLabel;
        private Label TrackOrderLabel;
        private Button itemSearchButton;
        private Button addToFavoritesButton;
        private Button viewOrderStatusButton;
        private Label CustomerDashbordItemSearchlabel;
        private Label CustomerDashboardItemSearchDescription;
        private Label CustomerDashboardItemFavorioutDescription;
        private Label label3;
        private Label CustomerDashBoardUserIDlabel;
        private Label CustomerDashBoardNamelabel;
        private Button CustomerDashboardLogoutBtn;
        private Label CustomerDashboardWelcomeLabel;
        private Label CustomerDashboardLabel;
        private PictureBox LogoBox;
        private Label CustomerDashBoardDatelabel;
    }
}
