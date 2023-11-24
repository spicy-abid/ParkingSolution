using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSolution
{
    public partial class LOGIN_Form : Form
    {
        public LOGIN_Form()
        {
            InitializeComponent();
        }

        private void form_LOGIN_Load(object sender, EventArgs e)
        {

        }



        private void label_NID_Click(object sender, EventArgs e)
        {

        }

        private void label_Back_to_login_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void checkBox_ShowPassLOGIN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassLOGIN.Checked)
            {

                textBox_PasswordLogin.UseSystemPasswordChar = false;


            }
            else
            {
                textBox_PasswordLogin.UseSystemPasswordChar = true;
            }
        }

        private void Button1_LOGIN(object sender, EventArgs e)
        {
            try
            { 
            LOGIN login = new LOGIN(textBox_UserID.Text, textBox_PasswordLogin.Text);
                // MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OKCancel);
                // new Clerk_Form().Show();
                //
                if(login.LogINOp()==true)
                {
                    
                    this.Hide();
                }
            }
            catch
            {
                
                MessageBox.Show("Exception Occur!! ", "Error!", MessageBoxButtons.OKCancel);
            }
            
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_UserID.Text = "";
            textBox_PasswordLogin.Text = "";
        }

        private void textBox_UserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
