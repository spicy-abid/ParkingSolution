
namespace ParkingSolution
{
    partial class Cleaner_Form
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
            this.Notifaction = new System.Windows.Forms.Label();
            this.label_Attandance_Cleaner = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Attandance_Cleaner = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Notifaction
            // 
            this.Notifaction.AutoSize = true;
            this.Notifaction.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Notifaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Notifaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notifaction.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Notifaction.Location = new System.Drawing.Point(340, 234);
            this.Notifaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Notifaction.Name = "Notifaction";
            this.Notifaction.Size = new System.Drawing.Size(135, 31);
            this.Notifaction.TabIndex = 11;
            this.Notifaction.Text = "Notification";
            // 
            // label_Attandance_Cleaner
            // 
            this.label_Attandance_Cleaner.AutoSize = true;
            this.label_Attandance_Cleaner.BackColor = System.Drawing.SystemColors.Info;
            this.label_Attandance_Cleaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Attandance_Cleaner.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Attandance_Cleaner.Location = new System.Drawing.Point(335, 93);
            this.label_Attandance_Cleaner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Attandance_Cleaner.Name = "label_Attandance_Cleaner";
            this.label_Attandance_Cleaner.Size = new System.Drawing.Size(133, 29);
            this.label_Attandance_Cleaner.TabIndex = 10;
            this.label_Attandance_Cleaner.Text = "Attendance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "aa";
            // 
            // button_Attandance_Cleaner
            // 
            this.button_Attandance_Cleaner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Attandance_Cleaner.Location = new System.Drawing.Point(264, 137);
            this.button_Attandance_Cleaner.Margin = new System.Windows.Forms.Padding(2);
            this.button_Attandance_Cleaner.Name = "button_Attandance_Cleaner";
            this.button_Attandance_Cleaner.Size = new System.Drawing.Size(272, 77);
            this.button_Attandance_Cleaner.TabIndex = 8;
            this.button_Attandance_Cleaner.UseVisualStyleBackColor = false;
            this.button_Attandance_Cleaner.Click += new System.EventHandler(this.button_Attandance_Cleaner_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(264, 280);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 78);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 137);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(7, 6);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_LogOut
            // 
            this.button_LogOut.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LogOut.Location = new System.Drawing.Point(532, 396);
            this.button_LogOut.Name = "button_LogOut";
            this.button_LogOut.Size = new System.Drawing.Size(256, 42);
            this.button_LogOut.TabIndex = 27;
            this.button_LogOut.Text = "Log Out";
            this.button_LogOut.UseVisualStyleBackColor = true;
            // 
            // Cleaner_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_LogOut);
            this.Controls.Add(this.Notifaction);
            this.Controls.Add(this.label_Attandance_Cleaner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Attandance_Cleaner);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Cleaner_Form";
            this.Text = "Cleaner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Notifaction;
        private System.Windows.Forms.Label label_Attandance_Cleaner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Attandance_Cleaner;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_LogOut;
    }
}