using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParkingSolution
{
    public partial class Clerk_Form : Form
    {
        Clerk cl;
        string ClerkName;
        string UserID;
        double Duration;
        Clerk_Form log;
        SqlConnection con = new SqlConnection("Data Source=ABID\\SQLEXPRESS;Initial Catalog=ParkingSolution;Integrated Security=True");
        Label label_forCheckingEmp = new Label();
        TextBox textBox_CheckingEmp = new TextBox();
        public string UserID1 { get => UserID; set => UserID = value; }
        internal Clerk_Form Log { get => log; set => log = value; }

        public Clerk_Form()
        {
            InitializeComponent();
        }

        private void button_ConfirmToken_Click(object sender, EventArgs e)
        {
            if (textBox_ClerkID.Text == string.Empty)
            {
                MessageBox.Show("Please fill the ClerkID for the Operation", "STOP", MessageBoxButtons.OKCancel);
            }
            else
            {
                string querry = "SELECT Name FROM EmpTable where UserID='"+textBox_ClerkID.Text+"'";
                SqlCommand cmd = new SqlCommand(querry,con);
                con.Open();
                if(cmd.ExecuteReader().HasRows)
                {
                   // MessageBox.Show("F", "Error", MessageBoxButtons.OKCancel);
                    con.Close();
                    try
                    {

                        string nid = textBox_CustomerID.Text;
                        string slot = textBox_SlotNumber.Text;
                        string vehicleNo = textBox_VehicleNumber.Text;
                        ulong Nid = ulong.Parse(nid);
                        int Slot = int.Parse(slot);
                        string duration = textBox_Duration.Text;
                      
                       

                        cl = new Clerk();
                        cl.Name = textBox_CustomerName.Text;
                        cl.Nid1 = Nid;
                        cl.Slot = Slot;
                     

                        
                        cl.VehicleNumber = vehicleNo;
                       
                        if (radioButton_NormalToken.Checked == true)
                        {
                            
                            Duration = double.Parse(duration);
                       // radioButton_SuperToken.Checked = false;
                            cl.Ttype1 = "NORMAL";
                            cl.Duration1 = Duration;
                            
                            button_Print.Visible = true;
                            cl.TokenOperation();
                            

                        }
                        else if(radioButton_SuperToken.Checked == true)
                        {
                            
                            //radioButton_NormalToken.Checked = false;
                            textBox_Duration.Text = "";
                            string query2="SELECT Name From EmpTable where UserID='"+textBox_CheckingEmp.Text+"'";
                            SqlCommand cmd1 = new SqlCommand(query2,con);
                            try
                            {
                                if(cmd1.ExecuteReader().HasRows)
                                {
                                    MessageBox.Show("F", "Error", MessageBoxButtons.OKCancel);
                                    cl.Ttype1 = "SUPER";
                                    cl.Duration1 = 0;
                                    button_Print.Visible = true;
                                    cl.TokenOperation();
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Did not matched Employee\n Are your really Employee", "Alert!", MessageBoxButtons.OKCancel);
                                }
                                
                            }
                            catch
                            {
                                con.Open();
                            if (cmd1.ExecuteReader().HasRows)
                            {
                                cl.Ttype1 = "SUPER";
                                cl.Duration1 = 0;
                                    button_Print.Visible = true;
                                    cl.TokenOperation();
                                }
                            else
                            {
                                MessageBox.Show("Did not matched Employee\n Are your really Employee", "Alert!", MessageBoxButtons.OKCancel);
                            }
                            con.Close();
                            }
                            
                        }
                        

                    }
                    catch
                    {
                        MessageBox.Show("From Clerk confirm button ", "Error", MessageBoxButtons.OKCancel);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Did not Matched", "Try again!", MessageBoxButtons.OKCancel);
                    new LOGIN_Form().Show();
                    this.Hide();
                }
                con.Close();

            }


        }

        private void Clerk_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("yea", "done", MessageBoxButtons.OKCancel);
            string query1 = "Select TokenID from SlotTable where slot='" + 1 + "'";
            string query2 = "Select TokenID from SlotTable where slot='" + 2 + "'";
            string query3 = "Select TokenID from SlotTable where slot='" + 3 + "'";
            string query4 = "Select TokenID from SlotTable where slot='" + 4 + "'";
            string query5 = "Select TokenID from SlotTable where slot='" + 5 + "'";
            string query6 = "Select TokenID from SlotTable where slot='" + 6 + "'";
            string query7 = "Select TokenID from SlotTable where slot='" + 7 + "'";
            string query8 = "Select TokenID from SlotTable where slot='" + 8 + "'";
            string query9 = "SELECT TokenID FROM SlotTable WHERE Slot='"+9+"'";
            string query10 = "Select TokenID from SlotTable where slot='" +10+ "'";
            string query11 = "Select TokenID from SlotTable where slot='" +11+ "'";
            string query12 = "Select TokenID from SlotTable where slot='" + 12 + "'";
            string query13 = "Select TokenID from SlotTable where slot='" +13+ "'";
            string query14 = "Select TokenID from SlotTable where slot='" +14 + "'";
            string query15 = "Select TokenID from SlotTable where slot='" + 15 + "'";
            string query16 = "Select TokenID from SlotTable where slot='" + 16+ "'";
            string query17 = "Select TokenID from SlotTable where slot='" + 17+ "'";
            string query18 = "Select TokenID from SlotTable where slot='" + 18+ "'";
            string query19 = "Select TokenID from SlotTable where slot='" + 19+ "'";
            string query20 = "Select TokenID from SlotTable where slot='" + 20+ "'";
            string query21 = "Select TokenID from SlotTable where slot='" + 21+ "'";
            string query22 = "Select TokenID from SlotTable where slot='" + 22+ "'";
            string query23 = "Select TokenID from SlotTable where slot='" + 23+ "'";
            string query24 = "Select TokenID from SlotTable where slot='" + 24+ "'";
            //string u = log.UserID1;
           // con.Open();
            if(con.State==ConnectionState.Open)
            {

                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlCommand cmd5 = new SqlCommand(query5, con);
                SqlCommand cmd6 = new SqlCommand(query6, con);
                SqlCommand cmd7 = new SqlCommand(query7, con);
                SqlCommand cmd8 = new SqlCommand(query8, con);
                SqlCommand cmd9 = new SqlCommand(query9, con);
                SqlCommand cmd10 = new SqlCommand(query10, con);
                SqlCommand cmd11 = new SqlCommand(query11, con);
                SqlCommand cmd12 = new SqlCommand(query12, con);
                SqlCommand cmd13 = new SqlCommand(query13, con);
                SqlCommand cmd14 = new SqlCommand(query14, con);
                SqlCommand cmd15 = new SqlCommand(query15, con);
                SqlCommand cmd16 = new SqlCommand(query16, con);
                SqlCommand cmd17 = new SqlCommand(query17, con);
                SqlCommand cmd18 = new SqlCommand(query18, con);
                SqlCommand cmd19 = new SqlCommand(query19, con);
                SqlCommand cmd20 = new SqlCommand(query20, con);
                SqlCommand cmd21 = new SqlCommand(query21, con);
                SqlCommand cmd22 = new SqlCommand(query22, con);
                SqlCommand cmd23 = new SqlCommand(query23, con);
                SqlCommand cmd24 = new SqlCommand(query24, con);
                if(cmd1.ExecuteReader().HasRows)
                {
                    button_SLOT1.BackColor = System.Drawing.Color.Green;
                    
                }
                con.Close();
                con.Open();
                 if(cmd2.ExecuteReader().HasRows)
                {
                    button_SLOT2.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                 if(cmd2.ExecuteReader().HasRows)
                {
                    button_SLOT2.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd3.ExecuteReader().HasRows)
                {
                    button_SLOT3.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd4.ExecuteReader().HasRows)
                {
                    button_SLOT4.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd5.ExecuteReader().HasRows)
                {
                    button_SLOT5.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd6.ExecuteReader().HasRows)
                {
                    button_SLOT6.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd7.ExecuteReader().HasRows)
                {
                    button_SLOT7.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd8.ExecuteReader().HasRows)
                {
                    button_SLOT8.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd9.ExecuteReader().HasRows)
                {
                    button_SLOT9.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd10.ExecuteReader().HasRows)
                {
                    button_SLOT10.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd11.ExecuteReader().HasRows)
                {
                    button_SLOT11.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd12.ExecuteReader().HasRows)
                {
                    button_SLOT12.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd13.ExecuteReader().HasRows)
                {
                    button_SLOT13.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd14.ExecuteReader().HasRows)
                {
                    button_SLOT14.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd15.ExecuteReader().HasRows)
                {
                    button_SLOT15.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd16.ExecuteReader().HasRows)
                {
                    button_SLOT16.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd17.ExecuteReader().HasRows)
                {
                    button_SLOT17.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close(); 
                con.Open();
                if (cmd18.ExecuteReader().HasRows)
                {
                    button_SLOT18.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd19.ExecuteReader().HasRows)
                {
                    button_SLOT19.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd20.ExecuteReader().HasRows)
                {
                    button_SLOT20.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close(); 
                con.Open();
                if (cmd21.ExecuteReader().HasRows)
                {
                    button_SLOT21.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd22.ExecuteReader().HasRows)
                {
                    button_SLOT22.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd23.ExecuteReader().HasRows)
                {
                    button_SLOT23.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();
                con.Open();
                if (cmd24.ExecuteReader().HasRows)
                {
                    button23.BackColor = System.Drawing.Color.Green;
                } 
                 con.Close();

            }
            else if(con.State==ConnectionState.Closed)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlCommand cmd5 = new SqlCommand(query5, con);
                SqlCommand cmd6 = new SqlCommand(query6, con);
                SqlCommand cmd7 = new SqlCommand(query7, con);
                SqlCommand cmd8 = new SqlCommand(query8, con);
                SqlCommand cmd9 = new SqlCommand(query9, con);
                SqlCommand cmd10 = new SqlCommand(query10, con);
                SqlCommand cmd11 = new SqlCommand(query11, con);
                SqlCommand cmd12 = new SqlCommand(query12, con);
                SqlCommand cmd13 = new SqlCommand(query13, con);
                SqlCommand cmd14 = new SqlCommand(query14, con);
                SqlCommand cmd15 = new SqlCommand(query15, con);
                SqlCommand cmd16 = new SqlCommand(query16, con);
                SqlCommand cmd17 = new SqlCommand(query17, con);
                SqlCommand cmd18 = new SqlCommand(query18, con);
                SqlCommand cmd19 = new SqlCommand(query19, con);
                SqlCommand cmd20 = new SqlCommand(query20, con);
                SqlCommand cmd21 = new SqlCommand(query21, con);
                SqlCommand cmd22 = new SqlCommand(query22, con);
                SqlCommand cmd23 = new SqlCommand(query23, con);
                SqlCommand cmd24 = new SqlCommand(query24, con);
                if (cmd1.ExecuteReader().HasRows)
                {
                    button_SLOT1.BackColor = System.Drawing.Color.Green;

                }
                con.Close();
                con.Open();
                if (cmd2.ExecuteReader().HasRows)
                {
                    button_SLOT2.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd2.ExecuteReader().HasRows)
                {
                    button_SLOT2.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd3.ExecuteReader().HasRows)
                {
                    button_SLOT3.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd4.ExecuteReader().HasRows)
                {
                    button_SLOT4.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd5.ExecuteReader().HasRows)
                {
                    button_SLOT5.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd6.ExecuteReader().HasRows)
                {
                    button_SLOT6.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd7.ExecuteReader().HasRows)
                {
                    button_SLOT7.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd8.ExecuteReader().HasRows)
                {
                    button_SLOT8.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd9.ExecuteReader().HasRows)
                {
                    button_SLOT9.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd10.ExecuteReader().HasRows)
                {
                    button_SLOT10.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd11.ExecuteReader().HasRows)
                {
                    button_SLOT11.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd12.ExecuteReader().HasRows)
                {
                    button_SLOT12.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd13.ExecuteReader().HasRows)
                {
                    button_SLOT13.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd14.ExecuteReader().HasRows)
                {
                    button_SLOT14.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd15.ExecuteReader().HasRows)
                {
                    button_SLOT15.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd16.ExecuteReader().HasRows)
                {
                    button_SLOT16.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd17.ExecuteReader().HasRows)
                {
                    button_SLOT17.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd18.ExecuteReader().HasRows)
                {
                    button_SLOT18.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd19.ExecuteReader().HasRows)
                {
                    button_SLOT19.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd20.ExecuteReader().HasRows)
                {
                    button_SLOT20.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd21.ExecuteReader().HasRows)
                {
                    button_SLOT21.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd22.ExecuteReader().HasRows)
                {
                    button_SLOT22.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd23.ExecuteReader().HasRows)
                {
                    button_SLOT23.BackColor = System.Drawing.Color.Green;
                }
                con.Close();
                con.Open();
                if (cmd24.ExecuteReader().HasRows)
                {
                    button23.BackColor = System.Drawing.Color.Green;
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OKCancel);
            }




        }
        private void Clerk_Load()
        {
            //MessageBox.Show("yea", "done", MessageBoxButtons.OKCancel);
            string query1 = "Select TokenID from SlotTable where slot='" + 1 + "'";
            string query2 = "Select TokenID from SlotTable where slot='" + 2 + "'";
            string query3 = "Select TokenID from SlotTable where slot='" + 3 + "'";
            string query4 = "Select TokenID from SlotTable where slot='" + 4 + "'";
            string query5 = "Select TokenID from SlotTable where slot='" + 5 + "'";
            string query6 = "Select TokenID from SlotTable where slot='" + 6 + "'";
            string query7 = "Select TokenID from SlotTable where slot='" + 7 + "'";
            string query8 = "Select TokenID from SlotTable where slot='" + 8 + "'";
            string query9 = "SELECT TokenID FROM SlotTable WHERE Slot='" + 9 + "'";
            string query10 = "Select TokenID from SlotTable where slot='" + 10 + "'";
            string query11 = "Select TokenID from SlotTable where slot='" + 11 + "'";
            string query12 = "Select TokenID from SlotTable where slot='" + 12 + "'";
            string query13 = "Select TokenID from SlotTable where slot='" + 13 + "'";
            string query14 = "Select TokenID from SlotTable where slot='" + 14 + "'";
            string query15 = "Select TokenID from SlotTable where slot='" + 15 + "'";
            string query16 = "Select TokenID from SlotTable where slot='" + 16 + "'";
            string query17 = "Select TokenID from SlotTable where slot='" + 17 + "'";
            string query18 = "Select TokenID from SlotTable where slot='" + 18 + "'";
            string query19 = "Select TokenID from SlotTable where slot='" + 19 + "'";
            string query20 = "Select TokenID from SlotTable where slot='" + 20 + "'";
            string query21 = "Select TokenID from SlotTable where slot='" + 21 + "'";
            string query22 = "Select TokenID from SlotTable where slot='" + 22 + "'";
            string query23 = "Select TokenID from SlotTable where slot='" + 23 + "'";
            string query24 = "Select TokenID from SlotTable where slot='" + 24 + "'";
            //string u = log.UserID1;
            
            if (con.State == ConnectionState.Open)
            {

                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlCommand cmd5 = new SqlCommand(query5, con);
                SqlCommand cmd6 = new SqlCommand(query6, con);
                SqlCommand cmd7 = new SqlCommand(query7, con);
                SqlCommand cmd8 = new SqlCommand(query8, con);
                SqlCommand cmd9 = new SqlCommand(query9, con);
                SqlCommand cmd10 = new SqlCommand(query10, con);
                SqlCommand cmd11 = new SqlCommand(query11, con);
                SqlCommand cmd12 = new SqlCommand(query12, con);
                SqlCommand cmd13 = new SqlCommand(query13, con);
                SqlCommand cmd14 = new SqlCommand(query14, con);
                SqlCommand cmd15 = new SqlCommand(query15, con);
                SqlCommand cmd16 = new SqlCommand(query16, con);
                SqlCommand cmd17 = new SqlCommand(query17, con);
                SqlCommand cmd18 = new SqlCommand(query18, con);
                SqlCommand cmd19 = new SqlCommand(query19, con);
                SqlCommand cmd20 = new SqlCommand(query20, con);
                SqlCommand cmd21 = new SqlCommand(query21, con);
                SqlCommand cmd22 = new SqlCommand(query22, con);
                SqlCommand cmd23 = new SqlCommand(query23, con);
                SqlCommand cmd24 = new SqlCommand(query24, con);
                if (cmd1.ExecuteReader().HasRows)
                {
                    button_SLOT1.BackColor = System.Drawing.Color.Green;

                }
                else
                    button_SLOT1.BackColor = System.Drawing.Color.White;
                con.Close();
                

                con.Open();
                if (cmd2.ExecuteReader().HasRows)
                {
                    button_SLOT2.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT2.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd3.ExecuteReader().HasRows)
                {
                    button_SLOT3.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT3.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd4.ExecuteReader().HasRows)
                {
                    button_SLOT4.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT4.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd5.ExecuteReader().HasRows)
                {
                    button_SLOT5.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT5.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd6.ExecuteReader().HasRows)
                {
                    button_SLOT6.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT6.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd7.ExecuteReader().HasRows)
                {
                    button_SLOT7.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT7.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd8.ExecuteReader().HasRows)
                {
                    button_SLOT8.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT8.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd9.ExecuteReader().HasRows)
                {
                    button_SLOT9.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT9.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd10.ExecuteReader().HasRows)
                {
                    button_SLOT10.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT10.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd11.ExecuteReader().HasRows)
                {
                    button_SLOT11.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT11.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd12.ExecuteReader().HasRows)
                {
                    button_SLOT12.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT12.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd13.ExecuteReader().HasRows)
                {
                    button_SLOT13.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT13.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd14.ExecuteReader().HasRows)
                {
                    button_SLOT14.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT14.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd15.ExecuteReader().HasRows)
                {
                    button_SLOT15.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT15.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd16.ExecuteReader().HasRows)
                {
                    button_SLOT16.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT16.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd17.ExecuteReader().HasRows)
                {
                    button_SLOT17.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT17.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd18.ExecuteReader().HasRows)
                {
                    button_SLOT18.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT18.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd19.ExecuteReader().HasRows)
                {
                    button_SLOT19.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT19.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd20.ExecuteReader().HasRows)
                {
                    button_SLOT20.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT20.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd21.ExecuteReader().HasRows)
                {
                    button_SLOT21.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT21.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd22.ExecuteReader().HasRows)
                {
                    button_SLOT22.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT22.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd23.ExecuteReader().HasRows)
                {
                    button_SLOT23.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT23.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd24.ExecuteReader().HasRows)
                {
                    button23.BackColor = System.Drawing.Color.Green;
                }
                else
                    button23.BackColor = System.Drawing.Color.White;
                con.Close();

            }
            else if (con.State == ConnectionState.Closed)
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlCommand cmd5 = new SqlCommand(query5, con);
                SqlCommand cmd6 = new SqlCommand(query6, con);
                SqlCommand cmd7 = new SqlCommand(query7, con);
                SqlCommand cmd8 = new SqlCommand(query8, con);
                SqlCommand cmd9 = new SqlCommand(query9, con);
                SqlCommand cmd10 = new SqlCommand(query10, con);
                SqlCommand cmd11 = new SqlCommand(query11, con);
                SqlCommand cmd12 = new SqlCommand(query12, con);
                SqlCommand cmd13 = new SqlCommand(query13, con);
                SqlCommand cmd14 = new SqlCommand(query14, con);
                SqlCommand cmd15 = new SqlCommand(query15, con);
                SqlCommand cmd16 = new SqlCommand(query16, con);
                SqlCommand cmd17 = new SqlCommand(query17, con);
                SqlCommand cmd18 = new SqlCommand(query18, con);
                SqlCommand cmd19 = new SqlCommand(query19, con);
                SqlCommand cmd20 = new SqlCommand(query20, con);
                SqlCommand cmd21 = new SqlCommand(query21, con);
                SqlCommand cmd22 = new SqlCommand(query22, con);
                SqlCommand cmd23 = new SqlCommand(query23, con);
                SqlCommand cmd24 = new SqlCommand(query24, con);
                if (cmd1.ExecuteReader().HasRows)
                {
                    button_SLOT1.BackColor = System.Drawing.Color.Green;

                }
                else
                    button_SLOT1.BackColor = System.Drawing.Color.White;
                con.Close();


                con.Open();
                if (cmd2.ExecuteReader().HasRows)
                {
                    button_SLOT2.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT2.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd3.ExecuteReader().HasRows)
                {
                    button_SLOT3.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT3.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd4.ExecuteReader().HasRows)
                {
                    button_SLOT4.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT4.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd5.ExecuteReader().HasRows)
                {
                    button_SLOT5.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT5.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd6.ExecuteReader().HasRows)
                {
                    button_SLOT6.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT6.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd7.ExecuteReader().HasRows)
                {
                    button_SLOT7.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT7.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd8.ExecuteReader().HasRows)
                {
                    button_SLOT8.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT8.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd9.ExecuteReader().HasRows)
                {
                    button_SLOT9.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT9.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd10.ExecuteReader().HasRows)
                {
                    button_SLOT10.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT10.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd11.ExecuteReader().HasRows)
                {
                    button_SLOT11.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT11.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd12.ExecuteReader().HasRows)
                {
                    button_SLOT12.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT12.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd13.ExecuteReader().HasRows)
                {
                    button_SLOT13.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT13.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd14.ExecuteReader().HasRows)
                {
                    button_SLOT14.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT14.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd15.ExecuteReader().HasRows)
                {
                    button_SLOT15.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT15.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd16.ExecuteReader().HasRows)
                {
                    button_SLOT16.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT16.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd17.ExecuteReader().HasRows)
                {
                    button_SLOT17.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT17.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd18.ExecuteReader().HasRows)
                {
                    button_SLOT18.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT18.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd19.ExecuteReader().HasRows)
                {
                    button_SLOT19.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT19.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd20.ExecuteReader().HasRows)
                {
                    button_SLOT20.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT20.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd21.ExecuteReader().HasRows)
                {
                    button_SLOT21.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT21.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd22.ExecuteReader().HasRows)
                {
                    button_SLOT22.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT22.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd23.ExecuteReader().HasRows)
                {
                    button_SLOT23.BackColor = System.Drawing.Color.Green;
                }
                else
                    button_SLOT23.BackColor = System.Drawing.Color.White;
                con.Close();
                con.Open();
                if (cmd24.ExecuteReader().HasRows)
                {
                    button23.BackColor = System.Drawing.Color.Green;
                }
                else
                    button23.BackColor = System.Drawing.Color.White;
                con.Close();
            }
            else
            {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OKCancel);
            }




        }

        private void button_SLOT1_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "1";
            button_SLOT1.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_CustomerID.Text = "";
            textBox_CustomerName.Text = "";
            textBox_Duration.Text = "";
            textBox_VehicleNumber.Text = "";
            textBox_SlotNumber.Text = "";
            radioButton_NormalToken.Checked = false;
            radioButton_SuperToken.Checked = false;
            textBox_Duration.Enabled = false;
            //new Clerk_Form().Show();
           // this.Hide();
        }

        private void button_SLOT2_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "2";
            button_SLOT2.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT3_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "3";
            button_SLOT3.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT4_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "4";
            button_SLOT4.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT5_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "5";
            button_SLOT5.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT6_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "6";
            button_SLOT6.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT7_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "7";
            button_SLOT7.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT8_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "8";
            button_SLOT8.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT9_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "9";
            button_SLOT9.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT10_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "10";
            button_SLOT10.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT11_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "11";
            button_SLOT11.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT12_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "12";
            button_SLOT12.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT13_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "13";
            button_SLOT13.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT14_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "14";
            button_SLOT14.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT15_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "15";
            button_SLOT15.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT16_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "16";
            button_SLOT16.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT17_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "17";
            button_SLOT17.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT18_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "18";
            button_SLOT18.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT19_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "19";
            button_SLOT19.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT20_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "20";
            button_SLOT20.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT21_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "21";
            button_SLOT21.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT22_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "22";
            button_SLOT22.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_SLOT23_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "23";
            button_SLOT23.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "24";
            button23.BackColor = System.Drawing.Color.Green;
            Clerk_Load();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string query1="DELETE FROM SlotTable WHERE Slot='"+1+"'";
            string query2="DELETE FROM SlotTable WHERE Slot='"+2+"'";
            string query3="DELETE FROM SlotTable WHERE Slot='"+3+"'";
            string query4="DELETE FROM SlotTable WHERE Slot='"+4+"'";
            string query5="DELETE FROM SlotTable WHERE Slot='"+5+"'";
            string query6="DELETE FROM SlotTable WHERE Slot='"+6+"'";
            string query7="DELETE FROM SlotTable WHERE Slot='"+7+"'";
            string query8="DELETE FROM SlotTable WHERE Slot='"+8+"'";
            string query9="DELETE FROM SlotTable WHERE Slot='"+9+"'";
            string query10="DELETE FROM SlotTable WHERE Slot='"+10+"'";
            string query11="DELETE FROM SlotTable WHERE Slot='"+11+"'";
            string query12="DELETE FROM SlotTable WHERE Slot='"+12+"'";
            string query13="DELETE FROM SlotTable WHERE Slot='"+13+"'";
            string query14="DELETE FROM SlotTable WHERE Slot='"+14+"'";
            string query15="DELETE FROM SlotTable WHERE Slot='"+15+"'";
            string query16="DELETE FROM SlotTable WHERE Slot='"+16+"'";
            string query17="DELETE FROM SlotTable WHERE Slot='"+17+"'";
            string query18="DELETE FROM SlotTable WHERE Slot='"+18+"'";
            string query19="DELETE FROM SlotTable WHERE Slot='"+19+"'";
            string query20="DELETE FROM SlotTable WHERE Slot='"+20+"'";
            string query21="DELETE FROM SlotTable WHERE Slot='"+21+"'";
            string query22="DELETE FROM SlotTable WHERE Slot='"+22+"'";
            string query23="DELETE FROM SlotTable WHERE Slot='"+23+"'";
            string query24="DELETE FROM SlotTable WHERE Slot='"+24+"'";
            
            //con.Open();
            if (con.State == ConnectionState.Open)
            {

                if (textBox_SlotNumber.Text == "1")
                {
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT1.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "2")
                {
                    SqlCommand cmd = new SqlCommand(query2, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT2.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "3")
                {
                    SqlCommand cmd = new SqlCommand(query3, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT3.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "4")
                {
                    SqlCommand cmd = new SqlCommand(query4, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT4.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "5")
                {
                    SqlCommand cmd = new SqlCommand(query5, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT5.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "6")
                {
                    SqlCommand cmd = new SqlCommand(query6, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT6.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "7")
                {
                    SqlCommand cmd = new SqlCommand(query7, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT7.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "8")
                {
                    SqlCommand cmd = new SqlCommand(query8, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT8.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "9")
                {
                    SqlCommand cmd = new SqlCommand(query9, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT9.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "10")
                {
                    SqlCommand cmd = new SqlCommand(query10, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT10.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "11")
                {
                    SqlCommand cmd = new SqlCommand(query11, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT11.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "12")
                {
                    SqlCommand cmd = new SqlCommand(query12, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT12.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "13")
                {
                    SqlCommand cmd = new SqlCommand(query13, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT13.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "14")
                {
                    SqlCommand cmd = new SqlCommand(query14, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT14.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "15")
                {
                    SqlCommand cmd = new SqlCommand(query15, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT15.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "16")
                {
                    SqlCommand cmd = new SqlCommand(query16, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT16.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "17")
                {
                    SqlCommand cmd = new SqlCommand(query17, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT17.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "18")
                {
                    SqlCommand cmd = new SqlCommand(query18, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT18.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "19")
                {
                    SqlCommand cmd = new SqlCommand(query19, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT19.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "20")
                {
                    SqlCommand cmd = new SqlCommand(query20, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT20.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "21")
                {
                    SqlCommand cmd = new SqlCommand(query21, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT21.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "22")
                {
                    SqlCommand cmd = new SqlCommand(query22, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT22.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "23")
                {
                    SqlCommand cmd = new SqlCommand(query23, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT23.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "24")
                {
                    SqlCommand cmd = new SqlCommand(query24, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button23.BackColor = System.Drawing.Color.White;
                }
            }
            else if (con.State == ConnectionState.Closed)
            {
                con.Open();
                if (textBox_SlotNumber.Text == "1")
                {
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT1.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "2")
                {
                    SqlCommand cmd = new SqlCommand(query2, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT2.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "3")
                {
                    SqlCommand cmd = new SqlCommand(query3, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT3.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "4")
                {
                    SqlCommand cmd = new SqlCommand(query4, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT4.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "5")
                {
                    SqlCommand cmd = new SqlCommand(query5, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT5.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "6")
                {
                    SqlCommand cmd = new SqlCommand(query6, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT6.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "7")
                {
                    SqlCommand cmd = new SqlCommand(query7, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT7.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "8")
                {
                    SqlCommand cmd = new SqlCommand(query8, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT8.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "9")
                {
                    SqlCommand cmd = new SqlCommand(query9, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT9.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "10")
                {
                    SqlCommand cmd = new SqlCommand(query10, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT10.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "11")
                {
                    SqlCommand cmd = new SqlCommand(query11, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT11.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "12")
                {
                    SqlCommand cmd = new SqlCommand(query12, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT12.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "13")
                {
                    SqlCommand cmd = new SqlCommand(query13, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT13.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "14")
                {
                    SqlCommand cmd = new SqlCommand(query14, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT14.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "15")
                {
                    SqlCommand cmd = new SqlCommand(query15, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT15.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "16")
                {
                    SqlCommand cmd = new SqlCommand(query16, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT16.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "17")
                {
                    SqlCommand cmd = new SqlCommand(query17, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT17.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "18")
                {
                    SqlCommand cmd = new SqlCommand(query18, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT18.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "19")
                {
                    SqlCommand cmd = new SqlCommand(query19, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT19.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "20")
                {
                    SqlCommand cmd = new SqlCommand(query20, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT20.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "21")
                {
                    SqlCommand cmd = new SqlCommand(query21, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT21.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "22")
                {
                    SqlCommand cmd = new SqlCommand(query22, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT22.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "23")
                {
                    SqlCommand cmd = new SqlCommand(query23, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT23.BackColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "24")
                {
                    SqlCommand cmd = new SqlCommand(query24, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button23.BackColor = System.Drawing.Color.White;
                }
            }
            else
            {
                MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OKCancel);
            }
        }

        private void radioButton_NormalToken_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Duration.Enabled = true;
            this.Controls.Remove(label_forCheckingEmp);
            this.Controls.Remove(textBox_CheckingEmp);

        }

        private void radioButton_SuperToken_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Duration.Enabled = false;
            textBox_Duration.Text = "";
            this.Controls.Add(label_forCheckingEmp);
            // label_forCheckingEmp
            // 
            label_forCheckingEmp.AutoSize = true;
            label_forCheckingEmp.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_forCheckingEmp.Location = new System.Drawing.Point(344, 836);
            label_forCheckingEmp.Name = "label_forCheckingEmp";
            label_forCheckingEmp.Size = new System.Drawing.Size(230, 29);
            label_forCheckingEmp.TabIndex = 30;
            label_forCheckingEmp.Text = "Check EmployeID";
            // 
            // textBox_CheckingEmp
            // 
            
            this.Controls.Add(textBox_CheckingEmp);
            // textBox_CheckingEmp.Enabled = true;
            textBox_CheckingEmp.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox_CheckingEmp.Location = new System.Drawing.Point(349, 868);
            textBox_CheckingEmp.Multiline = false;
            textBox_CheckingEmp.Name = "textBox_CheckingEmp";
            textBox_CheckingEmp.Size = new System.Drawing.Size(198, 46);
            textBox_CheckingEmp.TabIndex = 29;
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            if (textBox_ClerkID.Text == string.Empty)
            {
                MessageBox.Show("Please fill the ClerkID for the Operation", "STOP", MessageBoxButtons.OKCancel);
            }
            else
            {
               try
               {



                    string slot = textBox_SlotNumber.Text;
                    int Slot = int.Parse(slot);
                    cl.ShowAllToken(Slot);
                    string TokenPrice = cl.TokenPrice1.ToString();
                    // MessageBox.Show(TokenPrice, "sample", MessageBoxButtons.OKCancel);
                    PrintDialog printD1 = new PrintDialog();
                    printD1.Document = printDocument1;
                    DialogResult result = printD1.ShowDialog();

                    if(result== DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
                catch
                {
                   MessageBox.Show("something is missing", "Error", MessageBoxButtons.OKCancel);
                }

            }
        }

        private void label_UserID_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ClerkID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            new LOGIN_Form().Show();
            this.Hide();
        }

        private void Clerk_Form_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_ClerkID_Enter(object sender, DragEventArgs e)
        {

        }

        private void textBox_ClerkID_TextChanged_1(object sender, EventArgs e)
        {
           
                
            
        }

        private void textBox_ClerkID_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ClerkID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button_FORclerkID_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT Name FROM EmpTable WHERE UserID='" + textBox_ClerkID.Text + "';";
            //con.Open();
            SqlCommand cmd = new SqlCommand(query1, con);
            if (con.State == ConnectionState.Open)
            {

                if (cmd.ExecuteNonQuery() > 1)
                {
                    MessageBox.Show("What!!!\n Try Again!!", "Wrong credential!", MessageBoxButtons.OKCancel);

                }
               


                else
                {
                    ClerkName = cmd.ExecuteScalar() as string;
                    label_ClerkName.Text = ClerkName;
                    // label_UserID.Text = UserID1;
                    textBox_ClerkID.Enabled = false;
                    if (ClerkName == null)
                    {
                        new LOGIN_Form().Show();
                        this.Hide();
                    }
                }
            }
            else if (con.State == ConnectionState.Closed)
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 1)
                {
                    MessageBox.Show("What!!!\n Try Again!!", "Wrong credential!", MessageBoxButtons.OKCancel);

                }



                else
                {
                    ClerkName = cmd.ExecuteScalar() as string;
                    label_ClerkName.Text = ClerkName;
                    // label_UserID.Text = UserID1;
                    textBox_ClerkID.Enabled = false;
                    if (ClerkName == null)
                    {
                        new LOGIN_Form().Show();
                        this.Hide();
                    }
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OKCancel);
            }
            
        }

        private void textBox_CustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
            try
            {
                string query1 = "SELECT * FROM CustomerTable";
                string query2 = "SELECT * FROM SlotTable";
              //  con.Open();
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlCommand cmd1 = new SqlCommand(query1, con);
                if (con.State == ConnectionState.Open)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(query2, con);
                    DataTable dtable = new DataTable();
                    DataTable dtable2 = new DataTable();
                    adapter.Fill(dtable);
                    adapter2.Fill(dtable2);
                    dataGridView_TokenNF.DataSource = dtable;
                    dataGridView_NF.DataSource = dtable2;


                    
                }
                else if(con.State ==ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(query2, con);
                    DataTable dtable = new DataTable();
                    DataTable dtable2 = new DataTable();
                    adapter.Fill(dtable);
                    adapter2.Fill(dtable2);
                    dataGridView_TokenNF.DataSource = dtable;
                    dataGridView_NF.DataSource = dtable2;
                }

                else
                {
                    MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OKCancel);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error!", MessageBoxButtons.OKCancel);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string TokenPrice = cl.TokenPrice1.ToString();
            string TokenID = cl.GenerateID1;
           // e.Graphics.DrawImage( );
            e.Graphics.DrawString("Token Price:- "+ TokenPrice, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Token ID:- "+TokenID, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10,50));

            e.Graphics.DrawString("Paid", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 150));
        }
    }
}
