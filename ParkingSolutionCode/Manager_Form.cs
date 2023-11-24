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
    public partial class Manager_Form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABID\\SQLEXPRESS;Initial Catalog=ParkingSolution;Integrated Security=True");
        double clerkSal;
        double TokenCheckerSal;
        public Manager_Form()
        {
            InitializeComponent();
        }

        private void Manager_Form_Load(object sender, EventArgs e)
        {
            string query = "SELECT SUM(TokenPrice) as Total FROM CustomerTable";

            if (con.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                   // double Amount = ;
                    textBox_Amount.Text = rdr.GetValue(1).ToString();
                   // string am = Amount.ToString();
                  // MessageBox.Show(am, "Update!", MessageBoxButtons.OKCancel);
                }
                
            
            }
            else if(con.State==ConnectionState.Closed)
            {


                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    // double Amount = ;
                    textBox_Amount.Text = rdr.GetValue(0).ToString();
                    // string am = Amount.ToString();
                    // MessageBox.Show(am, "Update!", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("Amount Didnot Update!", "Problem arise!", MessageBoxButtons.OKCancel);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "UPDATE EmpTable SET Name='"+textBox_NameUp.Text+"' WHERE UserID='"+textBox_UserID.Text+"'";
            string query1 = "UPDATE EmpTable SET Nid='"+textBox_NIDUp.Text+"' WHERE UserID='"+textBox_UserID.Text+"'";
            string query2 = "UPDATE EmpTable SET Password1='"+textBox_PassUP.Text+"' WHERE UserID='"+textBox_UserID.Text+"'";
            string query3 = "UPDATE EmpTable SET Type='CLERK' WHERE UserID='"+textBox_UserID.Text+"'";
            string query4 = "UPDATE EmpTable SET Type='CHECKER' WHERE UserID='"+textBox_UserID.Text+"'";
            

            if(radioButton_ClerkP.Checked==true)
            {
                SqlCommand cmd1 = new SqlCommand(query3, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                if (textBox_NameUp.Text != "")
                {
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                else if (textBox_NIDUp.Text != "")
                {
                    SqlCommand cmd3 = new SqlCommand(query1, con);
                    con.Open();
                    cmd3.ExecuteNonQuery();
                    con.Close();
                }
                else if (textBox_PassUP.Text != "" && textBox_ConfirmPaswUP.Text != "")
                {
                    if (textBox_PassUP.Text == textBox_ConfirmPaswUP.Text)
                    {
                        SqlCommand cmd4 = new SqlCommand(query2, con);
                        con.Open();
                        cmd4.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password did not mathed", "Try again", MessageBoxButtons.OKCancel);
                    }

                }
                else if (textBox_NameUp.Text != "" && textBox_NIDUp.Text != "" && textBox_PassUP.Text != "" && textBox_ConfirmPaswUP.Text != "")
                {
                    if(textBox_PassUP.Text==textBox_ConfirmPaswUP.Text)
                    {
                        SqlCommand cmd5 = new SqlCommand(query, con);
                        con.Open();
                        cmd5.ExecuteNonQuery();

                        SqlCommand cmd6 = new SqlCommand(query1, con);

                        cmd6.ExecuteNonQuery();

                        SqlCommand cmd7 = new SqlCommand(query2, con);

                        cmd7.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password did not mathed", "Try again", MessageBoxButtons.OKCancel);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Nothing Has to update", "Insert", MessageBoxButtons.OKCancel);
                }
            }
            else if(radioButton_TokenCheckD.Checked==true)
            {
                SqlCommand cmd1 = new SqlCommand(query4, con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                if (textBox_NameUp.Text != "")
                {
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                else if (textBox_NIDUp.Text != "")
                {
                    SqlCommand cmd3 = new SqlCommand(query1, con);
                    con.Open();
                    cmd3.ExecuteNonQuery();
                    con.Close();
                }
                else if (textBox_PassUP.Text != "" && textBox_ConfirmPaswUP.Text != "")
                {
                    if (textBox_PassUP.Text == textBox_ConfirmPaswUP.Text)
                    {
                        SqlCommand cmd4 = new SqlCommand(query2, con);
                        con.Open();
                        cmd4.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password did not mathed", "Try again", MessageBoxButtons.OKCancel);
                    }

                }
                else if (textBox_NameUp.Text != "" && textBox_NIDUp.Text != "" && textBox_PassUP.Text != "" && textBox_ConfirmPaswUP.Text != "")
                {
                    if (textBox_PassUP.Text == textBox_ConfirmPaswUP.Text)
                    {
                        SqlCommand cmd5 = new SqlCommand(query, con);
                        con.Open();
                        cmd5.ExecuteNonQuery();

                        SqlCommand cmd6 = new SqlCommand(query1, con);

                        cmd6.ExecuteNonQuery();

                        SqlCommand cmd7 = new SqlCommand(query2, con);

                        cmd7.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password did not mathed", "Try again", MessageBoxButtons.OKCancel);
                    }

                }
                else
                {
                    MessageBox.Show("Nothing Has to update", "Insert", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                if (textBox_NameUp.Text != "")
                {
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }
                else if (textBox_NIDUp.Text != "")
                {
                    SqlCommand cmd3 = new SqlCommand(query1, con);
                    con.Open();
                    cmd3.ExecuteNonQuery();
                    con.Close();
                }
                else if (textBox_PassUP.Text != "" && textBox_ConfirmPaswUP.Text != "")
                {
                    if (textBox_PassUP.Text == textBox_ConfirmPaswUP.Text)
                    {
                        SqlCommand cmd4 = new SqlCommand(query2, con);
                        con.Open();
                        cmd4.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password did not mathed", "Try again", MessageBoxButtons.OKCancel);
                    }

                }
                else if (textBox_NameUp.Text != "" && textBox_NIDUp.Text != "" && textBox_PassUP.Text != "" && textBox_ConfirmPaswUP.Text != "")
                {
                    if (textBox_PassUP.Text == textBox_ConfirmPaswUP.Text)
                    {
                        SqlCommand cmd5 = new SqlCommand(query, con);
                        con.Open();
                        cmd5.ExecuteNonQuery();

                        SqlCommand cmd6 = new SqlCommand(query1, con);

                        cmd6.ExecuteNonQuery();

                        SqlCommand cmd7 = new SqlCommand(query2, con);

                        cmd7.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password did not mathed", "Try again", MessageBoxButtons.OKCancel);
                    }

                }
                else
                {
                    MessageBox.Show("Nothing Has to update", "Insert", MessageBoxButtons.OKCancel);
                }
            }
         
        }

        private void button_RefreshEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "SELECT * FROM EmpTable";
               
                //  con.Open();
                SqlCommand cmd = new SqlCommand(query1, con);
                
                if (con.State == ConnectionState.Open)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                    
                    DataTable dtable = new DataTable();
                    
                    adapter.Fill(dtable);
                    //MessageBox.Show("Done!", "Refreshed!", MessageBoxButtons.OKCancel);


                    dataGridView_Stafflist.DataSource = dtable;
                    



                }
                else if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);


                    dataGridView_Stafflist.DataSource = dtable;

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_CustomerView_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "SELECT * FROM CustomerTable";

                //  con.Open();
                SqlCommand cmd = new SqlCommand(query1, con);

                if (con.State == ConnectionState.Open)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);


                    dataGridView_CustomerView.DataSource = dtable;




                }
                else if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);


                    dataGridView_CustomerView.DataSource = dtable;
                    con.Close();
                }

                else
                {
                    MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OKCancel);
                }
                
            }
            catch
            {
                MessageBox.Show("Error", "Error!", MessageBoxButtons.OKCancel);
            }
        }

        private void button_RevenueCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string amount = textBox_Amount.Text;
                double amnt = double.Parse(amount);
                clerkSal = amnt * 0.08;
                TokenCheckerSal = amnt * 0.05;
                double others = amnt * 0.15;
                double revenue = amnt - (clerkSal + TokenCheckerSal + others);
                textBox_Revenue.Text = revenue.ToString();
                textBox_ClerkSal.Text = clerkSal.ToString();
                textBox_TokenCheckderSal.Text = TokenCheckerSal.ToString();
                textBox_OthersInvest.Text = others.ToString();
            }
            catch
            {
                MessageBox.Show("No Customer!!! \nNo Money!!\nNo Revenue!", "Sad News", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            

            //textBox_Revenue.Text=
        }

        /*private void button_Department_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "SELECT * FROM Department";

                //  con.Open();
                SqlCommand cmd = new SqlCommand(query1, con);

                if (con.State == ConnectionState.Open)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);


                    dataGridView_VirtualBox.DataSource = dtable;




                }
                else if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);


                    dataGridView_VirtualBox.DataSource = dtable;
                    con.Close();
                }

                else
                {
                    MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OKCancel);
                }
                
            }
            catch
            {
                MessageBox.Show("Error", "Error!", MessageBoxButtons.OKCancel);
            }
        }*/

        private void button_ExitMn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_NotificationView_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_AddEmp_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBox_search.Text!="")
            {
                
                dataGridView_Stafflist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string query = "SELECT * FROM EmpTable WHERE Name LIKE '%"+textBox_search.Text+"%';";

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                DataTable dtable = new DataTable();
                con.Open();
                adapter = new SqlDataAdapter(query, con);
                
                adapter.Fill(ds);
                dv = new DataView(ds.Tables[0]);

                dataGridView_SearchBar.DataSource = dv;
                con.Close();
            }
            else
            {
                dataGridView_SearchBar.Refresh();
            }
        }

        /*private void button_NotificationView_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query1 = "SELECT * FROM ComplainBoxTable";

                //  con.Open();
                SqlCommand cmd = new SqlCommand(query1, con);

                if (con.State == ConnectionState.Open)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);


                    dataGridView_VirtualBox.DataSource = dtable;




                }
                else if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);


                    dataGridView_VirtualBox.DataSource = dtable;
                    con.Close();
                }

                else
                {
                    MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OKCancel);
                }

            }
            catch
            {
                MessageBox.Show("Error", "Error!", MessageBoxButtons.OKCancel);
            }
        }

        private void button_InsertSal_Click(object sender, EventArgs e)
        {
            /*if(textBox_InserUserID.Text=="")
            {
                MessageBox.Show("Insert UserID To add sal" .ToString(), "Missing", MessageBoxButtons.OKCancel);
            }
            else
            {
                string query = "Select Name from EmpTable where UserID='" + textBox_InserUserID + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                if (cmd.ExecuteNonQuery()<1)
                {
                    if (checkBox_Clerk.Checked == true && checkBox_TockenChecker.Checked == true)
                    {

                        MessageBox.Show("Select One! \nconfiction creating", "show", MessageBoxButtons.OKCancel);
                    }
                    else if (checkBox_TockenChecker.Checked == true)
                    {
                        string query1 = "INSERT INTO Department VALUES ('" + textBox_InserUserID + "','CHECKER',"+TokenCheckerSal+")";
                         SqlCommand cmd1 = new SqlCommand(query1, con);
                        try
                        {
                            if (cmd1.ExecuteReader().HasRows)
                            {

                                MessageBox.Show("TockenChekcer Sal inserted" + TokenCheckerSal.ToString(), "successfull", MessageBoxButtons.OKCancel);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("User ID confliction" , "successfull", MessageBoxButtons.OKCancel);
                        }
                         

                    }
                    else if (checkBox_Clerk.Checked == true)
                    {
                        string query1 = "INSERT INTO Department VALUES ('"+ textBox_InserUserID +"','CLERK',"+ clerkSal +")";
                        SqlCommand cmd1 = new SqlCommand(query1, con);
                        try
                        {
                            if (cmd1.ExecuteNonQuery()<1)
                            {

                                MessageBox.Show("Clerk Sal inserted" + clerkSal.ToString(), "successfull", MessageBoxButtons.OKCancel);
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "successfull", MessageBoxButtons.OKCancel);
                        }
                        MessageBox.Show("Clerk ", "show", MessageBoxButtons.OKCancel);
                    }
                    else
                    {
                        MessageBox.Show("Select type", "Missing", MessageBoxButtons.OKCancel);
                    }
                }
                else
                {

                    MessageBox.Show("Did not Matched UserID\nTry Again", "Try Again", MessageBoxButtons.OKCancel);
                }
                con.Close();
            
            }


        }*/

        private void button_removeEmp_Click(object sender, EventArgs e)
        {
           if(textBox_UserID.Text != "")
            {
                con.Open();
                try
                {
                    if (con.State == ConnectionState.Open)
                    {
                        string query3 = "DELETE FROM EmpTable WHERE UserID='" + textBox_UserID.Text + "'";
                        SqlCommand cmd = new SqlCommand(query3, con);
                        cmd.ExecuteNonQuery();
                        //if (cmd.ExecuteReader().HasRows)
                        //{
                        MessageBox.Show("Removed Done", "Done", MessageBoxButtons.OKCancel);
                        //}
                        //else
                       // {
                          ///  MessageBox.Show("Didnot Mathced", "Done", MessageBoxButtons.OKCancel);
                       // }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "successfull", MessageBoxButtons.OKCancel);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Employee UserID Missing", "Missing", MessageBoxButtons.OKCancel);
            }



            //if (con.State == ConnectionState.Open)
            //{
            //    SqlCommand cmd = new SqlCommand(query3, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Removed", "Done", MessageBoxButtons.OKCancel);
            //}
            //else if(con.State == ConnectionState.Closed)
            //    {
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand(query3, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Removed", "Done", MessageBoxButtons.OKCancel);
            //    con.Close();
            //}
            //else 
            //{

            //    MessageBox.Show("Erro!", "Error!", MessageBoxButtons.OKCancel);
            //}
            //con.Close();
        }

        private void textBox_UserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Stafflist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_RemoveCu_Click(object sender, EventArgs e)
        {
            if(textBox_CustomerTokenID.Text!="")
            {
                con.Open();
                try
                {
                    if (con.State == ConnectionState.Open)
                    {
                        string query3 = "DELETE FROM CustomerTable WHERE TokenID='" + textBox_CustomerTokenID.Text + "'";
                        SqlCommand cmd = new SqlCommand(query3, con);
                        cmd.ExecuteNonQuery();
                      
                            MessageBox.Show("Removed Done", "Done", MessageBoxButtons.OKCancel);
                      
                        
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "successfull", MessageBoxButtons.OKCancel);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("TokenID Missing", "Missing", MessageBoxButtons.OKCancel);
            }
            

        }

        private void label_TokenID_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ClerkID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_FORclerkID_Click(object sender, EventArgs e)
        {
            string query1 = "SELECT Name FROM EmpTable WHERE UserID='" + textBox_ManagerID.Text + "';";
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
                    string manager = cmd.ExecuteScalar() as string;
                    label_ManagerName.Text = manager;
                    // label_UserID.Text = UserID1;
                    //textBox_ClerkID.Enabled = false;
                    if (manager == null)
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
                    string manager = cmd.ExecuteScalar() as string;
                    label_ManagerName.Text = manager;
                    // label_UserID.Text = UserID1;
                    //textBox_ClerkID.Enabled = false;
                    if (manager == null)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            new LOGIN_Form().Show();
            this.Hide();
        }

        private void button_LogOut1_Click(object sender, EventArgs e)
        {
            new LOGIN_Form().Show();
            this.Hide();
        }

        private void button_removeTick_Click(object sender, EventArgs e)
        {
            radioButton_ClerkP.Checked = false;
            radioButton_TokenCheckD.Checked = false;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_ConfirmPaswUP.Text = "";
            textBox_NIDUp.Text = "";
            textBox_NameUp.Text = "";
            textBox_PassUP.Text = "";
            textBox_UserID.Text = "";
            textBox_search.Text = " ";
            radioButton_ClerkP.Checked = false;
            radioButton_TokenCheckD.Checked = false;
        }

        private void dataGridView_CustomerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
