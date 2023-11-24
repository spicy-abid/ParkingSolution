
namespace ParkingSolution
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_REG_ICON = new System.Windows.Forms.Label();
            this.Button_Register = new System.Windows.Forms.Button();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.label_NID = new System.Windows.Forms.Label();
            this.textBox_NID = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_ConfirmPass = new System.Windows.Forms.Label();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_AlreadyHaveAccount = new System.Windows.Forms.Label();
            this.label_Back_to_login = new System.Windows.Forms.Label();
            this.radioButton_Manager = new System.Windows.Forms.RadioButton();
            this.radioButton_Clerk = new System.Windows.Forms.RadioButton();
            this.radioButton_TokenChecker = new System.Windows.Forms.RadioButton();
            this.textBox_GeneratedUserID = new System.Windows.Forms.TextBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.checkBox_ShowPassLOGIN = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_Name.Location = new System.Drawing.Point(46, 280);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(302, 36);
            this.textBox_Name.TabIndex = 9;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label_REG_ICON);
            this.panel2.Location = new System.Drawing.Point(36, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 243);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label_REG_ICON
            // 
            this.label_REG_ICON.AutoSize = true;
            this.label_REG_ICON.BackColor = System.Drawing.Color.Transparent;
            this.label_REG_ICON.Font = new System.Drawing.Font("Nirmala UI Semilight", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_REG_ICON.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_REG_ICON.Location = new System.Drawing.Point(320, 18);
            this.label_REG_ICON.Name = "label_REG_ICON";
            this.label_REG_ICON.Size = new System.Drawing.Size(174, 100);
            this.label_REG_ICON.TabIndex = 15;
            this.label_REG_ICON.Text = "REGISTER\r\n    HERE!\r\n";
            // 
            // Button_Register
            // 
            this.Button_Register.Location = new System.Drawing.Point(46, 596);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(116, 41);
            this.Button_Register.TabIndex = 7;
            this.Button_Register.Text = "REGISTER\r\n";
            this.Button_Register.UseVisualStyleBackColor = true;
            this.Button_Register.Click += new System.EventHandler(this.button1_Register_Click);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.BackColor = System.Drawing.Color.Transparent;
            this.Label_Name.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label_Name.Location = new System.Drawing.Point(50, 252);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(68, 25);
            this.Label_Name.TabIndex = 14;
            this.Label_Name.Text = "Name";
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(423, 719);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(116, 41);
            this.Button_Cancel.TabIndex = 15;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_NID
            // 
            this.label_NID.AutoSize = true;
            this.label_NID.BackColor = System.Drawing.Color.Transparent;
            this.label_NID.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_NID.Location = new System.Drawing.Point(50, 328);
            this.label_NID.Name = "label_NID";
            this.label_NID.Size = new System.Drawing.Size(52, 25);
            this.label_NID.TabIndex = 17;
            this.label_NID.Text = "NID";
            // 
            // textBox_NID
            // 
            this.textBox_NID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_NID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NID.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_NID.Location = new System.Drawing.Point(46, 356);
            this.textBox_NID.Name = "textBox_NID";
            this.textBox_NID.Size = new System.Drawing.Size(302, 36);
            this.textBox_NID.TabIndex = 16;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Password.Location = new System.Drawing.Point(50, 404);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(101, 25);
            this.label_Password.TabIndex = 19;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_Password.Location = new System.Drawing.Point(46, 432);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(302, 36);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_ConfirmPass
            // 
            this.label_ConfirmPass.AutoSize = true;
            this.label_ConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.label_ConfirmPass.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConfirmPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ConfirmPass.Location = new System.Drawing.Point(50, 480);
            this.label_ConfirmPass.Name = "label_ConfirmPass";
            this.label_ConfirmPass.Size = new System.Drawing.Size(183, 25);
            this.label_ConfirmPass.TabIndex = 21;
            this.label_ConfirmPass.Text = "Confirm Password";
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(46, 508);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(302, 36);
            this.textBox_ConfirmPassword.TabIndex = 20;
            this.textBox_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(232, 596);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(116, 41);
            this.button_Clear.TabIndex = 22;
            this.button_Clear.Text = "CLEAR";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_AlreadyHaveAccount
            // 
            this.label_AlreadyHaveAccount.AutoSize = true;
            this.label_AlreadyHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.label_AlreadyHaveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_AlreadyHaveAccount.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AlreadyHaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_AlreadyHaveAccount.Location = new System.Drawing.Point(122, 672);
            this.label_AlreadyHaveAccount.Name = "label_AlreadyHaveAccount";
            this.label_AlreadyHaveAccount.Size = new System.Drawing.Size(226, 30);
            this.label_AlreadyHaveAccount.TabIndex = 24;
            this.label_AlreadyHaveAccount.Text = "Aready have account !!";
            // 
            // label_Back_to_login
            // 
            this.label_Back_to_login.AutoSize = true;
            this.label_Back_to_login.BackColor = System.Drawing.Color.Transparent;
            this.label_Back_to_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Back_to_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Back_to_login.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Back_to_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label_Back_to_login.Location = new System.Drawing.Point(146, 702);
            this.label_Back_to_login.Name = "label_Back_to_login";
            this.label_Back_to_login.Size = new System.Drawing.Size(132, 25);
            this.label_Back_to_login.TabIndex = 25;
            this.label_Back_to_login.Text = "Back to LOGIN";
            this.label_Back_to_login.Click += new System.EventHandler(this.label_Back_to_login_Click);
            // 
            // radioButton_Manager
            // 
            this.radioButton_Manager.AutoSize = true;
            this.radioButton_Manager.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Manager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButton_Manager.Enabled = false;
            this.radioButton_Manager.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Manager.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton_Manager.Location = new System.Drawing.Point(411, 280);
            this.radioButton_Manager.Name = "radioButton_Manager";
            this.radioButton_Manager.Size = new System.Drawing.Size(122, 29);
            this.radioButton_Manager.TabIndex = 26;
            this.radioButton_Manager.TabStop = true;
            this.radioButton_Manager.Text = "Manager";
            this.radioButton_Manager.UseVisualStyleBackColor = false;
            // 
            // radioButton_Clerk
            // 
            this.radioButton_Clerk.AutoSize = true;
            this.radioButton_Clerk.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Clerk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButton_Clerk.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Clerk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton_Clerk.Location = new System.Drawing.Point(411, 324);
            this.radioButton_Clerk.Name = "radioButton_Clerk";
            this.radioButton_Clerk.Size = new System.Drawing.Size(88, 29);
            this.radioButton_Clerk.TabIndex = 27;
            this.radioButton_Clerk.TabStop = true;
            this.radioButton_Clerk.Text = "Clerk";
            this.radioButton_Clerk.UseVisualStyleBackColor = false;
            // 
            // radioButton_TokenChecker
            // 
            this.radioButton_TokenChecker.AutoSize = true;
            this.radioButton_TokenChecker.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_TokenChecker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButton_TokenChecker.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_TokenChecker.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton_TokenChecker.Location = new System.Drawing.Point(411, 359);
            this.radioButton_TokenChecker.Name = "radioButton_TokenChecker";
            this.radioButton_TokenChecker.Size = new System.Drawing.Size(115, 54);
            this.radioButton_TokenChecker.TabIndex = 28;
            this.radioButton_TokenChecker.TabStop = true;
            this.radioButton_TokenChecker.Text = "Token \r\nChecker";
            this.radioButton_TokenChecker.UseVisualStyleBackColor = false;
            // 
            // textBox_GeneratedUserID
            // 
            this.textBox_GeneratedUserID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_GeneratedUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_GeneratedUserID.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GeneratedUserID.Location = new System.Drawing.Point(365, 592);
            this.textBox_GeneratedUserID.Name = "textBox_GeneratedUserID";
            this.textBox_GeneratedUserID.ReadOnly = true;
            this.textBox_GeneratedUserID.Size = new System.Drawing.Size(174, 26);
            this.textBox_GeneratedUserID.TabIndex = 29;
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.BackColor = System.Drawing.Color.Transparent;
            this.label_UserID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_UserID.Location = new System.Drawing.Point(393, 571);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(146, 18);
            this.label_UserID.TabIndex = 30;
            this.label_UserID.Text = "UserID For LOGIN";
            // 
            // checkBox_ShowPassLOGIN
            // 
            this.checkBox_ShowPassLOGIN.AutoSize = true;
            this.checkBox_ShowPassLOGIN.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ShowPassLOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_ShowPassLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ShowPassLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShowPassLOGIN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_ShowPassLOGIN.Location = new System.Drawing.Point(210, 550);
            this.checkBox_ShowPassLOGIN.Name = "checkBox_ShowPassLOGIN";
            this.checkBox_ShowPassLOGIN.Size = new System.Drawing.Size(138, 24);
            this.checkBox_ShowPassLOGIN.TabIndex = 39;
            this.checkBox_ShowPassLOGIN.Text = "Show Password";
            this.checkBox_ShowPassLOGIN.UseVisualStyleBackColor = false;
            this.checkBox_ShowPassLOGIN.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassLOGIN_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 784);
            this.Controls.Add(this.checkBox_ShowPassLOGIN);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.textBox_GeneratedUserID);
            this.Controls.Add(this.radioButton_TokenChecker);
            this.Controls.Add(this.radioButton_Clerk);
            this.Controls.Add(this.radioButton_Manager);
            this.Controls.Add(this.label_Back_to_login);
            this.Controls.Add(this.label_AlreadyHaveAccount);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_ConfirmPass);
            this.Controls.Add(this.textBox_ConfirmPassword);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_NID);
            this.Controls.Add(this.textBox_NID);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Button_Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label label_REG_ICON;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Label label_NID;
        private System.Windows.Forms.TextBox textBox_NID;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_ConfirmPass;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_AlreadyHaveAccount;
        private System.Windows.Forms.Label label_Back_to_login;
        private System.Windows.Forms.RadioButton radioButton_Manager;
        private System.Windows.Forms.RadioButton radioButton_Clerk;
        private System.Windows.Forms.RadioButton radioButton_TokenChecker;
        private System.Windows.Forms.TextBox textBox_GeneratedUserID;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.CheckBox checkBox_ShowPassLOGIN;
    }
}

