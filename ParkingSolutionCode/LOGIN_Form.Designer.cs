
namespace ParkingSolution
{
    partial class LOGIN_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN_Form));
            this.label_Register_Now = new System.Windows.Forms.Label();
            this.label_DontHaveAccount = new System.Windows.Forms.Label();
            this.checkBox_ShowPassLOGIN = new System.Windows.Forms.CheckBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label_PasswordLOGIN = new System.Windows.Forms.Label();
            this.textBox_PasswordLogin = new System.Windows.Forms.TextBox();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_LOGIN = new System.Windows.Forms.Button();
            this.label_UserID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_Register_Now
            // 
            this.label_Register_Now.AutoSize = true;
            this.label_Register_Now.BackColor = System.Drawing.Color.Transparent;
            this.label_Register_Now.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Register_Now.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Register_Now.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Register_Now.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label_Register_Now.Location = new System.Drawing.Point(222, 642);
            this.label_Register_Now.Name = "label_Register_Now";
            this.label_Register_Now.Size = new System.Drawing.Size(128, 25);
            this.label_Register_Now.TabIndex = 40;
            this.label_Register_Now.Text = "Register Now ";
            this.label_Register_Now.Click += new System.EventHandler(this.label_Back_to_login_Click);
            // 
            // label_DontHaveAccount
            // 
            this.label_DontHaveAccount.AutoSize = true;
            this.label_DontHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.label_DontHaveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_DontHaveAccount.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DontHaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_DontHaveAccount.Location = new System.Drawing.Point(188, 600);
            this.label_DontHaveAccount.Name = "label_DontHaveAccount";
            this.label_DontHaveAccount.Size = new System.Drawing.Size(211, 30);
            this.label_DontHaveAccount.TabIndex = 39;
            this.label_DontHaveAccount.Text = "Don\'t have account !!";
            // 
            // checkBox_ShowPassLOGIN
            // 
            this.checkBox_ShowPassLOGIN.AutoSize = true;
            this.checkBox_ShowPassLOGIN.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_ShowPassLOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_ShowPassLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_ShowPassLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShowPassLOGIN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox_ShowPassLOGIN.Location = new System.Drawing.Point(305, 425);
            this.checkBox_ShowPassLOGIN.Name = "checkBox_ShowPassLOGIN";
            this.checkBox_ShowPassLOGIN.Size = new System.Drawing.Size(138, 24);
            this.checkBox_ShowPassLOGIN.TabIndex = 38;
            this.checkBox_ShowPassLOGIN.Text = "Show Password";
            this.checkBox_ShowPassLOGIN.UseVisualStyleBackColor = false;
            this.checkBox_ShowPassLOGIN.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassLOGIN_CheckedChanged);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(247, 530);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(88, 38);
            this.button_Clear.TabIndex = 37;
            this.button_Clear.Text = "CLEAR";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label_PasswordLOGIN
            // 
            this.label_PasswordLOGIN.AutoSize = true;
            this.label_PasswordLOGIN.BackColor = System.Drawing.Color.Transparent;
            this.label_PasswordLOGIN.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PasswordLOGIN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_PasswordLOGIN.Location = new System.Drawing.Point(242, 346);
            this.label_PasswordLOGIN.Name = "label_PasswordLOGIN";
            this.label_PasswordLOGIN.Size = new System.Drawing.Size(101, 25);
            this.label_PasswordLOGIN.TabIndex = 34;
            this.label_PasswordLOGIN.Text = "Password";
            // 
            // textBox_PasswordLogin
            // 
            this.textBox_PasswordLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_PasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PasswordLogin.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_PasswordLogin.Location = new System.Drawing.Point(141, 374);
            this.textBox_PasswordLogin.Name = "textBox_PasswordLogin";
            this.textBox_PasswordLogin.Size = new System.Drawing.Size(302, 36);
            this.textBox_PasswordLogin.TabIndex = 33;
            this.textBox_PasswordLogin.UseSystemPasswordChar = true;
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_UserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_UserID.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_UserID.Location = new System.Drawing.Point(141, 298);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(302, 36);
            this.textBox_UserID.TabIndex = 31;
            this.textBox_UserID.TextChanged += new System.EventHandler(this.textBox_UserID_TextChanged);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(413, 727);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(116, 41);
            this.Button_Cancel.TabIndex = 30;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_LOGIN
            // 
            this.Button_LOGIN.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LOGIN.Location = new System.Drawing.Point(227, 467);
            this.Button_LOGIN.Name = "Button_LOGIN";
            this.Button_LOGIN.Size = new System.Drawing.Size(116, 41);
            this.Button_LOGIN.TabIndex = 26;
            this.Button_LOGIN.Text = "Log In";
            this.Button_LOGIN.UseVisualStyleBackColor = true;
            this.Button_LOGIN.Click += new System.EventHandler(this.Button1_LOGIN);
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.BackColor = System.Drawing.Color.Transparent;
            this.label_UserID.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_UserID.Location = new System.Drawing.Point(250, 270);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(85, 25);
            this.label_UserID.TabIndex = 32;
            this.label_UserID.Text = "User ID";
            this.label_UserID.Click += new System.EventHandler(this.label_NID_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(36, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 243);
            this.panel2.TabIndex = 27;
            // 
            // LOGIN_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 784);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Button_LOGIN);
            this.Controls.Add(this.label_Register_Now);
            this.Controls.Add(this.label_DontHaveAccount);
            this.Controls.Add(this.checkBox_ShowPassLOGIN);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_PasswordLOGIN);
            this.Controls.Add(this.textBox_PasswordLogin);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.Button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGIN_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_LOGIN";
            this.Load += new System.EventHandler(this.form_LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Register_Now;
        private System.Windows.Forms.Label label_DontHaveAccount;
        private System.Windows.Forms.CheckBox checkBox_ShowPassLOGIN;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label_PasswordLOGIN;
        private System.Windows.Forms.TextBox textBox_PasswordLogin;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_LOGIN;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Panel panel2;
    }
}