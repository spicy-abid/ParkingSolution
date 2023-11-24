using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParkingSolution
{

    public partial class Register : Form

    {
        Manager m;
        Clerk c = new Clerk();

        SqlConnection con =new SqlConnection("Data Source=ABID\\SQLEXPRESS;Initial Catalog=ParkingSolution;Integrated Security=True");
        
        public Register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            string query = "UPDATE EmpTable SET Type='MANAGER' WHERE Type='MANAGER'";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            if(cmd.ExecuteNonQuery()==1)
            {
                radioButton_Manager.Enabled =false ;
                MessageBox.Show("Welcome\n" , "Manager", MessageBoxButtons.OKCancel);
            }
            else 
            {

                radioButton_Manager.Enabled = true;
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_Back_to_login_Click(object sender, EventArgs e)
        {
            new LOGIN_Form().Show();
            this.Hide();
        }

        private void button1_Register_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "")
            {
                MessageBox.Show("Please Insert your Name", "Name Missing Error!", MessageBoxButtons.OKCancel);
            }
            else
            {
                if (radioButton_Manager.Checked == true)
                {
                    if (textBox_NID.TextLength != 5)
                    {
                        MessageBox.Show("Please Correct your NID", "NID Error!", MessageBoxButtons.OKCancel);
                    }
                    else
                    {   if (textBox_ConfirmPassword.Text == "" && textBox_Password.Text == "")
                        {
                            MessageBox.Show("Set Your Password", "Password Error!", MessageBoxButtons.OKCancel);
                        }
                        else
                        {
                            if (textBox_Password.Text != textBox_ConfirmPassword.Text)
                            {
                                MessageBox.Show("Password did not matched!\n Try Again!", "Password Error!");
                            }
                            else
                            {
                                try
                                {
                                    
                                    string name = textBox_Name.Text;
                                    string type = "MANAGER";
                                     string pas = textBox_Password.Text;

                                    string nid = textBox_NID.Text;
                                    ulong Nid = ulong.Parse(nid);
                                    string GeneratedID = name.Substring(0, 2) + type + nid.Substring(2, 3);
                                    textBox_GeneratedUserID.Text = GeneratedID;
                                    m = new Manager(textBox_Name.Text, Nid, type, GeneratedID,pas);
                                    //new Register().Show();
                                    //this.Hide();


                                }
                                catch
                                {
                                    MessageBox.Show("Error\nTry Again!!", "Error!", MessageBoxButtons.OKCancel);
                                }
                            }
                        }
                        

                    }
                }
                else if (radioButton_Clerk.Checked == true)
                {
                    
                        if (textBox_NID.TextLength != 5)
                        {
                            MessageBox.Show("Please Correct your NID", "NID Error!", MessageBoxButtons.OKCancel);
                        }
                        else
                        {
                            if (textBox_ConfirmPassword.Text == "" && textBox_Password.Text == "")
                            {
                                MessageBox.Show("Set Your Password", "Password Error!", MessageBoxButtons.OKCancel);
                            }
                            else
                            {
                                if (textBox_Password.Text != textBox_ConfirmPassword.Text)
                                {
                                    MessageBox.Show("Password did not matched!\n Try Again!", "Password Error!");
                                }
                                else
                                {
                                try
                                {
                                    string name = textBox_Name.Text;
                                    string type = "CLERK";
                                    string pas = textBox_Password.Text;

                                    string nid = textBox_NID.Text;
                                    ulong Nid = ulong.Parse(nid);
                                    string GeneratedID = name.Substring(0, 2) + type + nid.Substring(2, 3);
                                    textBox_GeneratedUserID.Text = GeneratedID;
                                    c = new Clerk(textBox_Name.Text, Nid, type, GeneratedID,pas);
                                    //new Register().Show();
                                    //this.Hide();
                                }
                                catch
                                {
                                    MessageBox.Show("Error\nTry Again!!", "Error!", MessageBoxButtons.OKCancel);
                                }
                            }

                            }


                        
                        
                        }
                }
                else if (radioButton_TokenChecker.Checked == true)
                {
                    
                        if (textBox_NID.TextLength != 5)
                        {
                            MessageBox.Show("Please Correct your NID", "NID Error!", MessageBoxButtons.OKCancel);
                        }
                        else
                        {
                            if (textBox_ConfirmPassword.Text == "" && textBox_Password.Text == "")
                            {
                                MessageBox.Show("Set Your Password", "Password Error!", MessageBoxButtons.OKCancel);
                            }
                            else
                            {
                                if (textBox_Password.Text != textBox_ConfirmPassword.Text)
                                {
                                    MessageBox.Show("Password did not matched!\n Try Again!", "Password Error!");
                                }
                                else
                                {
                                try
                                {
                                    string name = textBox_Name.Text;
                                    string type = "CHECKER";
                                    string pas = textBox_Password.Text;

                                    string nid = textBox_NID.Text;
                                    ulong Nid = ulong.Parse(nid);
                                    string GeneratedID = name.Substring(0, 2) + type + nid.Substring(2, 3);
                                    textBox_GeneratedUserID.Text = GeneratedID;
                                    Tokenchecker tchk = new Tokenchecker(textBox_Name.Text, Nid, type, GeneratedID,pas);
                                    //new Register().Show();
                                    //this.Hide();
                                }
                                catch
                                {
                                    MessageBox.Show("Error\nTry Again!!", "Error!", MessageBoxButtons.OKCancel);
                                }
                                }
                            }


                        

                        }
                    
                    
                }
                else
                {
                    MessageBox.Show("Select your Position", "Department Error!", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = "";
            textBox_NID.Text = "";
            textBox_Password.Text = "";
            textBox_ConfirmPassword.Text = "";
            textBox_GeneratedUserID.Text = "";
            radioButton_Clerk.Checked = false;
            radioButton_Manager.Checked = false;
            radioButton_TokenChecker.Checked = false;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_ShowPassLOGIN_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_ShowPassLOGIN.Checked)
            {
                textBox_ConfirmPassword.UseSystemPasswordChar = false;
                textBox_Password.UseSystemPasswordChar = false;
            }  
            else
            {
                textBox_ConfirmPassword.UseSystemPasswordChar = true;
                textBox_Password.UseSystemPasswordChar = true;
            }
        }
    }
}
