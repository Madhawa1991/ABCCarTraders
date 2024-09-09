using System.Numerics;

namespace ABC_Car_Traders
{
    partial class AdminManageItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageItems));
            ManageItemSaveChangesButon = new Button();
            ManageItemDeleteBtn = new Button();
            ManageItemVehiclePartTex = new Label();
            ManageItemItemNameTex = new Label();
            ManageItemItemPriceTex = new Label();
            ManageItemItemBrandTex = new Label();
            ManageItemItemTypeTex = new Label();
            ManageItemItemPriceRangeTex = new Label();
            ManageItemItemConditionTex = new Label();
            ManageItemFuelTypeTex = new Label();
            ManageItemStatusTex = new Label();
            ManageItemMileageTex = new Label();
            ManageItemDescriptionTxt = new Label();
            ManageItemDescriptionBox = new TextBox();
            ManageItemPictureBox = new PictureBox();
            AdminManageItemChangePicButon = new Button();
            ManageItemModelYearTex = new Label();
            ManageItemItemCodeBox = new TextBox();
            AdminManageItemExitBtn = new Button();
            AddItemDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            AdminDashboardConfirmOrdeerPanel = new Panel();
            AdminDashboardNameBox = new TextBox();
            AdminDashboarduserIdBox = new TextBox();
            AdminDashboardDateBox = new TextBox();
            AdminDashboardLogoBox = new PictureBox();
            AdminDashboardDashboardLabel = new Label();
            AdminDashboardHomeLable = new Label();
            AdminDashboarduserIdlabel = new Label();
            AdminDashboardDateLabel = new Label();
            AdminDashboardNameLabel = new Label();
            AdminManageCustomerButtonPanel = new Panel();
            AdminManageItemClearBtn = new Button();
            CustomerFavorioteSearchImage = new PictureBox();
            AdminItemSearchBox = new TextBox();
            AdminManageItemGridView = new Zuby.ADGV.AdvancedDataGridView();
            ManageItemItemNameBox = new TextBox();
            ManageItemVehiclePartBox = new ComboBox();
            ManageItemBrandBox = new ComboBox();
            ManageItemItemTypeBox = new ComboBox();
            ManageItemPriceRangeBox = new ComboBox();
            ManageItemFuelTypeBox = new ComboBox();
            ManageItemStatusBox = new ComboBox();
            ManageItemConditionBox = new ComboBox();
            ManageItemMileageBox = new TextBox();
            ManageItemModelYearBox = new NumericUpDown();
            ManageItemItemPriceBox = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)ManageItemPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddItemDataGridView).BeginInit();
            AdminDashboardConfirmOrdeerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminDashboardLogoBox).BeginInit();
            AdminManageCustomerButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerFavorioteSearchImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminManageItemGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ManageItemModelYearBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ManageItemItemPriceBox).BeginInit();
            SuspendLayout();
            // 
            // ManageItemSaveChangesButon
            // 
            ManageItemSaveChangesButon.BackColor = Color.Green;
            ManageItemSaveChangesButon.Location = new Point(48, 180);
            ManageItemSaveChangesButon.Name = "ManageItemSaveChangesButon";
            ManageItemSaveChangesButon.Size = new Size(227, 42);
            ManageItemSaveChangesButon.TabIndex = 2;
            ManageItemSaveChangesButon.Text = "Save Changes";
            ManageItemSaveChangesButon.UseVisualStyleBackColor = false;
            ManageItemSaveChangesButon.Click += ManageItemEditButon_Click;
            // 
            // ManageItemDeleteBtn
            // 
            ManageItemDeleteBtn.BackColor = SystemColors.ActiveCaptionText;
            ManageItemDeleteBtn.ForeColor = Color.White;
            ManageItemDeleteBtn.Location = new Point(48, 106);
            ManageItemDeleteBtn.Name = "ManageItemDeleteBtn";
            ManageItemDeleteBtn.Size = new Size(227, 45);
            ManageItemDeleteBtn.TabIndex = 3;
            ManageItemDeleteBtn.Text = "Delete";
            ManageItemDeleteBtn.UseVisualStyleBackColor = false;
            ManageItemDeleteBtn.Click += ManageItemDeleteBtn_Click;
            // 
            // ManageItemVehiclePartTex
            // 
            ManageItemVehiclePartTex.AutoSize = true;
            ManageItemVehiclePartTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemVehiclePartTex.Location = new Point(45, 180);
            ManageItemVehiclePartTex.Name = "ManageItemVehiclePartTex";
            ManageItemVehiclePartTex.Size = new Size(94, 20);
            ManageItemVehiclePartTex.TabIndex = 4;
            ManageItemVehiclePartTex.Text = "Vehicle/Part";
            // 
            // ManageItemItemNameTex
            // 
            ManageItemItemNameTex.AutoSize = true;
            ManageItemItemNameTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemItemNameTex.Location = new Point(88, 213);
            ManageItemItemNameTex.Name = "ManageItemItemNameTex";
            ManageItemItemNameTex.Size = new Size(49, 25);
            ManageItemItemNameTex.TabIndex = 7;
            ManageItemItemNameTex.Text = "Name";
            ManageItemItemNameTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemPriceTex
            // 
            ManageItemItemPriceTex.AutoSize = true;
            ManageItemItemPriceTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemItemPriceTex.Location = new Point(97, 246);
            ManageItemItemPriceTex.Name = "ManageItemItemPriceTex";
            ManageItemItemPriceTex.Size = new Size(41, 25);
            ManageItemItemPriceTex.TabIndex = 8;
            ManageItemItemPriceTex.Text = "Price";
            ManageItemItemPriceTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemBrandTex
            // 
            ManageItemItemBrandTex.AutoSize = true;
            ManageItemItemBrandTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemItemBrandTex.Location = new Point(89, 322);
            ManageItemItemBrandTex.Name = "ManageItemItemBrandTex";
            ManageItemItemBrandTex.Size = new Size(49, 25);
            ManageItemItemBrandTex.TabIndex = 10;
            ManageItemItemBrandTex.Text = "Brand";
            ManageItemItemBrandTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemTypeTex
            // 
            ManageItemItemTypeTex.AutoSize = true;
            ManageItemItemTypeTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemItemTypeTex.Location = new Point(97, 355);
            ManageItemItemTypeTex.Name = "ManageItemItemTypeTex";
            ManageItemItemTypeTex.Size = new Size(41, 25);
            ManageItemItemTypeTex.TabIndex = 12;
            ManageItemItemTypeTex.Text = "Type";
            ManageItemItemTypeTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemPriceRangeTex
            // 
            ManageItemItemPriceRangeTex.AutoSize = true;
            ManageItemItemPriceRangeTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemItemPriceRangeTex.Location = new Point(46, 388);
            ManageItemItemPriceRangeTex.Name = "ManageItemItemPriceRangeTex";
            ManageItemItemPriceRangeTex.Size = new Size(91, 25);
            ManageItemItemPriceRangeTex.TabIndex = 14;
            ManageItemItemPriceRangeTex.Text = "Price Range";
            ManageItemItemPriceRangeTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemConditionTex
            // 
            ManageItemItemConditionTex.AutoSize = true;
            ManageItemItemConditionTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemItemConditionTex.Location = new Point(485, 180);
            ManageItemItemConditionTex.Name = "ManageItemItemConditionTex";
            ManageItemItemConditionTex.Size = new Size(77, 25);
            ManageItemItemConditionTex.TabIndex = 16;
            ManageItemItemConditionTex.Text = "Condition";
            ManageItemItemConditionTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemFuelTypeTex
            // 
            ManageItemFuelTypeTex.AutoSize = true;
            ManageItemFuelTypeTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemFuelTypeTex.Location = new Point(484, 225);
            ManageItemFuelTypeTex.Name = "ManageItemFuelTypeTex";
            ManageItemFuelTypeTex.Size = new Size(75, 25);
            ManageItemFuelTypeTex.TabIndex = 18;
            ManageItemFuelTypeTex.Text = "Fuel Type";
            ManageItemFuelTypeTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemStatusTex
            // 
            ManageItemStatusTex.AutoSize = true;
            ManageItemStatusTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemStatusTex.Location = new Point(510, 267);
            ManageItemStatusTex.Name = "ManageItemStatusTex";
            ManageItemStatusTex.Size = new Size(52, 25);
            ManageItemStatusTex.TabIndex = 20;
            ManageItemStatusTex.Text = "Stutus";
            ManageItemStatusTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemMileageTex
            // 
            ManageItemMileageTex.AutoSize = true;
            ManageItemMileageTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemMileageTex.Location = new Point(460, 312);
            ManageItemMileageTex.Name = "ManageItemMileageTex";
            ManageItemMileageTex.Size = new Size(99, 25);
            ManageItemMileageTex.TabIndex = 22;
            ManageItemMileageTex.Text = "Mileage   km";
            ManageItemMileageTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemDescriptionTxt
            // 
            ManageItemDescriptionTxt.AutoSize = true;
            ManageItemDescriptionTxt.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemDescriptionTxt.Location = new Point(470, 371);
            ManageItemDescriptionTxt.Name = "ManageItemDescriptionTxt";
            ManageItemDescriptionTxt.Size = new Size(89, 25);
            ManageItemDescriptionTxt.TabIndex = 24;
            ManageItemDescriptionTxt.Text = "Descriotion";
            ManageItemDescriptionTxt.UseCompatibleTextRendering = true;
            // 
            // ManageItemDescriptionBox
            // 
            ManageItemDescriptionBox.Location = new Point(572, 352);
            ManageItemDescriptionBox.Multiline = true;
            ManageItemDescriptionBox.Name = "ManageItemDescriptionBox";
            ManageItemDescriptionBox.ScrollBars = ScrollBars.Vertical;
            ManageItemDescriptionBox.Size = new Size(268, 73);
            ManageItemDescriptionBox.TabIndex = 25;
            // 
            // ManageItemPictureBox
            // 
            ManageItemPictureBox.BackColor = Color.LightSteelBlue;
            ManageItemPictureBox.BorderStyle = BorderStyle.Fixed3D;
            ManageItemPictureBox.Image = Properties.Resources.ImageCar;
            ManageItemPictureBox.Location = new Point(900, 195);
            ManageItemPictureBox.Name = "ManageItemPictureBox";
            ManageItemPictureBox.Size = new Size(370, 255);
            ManageItemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ManageItemPictureBox.TabIndex = 28;
            ManageItemPictureBox.TabStop = false;
            // 
            // AdminManageItemChangePicButon
            // 
            AdminManageItemChangePicButon.Location = new Point(1036, 456);
            AdminManageItemChangePicButon.Name = "AdminManageItemChangePicButon";
            AdminManageItemChangePicButon.Size = new Size(168, 35);
            AdminManageItemChangePicButon.TabIndex = 29;
            AdminManageItemChangePicButon.Text = "Change Picture";
            AdminManageItemChangePicButon.UseVisualStyleBackColor = true;
            AdminManageItemChangePicButon.Click += AdminManageItemChangePicButon_Click_1;
            // 
            // ManageItemModelYearTex
            // 
            ManageItemModelYearTex.AutoSize = true;
            ManageItemModelYearTex.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            ManageItemModelYearTex.Location = new Point(50, 279);
            ManageItemModelYearTex.Name = "ManageItemModelYearTex";
            ManageItemModelYearTex.Size = new Size(88, 25);
            ManageItemModelYearTex.TabIndex = 31;
            ManageItemModelYearTex.Text = "Model Year";
            ManageItemModelYearTex.UseCompatibleTextRendering = true;
            // 
            // ManageItemItemCodeBox
            // 
            ManageItemItemCodeBox.BackColor = Color.LightSteelBlue;
            ManageItemItemCodeBox.BorderStyle = BorderStyle.None;
            ManageItemItemCodeBox.Location = new Point(952, 169);
            ManageItemItemCodeBox.Name = "ManageItemItemCodeBox";
            ManageItemItemCodeBox.ReadOnly = true;
            ManageItemItemCodeBox.Size = new Size(269, 20);
            ManageItemItemCodeBox.TabIndex = 32;
            ManageItemItemCodeBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AdminManageItemExitBtn
            // 
            AdminManageItemExitBtn.BackColor = Color.Red;
            AdminManageItemExitBtn.Location = new Point(48, 35);
            AdminManageItemExitBtn.Name = "AdminManageItemExitBtn";
            AdminManageItemExitBtn.Size = new Size(227, 44);
            AdminManageItemExitBtn.TabIndex = 44;
            AdminManageItemExitBtn.Text = "Exit";
            AdminManageItemExitBtn.UseVisualStyleBackColor = false;
            AdminManageItemExitBtn.Click += AdminManageItemExitBtn_Click;
            // 
            // AddItemDataGridView
            // 
            AddItemDataGridView.ColumnHeadersHeight = 25;
            AddItemDataGridView.FilterAndSortEnabled = true;
            AddItemDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            AddItemDataGridView.Location = new Point(0, 0);
            AddItemDataGridView.MaxFilterButtonImageHeight = 23;
            AddItemDataGridView.Name = "AddItemDataGridView";
            AddItemDataGridView.RightToLeft = RightToLeft.No;
            AddItemDataGridView.RowHeadersWidth = 45;
            AddItemDataGridView.Size = new Size(240, 150);
            AddItemDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            AddItemDataGridView.TabIndex = 82;
            // 
            // AdminDashboardConfirmOrdeerPanel
            // 
            AdminDashboardConfirmOrdeerPanel.BackColor = Color.LightSteelBlue;
            AdminDashboardConfirmOrdeerPanel.BorderStyle = BorderStyle.Fixed3D;
            AdminDashboardConfirmOrdeerPanel.Controls.Add(AdminDashboardNameBox);
            AdminDashboardConfirmOrdeerPanel.Controls.Add(AdminDashboarduserIdBox);
            AdminDashboardConfirmOrdeerPanel.Controls.Add(AdminDashboardDateBox);
            AdminDashboardConfirmOrdeerPanel.Controls.Add(AdminDashboardLogoBox);
            AdminDashboardConfirmOrdeerPanel.Controls.Add(AdminDashboardDashboardLabel);
            AdminDashboardConfirmOrdeerPanel.Controls.Add(AdminDashboardHomeLable);
            AdminDashboardConfirmOrdeerPanel.Controls.Add(AdminDashboarduserIdlabel);
            AdminDashboardConfirmOrdeerPanel.Controls.Add(AdminDashboardDateLabel);
            AdminDashboardConfirmOrdeerPanel.Controls.Add(AdminDashboardNameLabel);
            AdminDashboardConfirmOrdeerPanel.Location = new Point(2, -3);
            AdminDashboardConfirmOrdeerPanel.Name = "AdminDashboardConfirmOrdeerPanel";
            AdminDashboardConfirmOrdeerPanel.Size = new Size(1622, 166);
            AdminDashboardConfirmOrdeerPanel.TabIndex = 53;
            // 
            // AdminDashboardNameBox
            // 
            AdminDashboardNameBox.BackColor = Color.LightSteelBlue;
            AdminDashboardNameBox.BorderStyle = BorderStyle.None;
            AdminDashboardNameBox.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AdminDashboardNameBox.Location = new Point(122, 14);
            AdminDashboardNameBox.Name = "AdminDashboardNameBox";
            AdminDashboardNameBox.Size = new Size(253, 24);
            AdminDashboardNameBox.TabIndex = 13;
            // 
            // AdminDashboarduserIdBox
            // 
            AdminDashboarduserIdBox.BackColor = Color.LightSteelBlue;
            AdminDashboarduserIdBox.BorderStyle = BorderStyle.None;
            AdminDashboarduserIdBox.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AdminDashboarduserIdBox.Location = new Point(122, 58);
            AdminDashboarduserIdBox.Name = "AdminDashboarduserIdBox";
            AdminDashboarduserIdBox.Size = new Size(210, 24);
            AdminDashboarduserIdBox.TabIndex = 12;
            // 
            // AdminDashboardDateBox
            // 
            AdminDashboardDateBox.BackColor = Color.LightSteelBlue;
            AdminDashboardDateBox.BorderStyle = BorderStyle.None;
            AdminDashboardDateBox.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AdminDashboardDateBox.Location = new Point(122, 107);
            AdminDashboardDateBox.Name = "AdminDashboardDateBox";
            AdminDashboardDateBox.Size = new Size(210, 24);
            AdminDashboardDateBox.TabIndex = 11;
            // 
            // AdminDashboardLogoBox
            // 
            AdminDashboardLogoBox.BackColor = Color.Black;
            AdminDashboardLogoBox.Image = (Image)resources.GetObject("AdminDashboardLogoBox.Image");
            AdminDashboardLogoBox.Location = new Point(1305, -19);
            AdminDashboardLogoBox.Name = "AdminDashboardLogoBox";
            AdminDashboardLogoBox.Size = new Size(317, 196);
            AdminDashboardLogoBox.SizeMode = PictureBoxSizeMode.Zoom;
            AdminDashboardLogoBox.TabIndex = 5;
            AdminDashboardLogoBox.TabStop = false;
            // 
            // AdminDashboardDashboardLabel
            // 
            AdminDashboardDashboardLabel.BackColor = Color.Transparent;
            AdminDashboardDashboardLabel.Font = new Font("Perpetua", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminDashboardDashboardLabel.ForeColor = Color.Blue;
            AdminDashboardDashboardLabel.Location = new Point(506, 75);
            AdminDashboardDashboardLabel.Name = "AdminDashboardDashboardLabel";
            AdminDashboardDashboardLabel.Size = new Size(467, 75);
            AdminDashboardDashboardLabel.TabIndex = 4;
            AdminDashboardDashboardLabel.Text = "Admin Manage Item";
            AdminDashboardDashboardLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminDashboardHomeLable
            // 
            AdminDashboardHomeLable.BackColor = Color.Transparent;
            AdminDashboardHomeLable.Font = new Font("Perpetua", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminDashboardHomeLable.ForeColor = Color.Red;
            AdminDashboardHomeLable.Location = new Point(398, 0);
            AdminDashboardHomeLable.Name = "AdminDashboardHomeLable";
            AdminDashboardHomeLable.Size = new Size(696, 75);
            AdminDashboardHomeLable.TabIndex = 3;
            AdminDashboardHomeLable.Text = "ABC Car Traders PVT";
            AdminDashboardHomeLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminDashboarduserIdlabel
            // 
            AdminDashboarduserIdlabel.AutoSize = true;
            AdminDashboarduserIdlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AdminDashboarduserIdlabel.Location = new Point(38, 58);
            AdminDashboarduserIdlabel.Name = "AdminDashboarduserIdlabel";
            AdminDashboarduserIdlabel.Size = new Size(74, 25);
            AdminDashboarduserIdlabel.TabIndex = 2;
            AdminDashboarduserIdlabel.Text = "User ID";
            // 
            // AdminDashboardDateLabel
            // 
            AdminDashboardDateLabel.AutoSize = true;
            AdminDashboardDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AdminDashboardDateLabel.Location = new Point(56, 107);
            AdminDashboardDateLabel.Name = "AdminDashboardDateLabel";
            AdminDashboardDateLabel.Size = new Size(52, 25);
            AdminDashboardDateLabel.TabIndex = 1;
            AdminDashboardDateLabel.Text = "Date";
            // 
            // AdminDashboardNameLabel
            // 
            AdminDashboardNameLabel.AutoSize = true;
            AdminDashboardNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AdminDashboardNameLabel.Location = new Point(45, 13);
            AdminDashboardNameLabel.Name = "AdminDashboardNameLabel";
            AdminDashboardNameLabel.Size = new Size(62, 25);
            AdminDashboardNameLabel.TabIndex = 0;
            AdminDashboardNameLabel.Text = "Name";
            // 
            // AdminManageCustomerButtonPanel
            // 
            AdminManageCustomerButtonPanel.BackColor = Color.Black;
            AdminManageCustomerButtonPanel.Controls.Add(AdminManageItemClearBtn);
            AdminManageCustomerButtonPanel.Controls.Add(AdminManageItemExitBtn);
            AdminManageCustomerButtonPanel.Controls.Add(ManageItemDeleteBtn);
            AdminManageCustomerButtonPanel.Controls.Add(ManageItemSaveChangesButon);
            AdminManageCustomerButtonPanel.Location = new Point(1309, 164);
            AdminManageCustomerButtonPanel.Name = "AdminManageCustomerButtonPanel";
            AdminManageCustomerButtonPanel.Size = new Size(317, 332);
            AdminManageCustomerButtonPanel.TabIndex = 54;
            // 
            // AdminManageItemClearBtn
            // 
            AdminManageItemClearBtn.BackColor = Color.DarkTurquoise;
            AdminManageItemClearBtn.Location = new Point(48, 248);
            AdminManageItemClearBtn.Name = "AdminManageItemClearBtn";
            AdminManageItemClearBtn.Size = new Size(227, 42);
            AdminManageItemClearBtn.TabIndex = 45;
            AdminManageItemClearBtn.Text = "Clear";
            AdminManageItemClearBtn.UseVisualStyleBackColor = false;
            AdminManageItemClearBtn.Click += AdminManageItemClearBtn_Click;
            // 
            // CustomerFavorioteSearchImage
            // 
            CustomerFavorioteSearchImage.Image = Properties.Resources.Search_Car;
            CustomerFavorioteSearchImage.Location = new Point(701, 437);
            CustomerFavorioteSearchImage.Margin = new Padding(4, 3, 4, 3);
            CustomerFavorioteSearchImage.Name = "CustomerFavorioteSearchImage";
            CustomerFavorioteSearchImage.Size = new Size(96, 54);
            CustomerFavorioteSearchImage.SizeMode = PictureBoxSizeMode.Zoom;
            CustomerFavorioteSearchImage.TabIndex = 81;
            CustomerFavorioteSearchImage.TabStop = false;
            // 
            // AdminItemSearchBox
            // 
            AdminItemSearchBox.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AdminItemSearchBox.Location = new Point(212, 452);
            AdminItemSearchBox.Name = "AdminItemSearchBox";
            AdminItemSearchBox.Size = new Size(482, 35);
            AdminItemSearchBox.TabIndex = 80;
            // 
            // AdminManageItemGridView
            // 
            AdminManageItemGridView.BackgroundColor = Color.LightSteelBlue;
            AdminManageItemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminManageItemGridView.FilterAndSortEnabled = true;
            AdminManageItemGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            AdminManageItemGridView.Location = new Point(0, 497);
            AdminManageItemGridView.MaxFilterButtonImageHeight = 23;
            AdminManageItemGridView.Name = "AdminManageItemGridView";
            AdminManageItemGridView.ReadOnly = true;
            AdminManageItemGridView.RightToLeft = RightToLeft.No;
            AdminManageItemGridView.RowHeadersWidth = 45;
            AdminManageItemGridView.Size = new Size(1624, 253);
            AdminManageItemGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            AdminManageItemGridView.TabIndex = 83;
            // 
            // ManageItemItemNameBox
            // 
            ManageItemItemNameBox.Location = new Point(151, 213);
            ManageItemItemNameBox.Name = "ManageItemItemNameBox";
            ManageItemItemNameBox.Size = new Size(268, 27);
            ManageItemItemNameBox.TabIndex = 6;
            // 
            // ManageItemVehiclePartBox
            // 
            ManageItemVehiclePartBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ManageItemVehiclePartBox.FormattingEnabled = true;
            ManageItemVehiclePartBox.Items.AddRange(new object[] { "Vehicle", "Part" });
            ManageItemVehiclePartBox.Location = new Point(151, 177);
            ManageItemVehiclePartBox.Name = "ManageItemVehiclePartBox";
            ManageItemVehiclePartBox.Size = new Size(267, 28);
            ManageItemVehiclePartBox.TabIndex = 33;
            // 
            // ManageItemBrandBox
            // 
            ManageItemBrandBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ManageItemBrandBox.FormattingEnabled = true;
            ManageItemBrandBox.Items.AddRange(new object[] { "Toyota", "Honda", "Tata", "Ford", "BMW", "Audi", "Nissan", "Suzuki", "Jaguar", "Subaru", "Mazda" });
            ManageItemBrandBox.Location = new Point(151, 318);
            ManageItemBrandBox.Name = "ManageItemBrandBox";
            ManageItemBrandBox.Size = new Size(267, 28);
            ManageItemBrandBox.TabIndex = 33;
            // 
            // ManageItemItemTypeBox
            // 
            ManageItemItemTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ManageItemItemTypeBox.FormattingEnabled = true;
            ManageItemItemTypeBox.Items.AddRange(new object[] { "Car", "Van", "Bus", "Lorry" });
            ManageItemItemTypeBox.Location = new Point(151, 352);
            ManageItemItemTypeBox.Name = "ManageItemItemTypeBox";
            ManageItemItemTypeBox.Size = new Size(268, 28);
            ManageItemItemTypeBox.TabIndex = 33;
            // 
            // ManageItemPriceRangeBox
            // 
            ManageItemPriceRangeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ManageItemPriceRangeBox.FormattingEnabled = true;
            ManageItemPriceRangeBox.Items.AddRange(new object[] { "1-10,000", "10,001-50,000", "50,001-100,000", "100,001-250,000", "250,001-500,000", "500,001-1,000,001", "1,000,001-2,500,000", "2,500,001-5,000,000", "5,000,001-10,000,000", "10,000,001-50,000,000", "50,000,000<" });
            ManageItemPriceRangeBox.Location = new Point(150, 397);
            ManageItemPriceRangeBox.Name = "ManageItemPriceRangeBox";
            ManageItemPriceRangeBox.Size = new Size(268, 28);
            ManageItemPriceRangeBox.TabIndex = 84;
            // 
            // ManageItemFuelTypeBox
            // 
            ManageItemFuelTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ManageItemFuelTypeBox.FormattingEnabled = true;
            ManageItemFuelTypeBox.Items.AddRange(new object[] { "Petrol", "Diesel", "Hybrid", "Eletric" });
            ManageItemFuelTypeBox.Location = new Point(573, 222);
            ManageItemFuelTypeBox.Name = "ManageItemFuelTypeBox";
            ManageItemFuelTypeBox.Size = new Size(268, 28);
            ManageItemFuelTypeBox.TabIndex = 85;
            // 
            // ManageItemStatusBox
            // 
            ManageItemStatusBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ManageItemStatusBox.FormattingEnabled = true;
            ManageItemStatusBox.Items.AddRange(new object[] { "Available", "Reserved", "Sold" });
            ManageItemStatusBox.Location = new Point(572, 267);
            ManageItemStatusBox.Name = "ManageItemStatusBox";
            ManageItemStatusBox.Size = new Size(268, 28);
            ManageItemStatusBox.TabIndex = 86;
            // 
            // ManageItemConditionBox
            // 
            ManageItemConditionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ManageItemConditionBox.FormattingEnabled = true;
            ManageItemConditionBox.Items.AddRange(new object[] { "Brand New", "Used" });
            ManageItemConditionBox.Location = new Point(572, 177);
            ManageItemConditionBox.Name = "ManageItemConditionBox";
            ManageItemConditionBox.Size = new Size(268, 28);
            ManageItemConditionBox.TabIndex = 87;
            // 
            // ManageItemMileageBox
            // 
            ManageItemMileageBox.Location = new Point(572, 308);
            ManageItemMileageBox.Name = "ManageItemMileageBox";
            ManageItemMileageBox.Size = new Size(268, 27);
            ManageItemMileageBox.TabIndex = 23;
            // 
            // ManageItemModelYearBox
            // 
            ManageItemModelYearBox.Location = new Point(150, 280);
            ManageItemModelYearBox.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            ManageItemModelYearBox.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            ManageItemModelYearBox.Name = "ManageItemModelYearBox";
            ManageItemModelYearBox.Size = new Size(141, 27);
            ManageItemModelYearBox.TabIndex = 89;
            ManageItemModelYearBox.Value = new decimal(new int[] { 1970, 0, 0, 0 });
            // 
            // ManageItemItemPriceBox
            // 
            ManageItemItemPriceBox.DecimalPlaces = 2;
            ManageItemItemPriceBox.Location = new Point(151, 246);
            ManageItemItemPriceBox.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            ManageItemItemPriceBox.Name = "ManageItemItemPriceBox";
            ManageItemItemPriceBox.Size = new Size(140, 27);
            ManageItemItemPriceBox.TabIndex = 88;
            // 
            // AdminManageItems
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1626, 750);
            ControlBox = false;
            Controls.Add(ManageItemModelYearBox);
            Controls.Add(ManageItemItemPriceBox);
            Controls.Add(ManageItemStatusBox);
            Controls.Add(ManageItemFuelTypeBox);
            Controls.Add(ManageItemPriceRangeBox);
            Controls.Add(ManageItemItemTypeBox);
            Controls.Add(ManageItemConditionBox);
            Controls.Add(ManageItemBrandBox);
            Controls.Add(ManageItemVehiclePartBox);
            Controls.Add(ManageItemItemCodeBox);
            Controls.Add(AdminManageItemGridView);
            Controls.Add(CustomerFavorioteSearchImage);
            Controls.Add(AdminItemSearchBox);
            Controls.Add(AdminManageItemChangePicButon);
            Controls.Add(AdminManageCustomerButtonPanel);
            Controls.Add(AdminDashboardConfirmOrdeerPanel);
            Controls.Add(AddItemDataGridView);
            Controls.Add(ManageItemModelYearTex);
            Controls.Add(ManageItemPictureBox);
            Controls.Add(ManageItemDescriptionBox);
            Controls.Add(ManageItemDescriptionTxt);
            Controls.Add(ManageItemMileageBox);
            Controls.Add(ManageItemMileageTex);
            Controls.Add(ManageItemStatusTex);
            Controls.Add(ManageItemFuelTypeTex);
            Controls.Add(ManageItemItemConditionTex);
            Controls.Add(ManageItemItemPriceRangeTex);
            Controls.Add(ManageItemItemTypeTex);
            Controls.Add(ManageItemItemBrandTex);
            Controls.Add(ManageItemItemPriceTex);
            Controls.Add(ManageItemItemNameTex);
            Controls.Add(ManageItemItemNameBox);
            Controls.Add(ManageItemVehiclePartTex);
            Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminManageItems";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminManageItems";
            ((System.ComponentModel.ISupportInitialize)ManageItemPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddItemDataGridView).EndInit();
            AdminDashboardConfirmOrdeerPanel.ResumeLayout(false);
            AdminDashboardConfirmOrdeerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminDashboardLogoBox).EndInit();
            AdminManageCustomerButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomerFavorioteSearchImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminManageItemGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ManageItemModelYearBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ManageItemItemPriceBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ManageItemSaveChangesButon;
        private Button ManageItemDeleteBtn;
        private Label ManageItemVehiclePartTex;
        private Label ManageItemItemNameTex;
        private Label ManageItemItemPriceTex;
        private Label ManageItemItemBrandTex;
        private Label ManageItemItemTypeTex;
        private Label ManageItemItemPriceRangeTex;
        private Label ManageItemItemConditionTex;
        private Label ManageItemFuelTypeTex;
        private Label ManageItemStatusTex;
        private Label ManageItemMileageTex;
        private Label ManageItemDescriptionTxt;
        private TextBox ManageItemDescriptionBox;
        private PictureBox ManageItemPictureBox;
        private Button AdminManageItemChangePicButon;
        private Label ManageItemModelYearTex;
        private TextBox ManageItemItemCodeBox;
        private Button AdminManageItemExitBtn;
       // private Zuby.ADGV.AdvancedDataGridView AddItemDataGridView;
        private Panel AdminDashboardConfirmOrdeerPanel;
        private TextBox AdminDashboardNameBox;
        private TextBox AdminDashboarduserIdBox;
        private TextBox AdminDashboardDateBox;
        private PictureBox AdminDashboardLogoBox;
        private Label AdminDashboardDashboardLabel;
        private Label AdminDashboardHomeLable;
        private Label AdminDashboarduserIdlabel;
        private Label AdminDashboardDateLabel;
        private Label AdminDashboardNameLabel;
        private Panel AdminManageCustomerButtonPanel;
        private PictureBox CustomerFavorioteSearchImage;
        private TextBox AdminItemSearchBox;
        private Zuby.ADGV.AdvancedDataGridView AdminManageItemGridView;
        private Zuby.ADGV.AdvancedDataGridView AddItemDataGridView;
        private Button AdminManageItemClearBtn;
        private TextBox ManageItemItemNameBox;
        private ComboBox ManageItemVehiclePartBox;
        private ComboBox ManageItemBrandBox;
        private ComboBox ManageItemItemTypeBox;
        private ComboBox ManageItemStatusBox;
        private ComboBox ManageItemPriceRangeBox;
        private ComboBox ManageItemFuelTypeBox;
        private ComboBox ManageItemConditionBox;
        private TextBox ManageItemMileageBox;
        private NumericUpDown ManageItemModelYearBox;
        private NumericUpDown ManageItemItemPriceBox;
    }
}
