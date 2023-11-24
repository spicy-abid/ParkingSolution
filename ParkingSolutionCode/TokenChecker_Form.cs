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
    public partial class TokenChecker_Form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ABID\\SQLEXPRESS;Initial Catalog=ParkingSolution;Integrated Security=True");
        public TokenChecker_Form()
        {
            InitializeComponent();
        }

        private void textBox_Attandance_TokenChecker_TextChanged(object sender, EventArgs e)
        {

        }

        private void TokenChecker_Form_Load(object sender, EventArgs e)
        {
            try
            {
                string query1 = "SELECT * FROM SlotTable";

                //  con.Open();
                SqlCommand cmd = new SqlCommand(query1, con);

                if (con.State == ConnectionState.Open)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);
                    //MessageBox.Show("Done!", "Refreshed!", MessageBoxButtons.OKCancel);


                    dataGridView_NotificationBox_TokenChecker.DataSource = dtable;




                }
                else if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);


                    dataGridView_NotificationBox_TokenChecker.DataSource = dtable;

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

        private void button_Check_Click(object sender, EventArgs e)
        {
            if (textBox_CheckToken_TokenChecker.Text != "" && textBox_checkVehicle.Text!="")
            {

                con.Open();
                try
                {
                    string query1 = "SELECT VehicleNumber FROM SlotTable WHERE TokenID='" + textBox_CheckToken_TokenChecker.Text + "';";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    // string query2 = "SELECT Name FROM EmpTable WHERE UserID='" + textBox_checkVehicle.Text + "';";
                    string vehicle = cmd1.ExecuteScalar() as string;
                    if(vehicle== textBox_checkVehicle.Text)
                    {
                        try
                        {
                            string query3 = "DELETE FROM SlotTable WHERE TokenID='" + textBox_CheckToken_TokenChecker.Text + "'";
                            SqlCommand cmd = new SqlCommand(query3, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Removed Done", "Done", MessageBoxButtons.OKCancel);
                        }
                        catch 
                        {
                            MessageBox.Show("Error", "inside Tockenckr", MessageBoxButtons.OKCancel);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Vehicle ID did not mathced", " Alert!!", MessageBoxButtons.OKCancel);
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
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            new LOGIN_Form().Show();
            this.Hide();
        }

        private void button_RefreshTokckr_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "SELECT * FROM SlotTable";

                //  con.Open();
                SqlCommand cmd = new SqlCommand(query1, con);

                if (con.State == ConnectionState.Open)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);
                    //MessageBox.Show("Done!", "Refreshed!", MessageBoxButtons.OKCancel);


                    dataGridView_NotificationBox_TokenChecker.DataSource = dtable;




                }
                else if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);

                    DataTable dtable = new DataTable();

                    adapter.Fill(dtable);


                    dataGridView_NotificationBox_TokenChecker.DataSource = dtable;

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

        private void dataGridView_NotificationBox_TokenChecker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
