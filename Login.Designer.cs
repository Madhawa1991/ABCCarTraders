namespace ABC_Car_Traders
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            PaswordLabel = new Label();
            LoginButton = new Button();
            CancelButton = new Button();
            ShowPasswordCheckBox = new CheckBox();
            LoginPasswordBox = new TextBox();
            nameLabel = new Label();
            LoginRegisterLink = new LinkLabel();
            LoginChangePW = new LinkLabel();
            LoginNameBox = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PaswordLabel
            // 
            PaswordLabel.AutoSize = true;
            PaswordLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            PaswordLabel.Location = new Point(410, 82);
            PaswordLabel.Name = "PaswordLabel";
            PaswordLabel.Size = new Size(107, 25);
            PaswordLabel.TabIndex = 1;
            PaswordLabel.Text = "Password :";
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DeepSkyBlue;
            LoginButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LoginButton.ForeColor = SystemColors.ActiveCaptionText;
            LoginButton.Location = new Point(624, 151);
            LoginButton.Margin = new Padding(3, 4, 3, 4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(122, 35);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.DeepSkyBlue;
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CancelButton.ForeColor = SystemColors.ActiveCaptionText;
            CancelButton.Location = new Point(624, 201);
            CancelButton.Margin = new Padding(3, 4, 3, 4);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(122, 36);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click_1;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.Font = new Font("Segoe UI", 10.8679247F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ShowPasswordCheckBox.Location = new Point(658, 124);
            ShowPasswordCheckBox.Margin = new Padding(3, 4, 3, 4);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(161, 29);
            ShowPasswordCheckBox.TabIndex = 5;
            ShowPasswordCheckBox.Text = "Show Password";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // LoginPasswordBox
            // 
            LoginPasswordBox.Location = new Point(573, 78);
            LoginPasswordBox.Margin = new Padding(3, 4, 3, 4);
            LoginPasswordBox.Name = "LoginPasswordBox";
            LoginPasswordBox.PasswordChar = '*';
            LoginPasswordBox.Size = new Size(222, 27);
            LoginPasswordBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            nameLabel.Location = new Point(438, 32);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(74, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name :";
            nameLabel.Click += label1_Click;
            // 
            // LoginRegisterLink
            // 
            LoginRegisterLink.AutoSize = true;
            LoginRegisterLink.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginRegisterLink.LinkColor = Color.DarkCyan;
            LoginRegisterLink.Location = new Point(584, 256);
            LoginRegisterLink.Name = "LoginRegisterLink";
            LoginRegisterLink.Size = new Size(202, 30);
            LoginRegisterLink.TabIndex = 9;
            LoginRegisterLink.TabStop = true;
            LoginRegisterLink.Text = "Register as new user";
            LoginRegisterLink.LinkClicked += RegisterLink_LinkClicked;
            // 
            // LoginChangePW
            // 
            LoginChangePW.AutoSize = true;
            LoginChangePW.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginChangePW.LinkColor = Color.Teal;
            LoginChangePW.Location = new Point(462, 117);
            LoginChangePW.Name = "LoginChangePW";
            LoginChangePW.Size = new Size(164, 30);
            LoginChangePW.TabIndex = 11;
            LoginChangePW.TabStop = true;
            LoginChangePW.Text = "Forget Password";
            LoginChangePW.LinkClicked += LoginChangePWLink_LinkClicked;
            // 
            // LoginNameBox
            // 
            LoginNameBox.Location = new Point(573, 28);
            LoginNameBox.Margin = new Padding(3, 4, 3, 4);
            LoginNameBox.Name = "LoginNameBox";
            LoginNameBox.Size = new Size(222, 27);
            LoginNameBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(401, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(865, 310);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(LoginChangePW);
            Controls.Add(LoginRegisterLink);
            Controls.Add(LoginNameBox);
            Controls.Add(LoginPasswordBox);
            Controls.Add(ShowPasswordCheckBox);
            Controls.Add(CancelButton);
            Controls.Add(LoginButton);
            Controls.Add(PaswordLabel);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.TextBox LoginPasswordBox;
        private System.Windows.Forms.LinkLabel LoginRegisterLink;
        private System.Windows.Forms.Label PaswordLabel;
        private System.Windows.Forms.LinkLabel LoginChangePW;
        private System.Windows.Forms.TextBox LoginNameBox;
        private PictureBox pictureBox1;
    }
}
