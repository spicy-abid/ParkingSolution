
namespace ParkingSolution
{
    partial class TokenChecker_Form
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
            this.dataGridView_NotificationBox_TokenChecker = new System.Windows.Forms.DataGridView();
            this.label_NotificationBox_Token = new System.Windows.Forms.Label();
            this.label_CheckToken_TokenChecker = new System.Windows.Forms.Label();
            this.textBox_CheckToken_TokenChecker = new System.Windows.Forms.TextBox();
            this.button_LogOut = new System.Windows.Forms.Button();
            this.button_Check = new System.Windows.Forms.Button();
            this.textBox_checkVehicle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_RefreshTokckr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NotificationBox_TokenChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_NotificationBox_TokenChecker
            // 
            this.dataGridView_NotificationBox_TokenChecker.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView_NotificationBox_TokenChecker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_NotificationBox_TokenChecker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NotificationBox_TokenChecker.Location = new System.Drawing.Point(256, 79);
            this.dataGridView_NotificationBox_TokenChecker.Name = "dataGridView_NotificationBox_TokenChecker";
            this.dataGridView_NotificationBox_TokenChecker.Size = new System.Drawing.Size(336, 150);
            this.dataGridView_NotificationBox_TokenChecker.TabIndex = 16;
            this.dataGridView_NotificationBox_TokenChecker.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NotificationBox_TokenChecker_CellContentClick);
            // 
            // label_NotificationBox_Token
            // 
            this.label_NotificationBox_Token.AutoSize = true;
            this.label_NotificationBox_Token.BackColor = System.Drawing.Color.Transparent;
            this.label_NotificationBox_Token.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NotificationBox_Token.ForeColor = System.Drawing.Color.Black;
            this.label_NotificationBox_Token.Location = new System.Drawing.Point(337, 14);
            this.label_NotificationBox_Token.Name = "label_NotificationBox_Token";
            this.label_NotificationBox_Token.Size = new System.Drawing.Size(162, 62);
            this.label_NotificationBox_Token.TabIndex = 13;
            this.label_NotificationBox_Token.Text = "Notification\r\nBox";
            this.label_NotificationBox_Token.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_CheckToken_TokenChecker
            // 
            this.label_CheckToken_TokenChecker.AutoSize = true;
            this.label_CheckToken_TokenChecker.BackColor = System.Drawing.Color.Transparent;
            this.label_CheckToken_TokenChecker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CheckToken_TokenChecker.ForeColor = System.Drawing.Color.Black;
            this.label_CheckToken_TokenChecker.Location = new System.Drawing.Point(220, 232);
            this.label_CheckToken_TokenChecker.Name = "label_CheckToken_TokenChecker";
            this.label_CheckToken_TokenChecker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_CheckToken_TokenChecker.Size = new System.Drawing.Size(178, 31);
            this.label_CheckToken_TokenChecker.TabIndex = 12;
            this.label_CheckToken_TokenChecker.Text = "CheckToken";
            // 
            // textBox_CheckToken_TokenChecker
            // 
            this.textBox_CheckToken_TokenChecker.BackColor = System.Drawing.Color.Red;
            this.textBox_CheckToken_TokenChecker.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CheckToken_TokenChecker.Location = new System.Drawing.Point(220, 266);
            this.textBox_CheckToken_TokenChecker.Name = "textBox_CheckToken_TokenChecker";
            this.textBox_CheckToken_TokenChecker.Size = new System.Drawing.Size(172, 35);
            this.textBox_CheckToken_TokenChecker.TabIndex = 11;
            // 
            // button_LogOut
            // 
            this.button_LogOut.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogOut.Location = new System.Drawing.Point(37, 398);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(256, 42);
            this.button_LogOut.TabIndex = 27;
            this.button_LogOut.Text = "Log Out";
            this.button_LogOut.UseVisualStyleBackColor = true;
            this.button_LogOut.Click += new System.EventHandler(this.button_LogOut_Click);
            // 
            // button_Check
            // 
            this.button_Check.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Check.Location = new System.Drawing.Point(290, 340);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(256, 42);
            this.button_Check.TabIndex = 28;
            this.button_Check.Text = "Check";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // textBox_checkVehicle
            // 
            this.textBox_checkVehicle.BackColor = System.Drawing.Color.Red;
            this.textBox_checkVehicle.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.textBox_checkVehicle.Location = new System.Drawing.Point(479, 266);
            this.textBox_checkVehicle.Name = "textBox_checkVehicle";
            this.textBox_checkVehicle.Size = new System.Drawing.Size(172, 35);
            this.textBox_checkVehicle.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(479, 232);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "CheckVehicle";
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(532, 398);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(256, 42);
            this.button_Exit.TabIndex = 31;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_RefreshTokckr
            // 
            this.button_RefreshTokckr.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RefreshTokckr.Location = new System.Drawing.Point(1, 9);
            this.button_RefreshTokckr.Name = "button_RefreshTokckr";
            this.button_RefreshTokckr.Size = new System.Drawing.Size(256, 42);
            this.button_RefreshTokckr.TabIndex = 32;
            this.button_RefreshTokckr.Text = "Refresh";
            this.button_RefreshTokckr.UseVisualStyleBackColor = true;
            this.button_RefreshTokckr.Click += new System.EventHandler(this.button_RefreshTokckr_Click);
            // 
            // TokenChecker_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_RefreshTokckr);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_checkVehicle);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.button_LogOut);
            this.Controls.Add(this.dataGridView_NotificationBox_TokenChecker);
            this.Controls.Add(this.label_NotificationBox_Token);
            this.Controls.Add(this.label_CheckToken_TokenChecker);
            this.Controls.Add(this.textBox_CheckToken_TokenChecker);
            this.Name = "TokenChecker_Form";
            this.Text = "TokenChecker";
            this.Load += new System.EventHandler(this.TokenChecker_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NotificationBox_TokenChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_NotificationBox_TokenChecker;
        private System.Windows.Forms.Label label_NotificationBox_Token;
        private System.Windows.Forms.Label label_CheckToken_TokenChecker;
        private System.Windows.Forms.TextBox textBox_CheckToken_TokenChecker;
        private System.Windows.Forms.Button button_LogOut;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.TextBox textBox_checkVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_RefreshTokckr;
    }
}