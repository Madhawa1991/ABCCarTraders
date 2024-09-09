namespace ABC_Car_Traders
{
    partial class AdminAddItem
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
            AddItemNameBox = new TextBox();
            AddItemPriceBox = new NumericUpDown();
            AddItemModelYearBox = new NumericUpDown();
            AddItemBrandNamecmb = new ComboBox();
            AddItemTypecmb = new ComboBox();
            AddItemPriceRangecmb = new ComboBox();
            AddItemConditioncmb = new ComboBox();
            AddItemFuelTypecmb = new ComboBox();
            AddItemStatuscmb = new ComboBox();
            AddItemMileageBoxcmb = new NumericUpDown();
            AddItemSaveButton = new Button();
            AddItemCanselBtn = new Button();
            AddItemVehicleradioButton = new RadioButton();
            AddItemPartRadioButton = new RadioButton();
            AddItemNameTex = new Label();
            AddItemPriceTxt = new Label();
            AddItemYearTex = new Label();
            AddItemBrandTex = new Label();
            AddItemTypeTex = new Label();
            AddItemPriceRangeTex = new Label();
            AddItemConditionTex = new Label();
            AddItemFuelTex = new Label();
            AddItemStatusTex = new Label();
            AddItemMiageTex = new Label();
            AddItemPicUploadbtn = new Button();
            AddItempicture = new PictureBox();
            AddItemDescriptionTxt = new Label();
            AddItemDescriptionBox = new TextBox();
            AddItemClearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AddItemPriceBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddItemModelYearBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddItemMileageBoxcmb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddItempicture).BeginInit();
            SuspendLayout();
            // 
            // AddItemNameBox
            // 
            AddItemNameBox.Location = new Point(149, 75);
            AddItemNameBox.Name = "AddItemNameBox";
            AddItemNameBox.PlaceholderText = "Item Name";
            AddItemNameBox.Size = new Size(362, 27);
            AddItemNameBox.TabIndex = 1;
            // 
            // AddItemPriceBox
            // 
            AddItemPriceBox.DecimalPlaces = 2;
            AddItemPriceBox.Location = new Point(150, 110);
            AddItemPriceBox.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            AddItemPriceBox.Name = "AddItemPriceBox";
            AddItemPriceBox.Size = new Size(200, 27);
            AddItemPriceBox.TabIndex = 2;
            // 
            // AddItemModelYearBox
            // 
            AddItemModelYearBox.Location = new Point(149, 152);
            AddItemModelYearBox.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            AddItemModelYearBox.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            AddItemModelYearBox.Name = "AddtemModelYearBox";
            AddItemModelYearBox.Size = new Size(200, 27);
            AddItemModelYearBox.TabIndex = 3;
            AddItemModelYearBox.Value = new decimal(new int[] { 1970, 0, 0, 0 });
            // 
            // AddItemBrandNamecmb
            // 
            AddItemBrandNamecmb.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemBrandNamecmb.Items.AddRange(new object[] { "Toyota", "Honda", "Tata", "Ford", "BMW", "Audi", "Nissan", "Suzuki", "Jaguar", "Subaru", "Mazda" });
            AddItemBrandNamecmb.Location = new Point(149, 193);
            AddItemBrandNamecmb.Name = "AddItemBrandNamecmb";
            AddItemBrandNamecmb.Size = new Size(200, 28);
            AddItemBrandNamecmb.TabIndex = 4;
            // 
            // AddItemTypecmb
            // 
            AddItemTypecmb.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemTypecmb.Items.AddRange(new object[] { "Car", "Van", "Bus", "Lorry" });
            AddItemTypecmb.Location = new Point(149, 234);
            AddItemTypecmb.Name = "AddItemTypecmb";
            AddItemTypecmb.Size = new Size(200, 28);
            AddItemTypecmb.TabIndex = 5;
            // 
            // AddItemPriceRangecmb
            // 
            AddItemPriceRangecmb.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemPriceRangecmb.Items.AddRange(new object[] { "1-10,000", "10,001-50,000", "50,001-100,000", "100,001-250,000", "250,001-500,000",
                "500,001-1,000,001", "1,000,001-2,500,000", "2,500,001-5,000,000", "5,000,001-10,000,000", "10,000,001-50,000,000", "50,000,000<" });
            AddItemPriceRangecmb.Location = new Point(149, 277);
            AddItemPriceRangecmb.Name = "AddItemPriceRangecmb";
            AddItemPriceRangecmb.Size = new Size(200, 28);
            AddItemPriceRangecmb.TabIndex = 6;
            // 
            // AddItemConditioncmb
            // 
            AddItemConditioncmb.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemConditioncmb.Items.AddRange(new object[] { "Brand New", "Used" });
            AddItemConditioncmb.Location = new Point(149, 321);
            AddItemConditioncmb.Name = "AddItemConditioncmb";
            AddItemConditioncmb.Size = new Size(200, 28);
            AddItemConditioncmb.TabIndex = 7;
            // 
            // AddItemFuelTypecmb
            // 
            AddItemFuelTypecmb.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemFuelTypecmb.Items.AddRange(new object[] { "Petrol", "Diesel", "Hybrid", "Eletric" });
            AddItemFuelTypecmb.Location = new Point(149, 368);
            AddItemFuelTypecmb.Name = "AddItemFuelTypecmb";
            AddItemFuelTypecmb.Size = new Size(200, 28);
            AddItemFuelTypecmb.TabIndex = 8;
            // 
            // AddItemStatuscmb
            // 
            AddItemStatuscmb.DropDownStyle = ComboBoxStyle.DropDownList;
            AddItemStatuscmb.Items.AddRange(new object[] { "Available", "Reserved", "Sold" });
            AddItemStatuscmb.Location = new Point(149, 417);
            AddItemStatuscmb.Name = "AddItemStatuscmb";
            AddItemStatuscmb.Size = new Size(200, 28);
            AddItemStatuscmb.TabIndex = 9;
            // 
            // AddItemMileageBoxcmb
            // 
            AddItemMileageBoxcmb.Location = new Point(149, 466);
            AddItemMileageBoxcmb.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            AddItemMileageBoxcmb.Name = "AddItemMileageBoxcmb";
            AddItemMileageBoxcmb.Size = new Size(200, 27);
            AddItemMileageBoxcmb.TabIndex = 10;
            // 
            // AddItemSaveButton
            // 
            AddItemSaveButton.BackColor = Color.FromArgb(0, 192, 0);
            AddItemSaveButton.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            AddItemSaveButton.Location = new Point(529, 570);
            AddItemSaveButton.Name = "AddItemSaveButton";
            AddItemSaveButton.Size = new Size(88, 37);
            AddItemSaveButton.TabIndex = 11;
            AddItemSaveButton.Text = "Save";
            AddItemSaveButton.UseVisualStyleBackColor = false;
            AddItemSaveButton.Click += AddItemSaveButton_Click;
            // 
            // AddItemCanselBtn
            // 
            AddItemCanselBtn.BackColor = Color.Red;
            AddItemCanselBtn.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            AddItemCanselBtn.Location = new Point(717, 570);
            AddItemCanselBtn.Name = "AddItemCanselBtn";
            AddItemCanselBtn.Size = new Size(82, 37);
            AddItemCanselBtn.TabIndex = 12;
            AddItemCanselBtn.Text = "Cancel";
            AddItemCanselBtn.UseVisualStyleBackColor = false;
            AddItemCanselBtn.Click += AddItemCanselBtn_Click_1;
            // 
            // AddItemVehicleradioButton
            // 
            AddItemVehicleradioButton.AutoSize = true;
            AddItemVehicleradioButton.Font = new Font("Segoe UI Semibold", 16.3018875F, FontStyle.Bold);
            AddItemVehicleradioButton.Location = new Point(186, 12);
            AddItemVehicleradioButton.Name = "AddItemVehicleradioButton";
            AddItemVehicleradioButton.Size = new Size(114, 39);
            AddItemVehicleradioButton.TabIndex = 13;
            AddItemVehicleradioButton.TabStop = true;
            AddItemVehicleradioButton.Text = "Vehicle";
            AddItemVehicleradioButton.UseVisualStyleBackColor = true;
            // 
            // AddItemPartRadioButton
            // 
            AddItemPartRadioButton.AutoSize = true;
            AddItemPartRadioButton.Font = new Font("Segoe UI Semibold", 16.3018875F, FontStyle.Bold);
            AddItemPartRadioButton.Location = new Point(329, 12);
            AddItemPartRadioButton.Name = "AddItemPartRadioButton";
            AddItemPartRadioButton.Size = new Size(79, 39);
            AddItemPartRadioButton.TabIndex = 14;
            AddItemPartRadioButton.TabStop = true;
            AddItemPartRadioButton.Text = "Part";
            AddItemPartRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddItemNameTex
            // 
            AddItemNameTex.AutoSize = true;
            AddItemNameTex.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemNameTex.Location = new Point(82, 75);
            AddItemNameTex.Name = "AddItemNameTex";
            AddItemNameTex.Size = new Size(61, 25);
            AddItemNameTex.TabIndex = 15;
            AddItemNameTex.Text = "Name";
            // 
            // AddItemPriceTxt
            // 
            AddItemPriceTxt.AutoSize = true;
            AddItemPriceTxt.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemPriceTxt.Location = new Point(90, 112);
            AddItemPriceTxt.Name = "AddItemPriceTxt";
            AddItemPriceTxt.Size = new Size(53, 25);
            AddItemPriceTxt.TabIndex = 16;
            AddItemPriceTxt.Text = "Price";
            // 
            // AddItemYearTex
            // 
            AddItemYearTex.AutoSize = true;
            AddItemYearTex.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemYearTex.Location = new Point(38, 154);
            AddItemYearTex.Name = "AddItemYearTex";
            AddItemYearTex.Size = new Size(105, 25);
            AddItemYearTex.TabIndex = 17;
            AddItemYearTex.Text = "Model Year";
            // 
            // AddItemBrandTex
            // 
            AddItemBrandTex.AutoSize = true;
            AddItemBrandTex.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemBrandTex.Location = new Point(82, 192);
            AddItemBrandTex.Name = "AddItemBrandTex";
            AddItemBrandTex.Size = new Size(61, 25);
            AddItemBrandTex.TabIndex = 18;
            AddItemBrandTex.Text = "Brand";
            // 
            // AddItemTypeTex
            // 
            AddItemTypeTex.AutoSize = true;
            AddItemTypeTex.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemTypeTex.Location = new Point(92, 237);
            AddItemTypeTex.Name = "AddItemTypeTex";
            AddItemTypeTex.Size = new Size(51, 25);
            AddItemTypeTex.TabIndex = 19;
            AddItemTypeTex.Text = "Type";
            // 
            // AddItemPriceRangeTex
            // 
            AddItemPriceRangeTex.AutoSize = true;
            AddItemPriceRangeTex.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemPriceRangeTex.Location = new Point(33, 277);
            AddItemPriceRangeTex.Name = "AddItemPriceRangeTex";
            AddItemPriceRangeTex.Size = new Size(110, 25);
            AddItemPriceRangeTex.TabIndex = 20;
            AddItemPriceRangeTex.Text = "Price Range";
            // 
            // AddItemConditionTex
            // 
            AddItemConditionTex.AutoSize = true;
            AddItemConditionTex.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemConditionTex.Location = new Point(48, 320);
            AddItemConditionTex.Name = "AddItemConditionTex";
            AddItemConditionTex.Size = new Size(95, 25);
            AddItemConditionTex.TabIndex = 21;
            AddItemConditionTex.Text = "Condition";
            // 
            // AddItemFuelTex
            // 
            AddItemFuelTex.AutoSize = true;
            AddItemFuelTex.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemFuelTex.Location = new Point(52, 367);
            AddItemFuelTex.Name = "AddItemFuelTex";
            AddItemFuelTex.Size = new Size(91, 25);
            AddItemFuelTex.TabIndex = 22;
            AddItemFuelTex.Text = "Fuel Type";
            // 
            // AddItemStatusTex
            // 
            AddItemStatusTex.AutoSize = true;
            AddItemStatusTex.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemStatusTex.Location = new Point(80, 416);
            AddItemStatusTex.Name = "AddItemStatusTex";
            AddItemStatusTex.Size = new Size(63, 25);
            AddItemStatusTex.TabIndex = 23;
            AddItemStatusTex.Text = "Status";
            // 
            // AddItemMiageTex
            // 
            AddItemMiageTex.AutoSize = true;
            AddItemMiageTex.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemMiageTex.Location = new Point(29, 465);
            AddItemMiageTex.Name = "AddItemMiageTex";
            AddItemMiageTex.Size = new Size(114, 25);
            AddItemMiageTex.TabIndex = 24;
            AddItemMiageTex.Text = "Mileage  km";
            // 
            // AddItemPicUploadbtn
            // 
            AddItemPicUploadbtn.BackColor = SystemColors.ActiveCaption;
            AddItemPicUploadbtn.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            AddItemPicUploadbtn.Location = new Point(529, 454);
            AddItemPicUploadbtn.Name = "AddItemPicUploadbtn";
            AddItemPicUploadbtn.Size = new Size(129, 39);
            AddItemPicUploadbtn.TabIndex = 25;
            AddItemPicUploadbtn.Text = "Add Picture";
            AddItemPicUploadbtn.UseVisualStyleBackColor = false;
            AddItemPicUploadbtn.Click += AddItemPicUploadbtn_Click_1;
            // 
            // AddItempicture
            // 
            AddItempicture.BorderStyle = BorderStyle.Fixed3D;
            AddItempicture.Image = Properties.Resources.ImageCar;
            AddItempicture.Location = new Point(378, 108);
            AddItempicture.Name = "AddItempicture";
            AddItempicture.Size = new Size(426, 337);
            AddItempicture.SizeMode = PictureBoxSizeMode.StretchImage;
            AddItempicture.TabIndex = 26;
            AddItempicture.TabStop = false;
            // 
            // AddItemDescriptionTxt
            // 
            AddItemDescriptionTxt.AutoSize = true;
            AddItemDescriptionTxt.Font = new Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold);
            AddItemDescriptionTxt.Location = new Point(35, 516);
            AddItemDescriptionTxt.Name = "AddItemDescriptionTxt";
            AddItemDescriptionTxt.Size = new Size(108, 25);
            AddItemDescriptionTxt.TabIndex = 27;
            AddItemDescriptionTxt.Text = "Description";
            // 
            // AddItemDescriptionBox
            // 
            AddItemDescriptionBox.Location = new Point(149, 527);
            AddItemDescriptionBox.Multiline = true;
            AddItemDescriptionBox.Name = "AddItemDescriptionBox";
            AddItemDescriptionBox.ScrollBars = ScrollBars.Vertical;
            AddItemDescriptionBox.Size = new Size(362, 158);
            AddItemDescriptionBox.TabIndex = 28;
            // 
            // AddItemClearBtn
            // 
            AddItemClearBtn.BackColor = Color.DarkTurquoise;
            AddItemClearBtn.Font = new Font("Segoe UI", 10.18868F, FontStyle.Bold);
            AddItemClearBtn.Location = new Point(623, 570);
            AddItemClearBtn.Name = "AddItemClearBtn";
            AddItemClearBtn.Size = new Size(88, 37);
            AddItemClearBtn.TabIndex = 29;
            AddItemClearBtn.Text = "Clear";
            AddItemClearBtn.UseVisualStyleBackColor = false;
            AddItemClearBtn.Click += AddItemClearBtn_Click;
            // 
            // AdminAddItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(826, 705);
            ControlBox = false;
            Controls.Add(AddItemClearBtn);
            Controls.Add(AddItemDescriptionBox);
            Controls.Add(AddItemDescriptionTxt);
            Controls.Add(AddItempicture);
            Controls.Add(AddItemPicUploadbtn);
            Controls.Add(AddItemMiageTex);
            Controls.Add(AddItemStatusTex);
            Controls.Add(AddItemFuelTex);
            Controls.Add(AddItemConditionTex);
            Controls.Add(AddItemPriceRangeTex);
            Controls.Add(AddItemTypeTex);
            Controls.Add(AddItemBrandTex);
            Controls.Add(AddItemYearTex);
            Controls.Add(AddItemPriceTxt);
            Controls.Add(AddItemNameTex);
            Controls.Add(AddItemPartRadioButton);
            Controls.Add(AddItemVehicleradioButton);
            Controls.Add(AddItemCanselBtn);
            Controls.Add(AddItemSaveButton);
            Controls.Add(AddItemMileageBoxcmb);
            Controls.Add(AddItemStatuscmb);
            Controls.Add(AddItemFuelTypecmb);
            Controls.Add(AddItemConditioncmb);
            Controls.Add(AddItemPriceRangecmb);
            Controls.Add(AddItemTypecmb);
            Controls.Add(AddItemBrandNamecmb);
            Controls.Add(AddItemModelYearBox);
            Controls.Add(AddItemPriceBox);
            Controls.Add(AddItemNameBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminAddItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Item";
            ((System.ComponentModel.ISupportInitialize)AddItemPriceBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddItemModelYearBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddItemMileageBoxcmb).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddItempicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AddItemNameBox;
        private NumericUpDown AddItemPriceBox;
        private NumericUpDown AddItemModelYearBox;
        private ComboBox AddItemBrandNamecmb;
        private ComboBox AddItemTypecmb;
        private ComboBox AddItemPriceRangecmb;
        private ComboBox AddItemConditioncmb;
        private ComboBox AddItemFuelTypecmb;
        private ComboBox AddItemStatuscmb;
        private NumericUpDown AddItemMileageBoxcmb;
        private Button AddItemSaveButton;
        private Button AddItemCanselBtn;
        private RadioButton AddItemVehicleradioButton;
        private RadioButton AddItemPartRadioButton;
        private Label AddItemNameTex;
        private Label AddItemPriceTxt;
        private Label AddItemYearTex;
        private Label AddItemBrandTex;
        private Label AddItemTypeTex;
        private Label AddItemPriceRangeTex;
        private Label AddItemConditionTex;
        private Label AddItemFuelTex;
        private Label AddItemStatusTex;
        private Label AddItemMiageTex;
        private Button AddItemPicUploadbtn;
        private PictureBox AddItempicture;
        private Label AddItemDescriptionTxt;
        private TextBox AddItemDescriptionBox;
        private Button AddItemClearBtn;
    }
}
