

namespace ABC_Car_Traders
{
    partial class AdminReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox AdminReportsSelectReportComboBox;
        private System.Windows.Forms.DateTimePicker AdminReportStartDatePicker;
        private System.Windows.Forms.DateTimePicker AdminReportEndDatePicker;
        private System.Windows.Forms.Button AdminReportGenerateReportButton;
        private System.Windows.Forms.Button AdminReportDownloadReportButton;
        private System.Windows.Forms.Label AdminReportsSelectReportLabel;
        private System.Windows.Forms.Label AdminReportstartDateLabel;
        private System.Windows.Forms.Label AdminReportendDateLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReportsForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            AdminReportsSelectReportLabel = new Label();
            AdminReportsSelectReportComboBox = new ComboBox();
            AdminReportstartDateLabel = new Label();
            AdminReportStartDatePicker = new DateTimePicker();
            AdminReportendDateLabel = new Label();
            AdminReportEndDatePicker = new DateTimePicker();
            AdminReportGenerateReportButton = new Button();
            AdminReportDownloadReportButton = new Button();
            AdminDashboardConfirmOrderHeadingPanel = new Panel();
            AdminReportsNameBox = new TextBox();
            AdminReportsUserIDBox = new TextBox();
            AdminReportsDateBox = new TextBox();
            AdminReportLogoBox = new PictureBox();
            AdminReportsHeaderLabel1 = new Label();
            AdminReportsHeaderLable = new Label();
            AdminReportsuserIdlabel = new Label();
            AdminReportsDateLabel = new Label();
            AdminReportsNameLabel = new Label();
            AdminDashboardConfirmOrderBoxpanel = new Panel();
            AdminReportsClickBoxLabel = new Label();
            AdminReportEnterYourQuearyLabel = new Label();
            AdminReportQuearyBox = new TextBox();
            AdminReportButnPanel = new Panel();
            AdminReportsPDFcheckBox = new CheckBox();
            AdminReportsCSVcheckBox = new CheckBox();
            AdminReportClearBtn = new Button();
            AdminReportExitBtn = new Button();
            AdminReportQuareyPanel = new Panel();
            AdminReportGenerateReportQuearyButton = new Button();
            AdminReportDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            AdminDashboardConfirmOrderHeadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminReportLogoBox).BeginInit();
            AdminDashboardConfirmOrderBoxpanel.SuspendLayout();
            AdminReportButnPanel.SuspendLayout();
            AdminReportQuareyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminReportDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AdminReportsSelectReportLabel
            // 
            AdminReportsSelectReportLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AdminReportsSelectReportLabel.Location = new Point(98, 22);
            AdminReportsSelectReportLabel.Name = "AdminReportsSelectReportLabel";
            AdminReportsSelectReportLabel.Size = new Size(134, 23);
            AdminReportsSelectReportLabel.TabIndex = 0;
            AdminReportsSelectReportLabel.Text = "Select Report Type";
            // 
            // AdminReportsSelectReportComboBox
            // 
            AdminReportsSelectReportComboBox.Items.AddRange(new object[] { "order", "Item", "customers" });
            AdminReportsSelectReportComboBox.Location = new Point(35, 48);
            AdminReportsSelectReportComboBox.Name = "AdminReportsSelectReportComboBox";
            AdminReportsSelectReportComboBox.Size = new Size(245, 28);
            AdminReportsSelectReportComboBox.TabIndex = 1;
            // 
            // AdminReportstartDateLabel
            // 
            AdminReportstartDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AdminReportstartDateLabel.Location = new Point(380, 8);
            AdminReportstartDateLabel.Name = "AdminReportstartDateLabel";
            AdminReportstartDateLabel.Size = new Size(104, 23);
            AdminReportstartDateLabel.TabIndex = 2;
            AdminReportstartDateLabel.Text = "Start Date:";
            // 
            // AdminReportStartDatePicker
            // 
            AdminReportStartDatePicker.Format = DateTimePickerFormat.Short;
            AdminReportStartDatePicker.Location = new Point(344, 48);
            AdminReportStartDatePicker.MaxDate = new DateTime(2024, 9, 3, 0, 0, 0, 0);
            AdminReportStartDatePicker.Name = "AdminReportStartDatePicker";
            AdminReportStartDatePicker.ShowCheckBox = true;
            AdminReportStartDatePicker.Size = new Size(200, 27);
            AdminReportStartDatePicker.TabIndex = 3;
            AdminReportStartDatePicker.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // AdminReportendDateLabel
            // 
            AdminReportendDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AdminReportendDateLabel.Location = new Point(656, 8);
            AdminReportendDateLabel.Name = "AdminReportendDateLabel";
            AdminReportendDateLabel.Size = new Size(100, 23);
            AdminReportendDateLabel.TabIndex = 4;
            AdminReportendDateLabel.Text = "End Date:";
            // 
            // AdminReportEndDatePicker
            // 
            AdminReportEndDatePicker.Format = DateTimePickerFormat.Short;
            AdminReportEndDatePicker.Location = new Point(605, 46);
            AdminReportEndDatePicker.MaxDate = new DateTime(2024, 9, 3, 0, 0, 0, 0);
            AdminReportEndDatePicker.Name = "AdminReportEndDatePicker";
            AdminReportEndDatePicker.ShowCheckBox = true;
            AdminReportEndDatePicker.Size = new Size(200, 27);
            AdminReportEndDatePicker.TabIndex = 5;
            AdminReportEndDatePicker.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // AdminReportGenerateReportButton
            // 
            AdminReportGenerateReportButton.BackColor = Color.Yellow;
            AdminReportGenerateReportButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AdminReportGenerateReportButton.Image = (Image)resources.GetObject("AdminReportGenerateReportButton.Image");
            AdminReportGenerateReportButton.ImageAlign = ContentAlignment.MiddleLeft;
            AdminReportGenerateReportButton.Location = new Point(829, 35);
            AdminReportGenerateReportButton.Name = "AdminReportGenerateReportButton";
            AdminReportGenerateReportButton.Size = new Size(208, 59);
            AdminReportGenerateReportButton.TabIndex = 6;
            AdminReportGenerateReportButton.Text = "Generate Report";
            AdminReportGenerateReportButton.TextAlign = ContentAlignment.MiddleRight;
            AdminReportGenerateReportButton.UseVisualStyleBackColor = false;
            AdminReportGenerateReportButton.Click += GenerateReportButton_Click;
            // 
            // AdminReportDownloadReportButton
            // 
            AdminReportDownloadReportButton.BackColor = Color.Cyan;
            AdminReportDownloadReportButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AdminReportDownloadReportButton.Image = Properties.Resources.download1;
            AdminReportDownloadReportButton.ImageAlign = ContentAlignment.MiddleLeft;
            AdminReportDownloadReportButton.Location = new Point(52, 131);
            AdminReportDownloadReportButton.Name = "AdminReportDownloadReportButton";
            AdminReportDownloadReportButton.Size = new Size(219, 59);
            AdminReportDownloadReportButton.TabIndex = 7;
            AdminReportDownloadReportButton.Text = "Download Report";
            AdminReportDownloadReportButton.TextAlign = ContentAlignment.MiddleRight;
            AdminReportDownloadReportButton.UseVisualStyleBackColor = false;
            AdminReportDownloadReportButton.Click += DownloadReportButton_Click;
            // 
            // AdminDashboardConfirmOrderHeadingPanel
            // 
            AdminDashboardConfirmOrderHeadingPanel.BackColor = Color.LightSteelBlue;
            AdminDashboardConfirmOrderHeadingPanel.Controls.Add(AdminReportsNameBox);
            AdminDashboardConfirmOrderHeadingPanel.Controls.Add(AdminReportsUserIDBox);
            AdminDashboardConfirmOrderHeadingPanel.Controls.Add(AdminReportsDateBox);
            AdminDashboardConfirmOrderHeadingPanel.Controls.Add(AdminReportLogoBox);
            AdminDashboardConfirmOrderHeadingPanel.Controls.Add(AdminReportsHeaderLabel1);
            AdminDashboardConfirmOrderHeadingPanel.Controls.Add(AdminReportsHeaderLable);
            AdminDashboardConfirmOrderHeadingPanel.Controls.Add(AdminReportsuserIdlabel);
            AdminDashboardConfirmOrderHeadingPanel.Controls.Add(AdminReportsDateLabel);
            AdminDashboardConfirmOrderHeadingPanel.Controls.Add(AdminReportsNameLabel);
            AdminDashboardConfirmOrderHeadingPanel.Location = new Point(0, 0);
            AdminDashboardConfirmOrderHeadingPanel.Name = "AdminDashboardConfirmOrderHeadingPanel";
            AdminDashboardConfirmOrderHeadingPanel.Size = new Size(1468, 166);
            AdminDashboardConfirmOrderHeadingPanel.TabIndex = 11;
            // 
            // AdminReportsNameBox
            // 
            AdminReportsNameBox.BackColor = Color.LightSteelBlue;
            AdminReportsNameBox.BorderStyle = BorderStyle.None;
            AdminReportsNameBox.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AdminReportsNameBox.Location = new Point(108, 14);
            AdminReportsNameBox.Name = "AdminReportsNameBox";
            AdminReportsNameBox.ReadOnly = true;
            AdminReportsNameBox.Size = new Size(225, 24);
            AdminReportsNameBox.TabIndex = 13;
            // 
            // AdminReportsUserIDBox
            // 
            AdminReportsUserIDBox.BackColor = Color.LightSteelBlue;
            AdminReportsUserIDBox.BorderStyle = BorderStyle.None;
            AdminReportsUserIDBox.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AdminReportsUserIDBox.Location = new Point(108, 58);
            AdminReportsUserIDBox.Name = "AdminReportsUserIDBox";
            AdminReportsUserIDBox.ReadOnly = true;
            AdminReportsUserIDBox.Size = new Size(187, 24);
            AdminReportsUserIDBox.TabIndex = 12;
            // 
            // AdminReportsDateBox
            // 
            AdminReportsDateBox.BackColor = Color.LightSteelBlue;
            AdminReportsDateBox.BorderStyle = BorderStyle.None;
            AdminReportsDateBox.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AdminReportsDateBox.Location = new Point(108, 107);
            AdminReportsDateBox.Name = "AdminReportsDateBox";
            AdminReportsDateBox.ReadOnly = true;
            AdminReportsDateBox.Size = new Size(187, 24);
            AdminReportsDateBox.TabIndex = 11;
            // 
            // AdminReportLogoBox
            // 
            AdminReportLogoBox.Image = (Image)resources.GetObject("AdminReportLogoBox.Image");
            AdminReportLogoBox.Location = new Point(1157, -41);
            AdminReportLogoBox.Name = "AdminReportLogoBox";
            AdminReportLogoBox.Size = new Size(311, 246);
            AdminReportLogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            AdminReportLogoBox.TabIndex = 5;
            AdminReportLogoBox.TabStop = false;
            // 
            // AdminReportsHeaderLabel1
            // 
            AdminReportsHeaderLabel1.BackColor = Color.Transparent;
            AdminReportsHeaderLabel1.Font = new Font("Perpetua", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminReportsHeaderLabel1.ForeColor = Color.Blue;
            AdminReportsHeaderLabel1.Location = new Point(458, 75);
            AdminReportsHeaderLabel1.Name = "AdminReportsHeaderLabel1";
            AdminReportsHeaderLabel1.Size = new Size(415, 75);
            AdminReportsHeaderLabel1.TabIndex = 4;
            AdminReportsHeaderLabel1.Text = "Reports";
            AdminReportsHeaderLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminReportsHeaderLable
            // 
            AdminReportsHeaderLable.BackColor = Color.Transparent;
            AdminReportsHeaderLable.Font = new Font("Perpetua", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminReportsHeaderLable.ForeColor = Color.Red;
            AdminReportsHeaderLable.Location = new Point(359, 7);
            AdminReportsHeaderLable.Name = "AdminReportsHeaderLable";
            AdminReportsHeaderLable.Size = new Size(619, 75);
            AdminReportsHeaderLable.TabIndex = 3;
            AdminReportsHeaderLable.Text = "ABC Car Traders PVT";
            AdminReportsHeaderLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminReportsuserIdlabel
            // 
            AdminReportsuserIdlabel.AutoSize = true;
            AdminReportsuserIdlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AdminReportsuserIdlabel.Location = new Point(34, 58);
            AdminReportsuserIdlabel.Name = "AdminReportsuserIdlabel";
            AdminReportsuserIdlabel.Size = new Size(74, 25);
            AdminReportsuserIdlabel.TabIndex = 2;
            AdminReportsuserIdlabel.Text = "User ID";
            // 
            // AdminReportsDateLabel
            // 
            AdminReportsDateLabel.AutoSize = true;
            AdminReportsDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AdminReportsDateLabel.Location = new Point(50, 107);
            AdminReportsDateLabel.Name = "AdminReportsDateLabel";
            AdminReportsDateLabel.Size = new Size(52, 25);
            AdminReportsDateLabel.TabIndex = 1;
            AdminReportsDateLabel.Text = "Date";
            // 
            // AdminReportsNameLabel
            // 
            AdminReportsNameLabel.AutoSize = true;
            AdminReportsNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AdminReportsNameLabel.Location = new Point(40, 13);
            AdminReportsNameLabel.Name = "AdminReportsNameLabel";
            AdminReportsNameLabel.Size = new Size(62, 25);
            AdminReportsNameLabel.TabIndex = 0;
            AdminReportsNameLabel.Text = "Name";
            // 
            // AdminDashboardConfirmOrderBoxpanel
            // 
            AdminDashboardConfirmOrderBoxpanel.BackColor = Color.SkyBlue;
            AdminDashboardConfirmOrderBoxpanel.BorderStyle = BorderStyle.Fixed3D;
            AdminDashboardConfirmOrderBoxpanel.Controls.Add(AdminReportsClickBoxLabel);
            AdminDashboardConfirmOrderBoxpanel.Controls.Add(AdminReportsSelectReportComboBox);
            AdminDashboardConfirmOrderBoxpanel.Controls.Add(AdminReportstartDateLabel);
            AdminDashboardConfirmOrderBoxpanel.Controls.Add(AdminReportStartDatePicker);
            AdminDashboardConfirmOrderBoxpanel.Controls.Add(AdminReportsSelectReportLabel);
            AdminDashboardConfirmOrderBoxpanel.Controls.Add(AdminReportGenerateReportButton);
            AdminDashboardConfirmOrderBoxpanel.Controls.Add(AdminReportEndDatePicker);
            AdminDashboardConfirmOrderBoxpanel.Controls.Add(AdminReportendDateLabel);
            AdminDashboardConfirmOrderBoxpanel.Location = new Point(50, 172);
            AdminDashboardConfirmOrderBoxpanel.Name = "AdminDashboardConfirmOrderBoxpanel";
            AdminDashboardConfirmOrderBoxpanel.Size = new Size(1054, 120);
            AdminDashboardConfirmOrderBoxpanel.TabIndex = 13;
            // 
            // AdminReportsClickBoxLabel
            // 
            AdminReportsClickBoxLabel.AutoSize = true;
            AdminReportsClickBoxLabel.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AdminReportsClickBoxLabel.Location = new Point(400, 78);
            AdminReportsClickBoxLabel.Name = "AdminReportsClickBoxLabel";
            AdminReportsClickBoxLabel.Size = new Size(358, 25);
            AdminReportsClickBoxLabel.TabIndex = 83;
            AdminReportsClickBoxLabel.Text = "Clicked tik boxs wil avoid the date range";
            // 
            // AdminReportEnterYourQuearyLabel
            // 
            AdminReportEnterYourQuearyLabel.AutoSize = true;
            AdminReportEnterYourQuearyLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AdminReportEnterYourQuearyLabel.Location = new Point(46, 3);
            AdminReportEnterYourQuearyLabel.Name = "AdminReportEnterYourQuearyLabel";
            AdminReportEnterYourQuearyLabel.Size = new Size(169, 25);
            AdminReportEnterYourQuearyLabel.TabIndex = 15;
            AdminReportEnterYourQuearyLabel.Text = "Enter your Queary";
            // 
            // AdminReportQuearyBox
            // 
            AdminReportQuearyBox.Location = new Point(18, 28);
            AdminReportQuearyBox.Margin = new Padding(4, 3, 4, 3);
            AdminReportQuearyBox.Multiline = true;
            AdminReportQuearyBox.Name = "AdminReportQuearyBox";
            AdminReportQuearyBox.ScrollBars = ScrollBars.Vertical;
            AdminReportQuearyBox.Size = new Size(704, 92);
            AdminReportQuearyBox.TabIndex = 81;
            // 
            // AdminReportButnPanel
            // 
            AdminReportButnPanel.BackColor = Color.Black;
            AdminReportButnPanel.Controls.Add(AdminReportsPDFcheckBox);
            AdminReportButnPanel.Controls.Add(AdminReportsCSVcheckBox);
            AdminReportButnPanel.Controls.Add(AdminReportClearBtn);
            AdminReportButnPanel.Controls.Add(AdminReportExitBtn);
            AdminReportButnPanel.Controls.Add(AdminReportDownloadReportButton);
            AdminReportButnPanel.Location = new Point(1157, 172);
            AdminReportButnPanel.Name = "AdminReportButnPanel";
            AdminReportButnPanel.Size = new Size(308, 258);
            AdminReportButnPanel.TabIndex = 82;
            // 
            // AdminReportsPDFcheckBox
            // 
            AdminReportsPDFcheckBox.AutoSize = true;
            AdminReportsPDFcheckBox.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminReportsPDFcheckBox.ForeColor = SystemColors.Control;
            AdminReportsPDFcheckBox.Location = new Point(130, 226);
            AdminReportsPDFcheckBox.Name = "AdminReportsPDFcheckBox";
            AdminReportsPDFcheckBox.Size = new Size(63, 29);
            AdminReportsPDFcheckBox.TabIndex = 48;
            AdminReportsPDFcheckBox.Text = "PDF";
            AdminReportsPDFcheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminReportsCSVcheckBox
            // 
            AdminReportsCSVcheckBox.AutoSize = true;
            AdminReportsCSVcheckBox.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminReportsCSVcheckBox.ForeColor = SystemColors.Control;
            AdminReportsCSVcheckBox.Location = new Point(130, 196);
            AdminReportsCSVcheckBox.Name = "AdminReportsCSVcheckBox";
            AdminReportsCSVcheckBox.Size = new Size(63, 29);
            AdminReportsCSVcheckBox.TabIndex = 47;
            AdminReportsCSVcheckBox.Text = "CSV";
            AdminReportsCSVcheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminReportClearBtn
            // 
            AdminReportClearBtn.BackColor = Color.DarkTurquoise;
            AdminReportClearBtn.BackgroundImageLayout = ImageLayout.None;
            AdminReportClearBtn.Font = new Font("Arial Narrow", 12.2264156F, FontStyle.Bold);
            AdminReportClearBtn.Location = new Point(52, 62);
            AdminReportClearBtn.Margin = new Padding(4, 3, 4, 3);
            AdminReportClearBtn.Name = "AdminReportClearBtn";
            AdminReportClearBtn.Size = new Size(219, 46);
            AdminReportClearBtn.TabIndex = 46;
            AdminReportClearBtn.Text = "Clear";
            AdminReportClearBtn.UseVisualStyleBackColor = false;
            AdminReportClearBtn.Click += AdminReportClearBtn_Click;
            // 
            // AdminReportExitBtn
            // 
            AdminReportExitBtn.BackColor = Color.Red;
            AdminReportExitBtn.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminReportExitBtn.ForeColor = SystemColors.InactiveCaptionText;
            AdminReportExitBtn.Location = new Point(52, 10);
            AdminReportExitBtn.Margin = new Padding(4, 3, 4, 3);
            AdminReportExitBtn.Name = "AdminReportExitBtn";
            AdminReportExitBtn.Size = new Size(219, 46);
            AdminReportExitBtn.TabIndex = 9;
            AdminReportExitBtn.Text = "Exit";
            AdminReportExitBtn.UseVisualStyleBackColor = false;
            AdminReportExitBtn.Click += AdminReportExitBtn_Click;
            // 
            // AdminReportQuareyPanel
            // 
            AdminReportQuareyPanel.BackColor = Color.DarkTurquoise;
            AdminReportQuareyPanel.BorderStyle = BorderStyle.Fixed3D;
            AdminReportQuareyPanel.Controls.Add(AdminReportGenerateReportQuearyButton);
            AdminReportQuareyPanel.Controls.Add(AdminReportEnterYourQuearyLabel);
            AdminReportQuareyPanel.Controls.Add(AdminReportQuearyBox);
            AdminReportQuareyPanel.Location = new Point(50, 298);
            AdminReportQuareyPanel.Name = "AdminReportQuareyPanel";
            AdminReportQuareyPanel.Size = new Size(1054, 132);
            AdminReportQuareyPanel.TabIndex = 84;
            // 
            // AdminReportGenerateReportQuearyButton
            // 
            AdminReportGenerateReportQuearyButton.BackColor = Color.Yellow;
            AdminReportGenerateReportQuearyButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            AdminReportGenerateReportQuearyButton.Image = (Image)resources.GetObject("AdminReportGenerateReportQuearyButton.Image");
            AdminReportGenerateReportQuearyButton.ImageAlign = ContentAlignment.MiddleLeft;
            AdminReportGenerateReportQuearyButton.Location = new Point(829, 41);
            AdminReportGenerateReportQuearyButton.Name = "AdminReportGenerateReportQuearyButton";
            AdminReportGenerateReportQuearyButton.Size = new Size(208, 59);
            AdminReportGenerateReportQuearyButton.TabIndex = 6;
            AdminReportGenerateReportQuearyButton.Text = "Generate Queary\r\nReport";
            AdminReportGenerateReportQuearyButton.TextAlign = ContentAlignment.MiddleRight;
            AdminReportGenerateReportQuearyButton.UseVisualStyleBackColor = false;
            AdminReportGenerateReportQuearyButton.Click += AdminReportGenerateReportQuearyButton_Click;
            // 
            // AdminReportDataGridView
            // 
            // Prevent adding and deleting rows
            AdminReportDataGridView.AllowUserToAddRows = false;
            AdminReportDataGridView.AllowUserToDeleteRows = false;

            // Make the DataGridView read-only
            AdminReportDataGridView.ReadOnly = true;

            // Set the alignment and wrap mode for alternating row styles
            DataGridViewCellStyle alternatingCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.TopLeft,
                WrapMode = DataGridViewTriState.True
            };
            AdminReportDataGridView.AlternatingRowsDefaultCellStyle = alternatingCellStyle;

            // Set background color
            AdminReportDataGridView.BackgroundColor = Color.LightSteelBlue;

            // Auto-size column headers based on content
            AdminReportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Enable wrapping and auto-size column height
            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle
            {
                WrapMode = DataGridViewTriState.True
            };
            AdminReportDataGridView.DefaultCellStyle = defaultCellStyle;
            AdminReportDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Set column header height
            AdminReportDataGridView.ColumnHeadersHeight = 25;

            // Set other properties for location, size, and appearance
            AdminReportDataGridView.Location = new Point(2, 436);
            AdminReportDataGridView.Size = new Size(1454, 374);
            AdminReportDataGridView.RowHeadersWidth = 45;

            // Optional: Enable sorting and filtering if these features are available
            AdminReportDataGridView.FilterAndSortEnabled = true;
            AdminReportDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            AdminReportDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;

            // Set additional properties if needed
            AdminReportDataGridView.RightToLeft = RightToLeft.No;
            AdminReportDataGridView.Name = "AdminReportDataGridView";
            AdminReportDataGridView.TabIndex = 85;

            // 
            // AdminReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1468, 822);
            Controls.Add(AdminReportDataGridView);
            Controls.Add(AdminReportQuareyPanel);
            Controls.Add(AdminReportButnPanel);
            Controls.Add(AdminDashboardConfirmOrderBoxpanel);
            Controls.Add(AdminDashboardConfirmOrderHeadingPanel);
            Name = "AdminReportsForm";
            Text = "Admin Reports";
            AdminDashboardConfirmOrderHeadingPanel.ResumeLayout(false);
            AdminDashboardConfirmOrderHeadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminReportLogoBox).EndInit();
            AdminDashboardConfirmOrderBoxpanel.ResumeLayout(false);
            AdminDashboardConfirmOrderBoxpanel.PerformLayout();
            AdminReportButnPanel.ResumeLayout(false);
            AdminReportButnPanel.PerformLayout();
            AdminReportQuareyPanel.ResumeLayout(false);
            AdminReportQuareyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminReportDataGridView).EndInit();
            ResumeLayout(false);
        }

        private Panel AdminDashboardConfirmOrderHeadingPanel;
        private TextBox AdminReportsNameBox;
        private TextBox AdminReportsUserIDBox;
        private TextBox AdminReportsDateBox;
        private PictureBox AdminReportLogoBox;
        private Label AdminReportsHeaderLabel1;
        private Label AdminReportsHeaderLable;
        private Label AdminReportsuserIdlabel;
        private Label AdminReportsDateLabel;
        private Label AdminReportsNameLabel;
        private Panel AdminDashboardConfirmOrderBoxpanel;
        private Label AdminReportEnterYourQuearyLabel;
        private TextBox AdminReportQuearyBox;
        private Panel AdminReportButnPanel;
        private Button AdminReportClearBtn;
        private Button AdminReportExitBtn;
        private Label AdminReportsClickBoxLabel;
        private Panel AdminReportQuareyPanel;
        private Button AdminReportGenerateReportQuearyButton;
        private CheckBox AdminReportsCSVcheckBox;
        private CheckBox AdminReportsPDFcheckBox;
        private Zuby.ADGV.AdvancedDataGridView AdminReportDataGridView;
    }
}
