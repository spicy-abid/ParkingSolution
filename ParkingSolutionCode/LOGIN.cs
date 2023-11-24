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
    class LOGIN
    {
        SqlConnection con = new SqlConnection("Data Source=ABID\\SQLEXPRESS;Initial Catalog=ParkingSolution;Integrated Security=True");
        private string userID;
        private string Password;
        

        public LOGIN()
        {
        }

        public LOGIN(string userID, string password)
        {
            

            this.UserID = userID;
            this.Password1 = password;
            

        }

        public string UserID { get => userID; set => userID = value; }
        public string Password1 { get => Password; set => Password = value; }

        public bool LogINOp()
        {

            bool flag=false;
            string type;
            string query1 = "SELECT Type FROM EmpTable WHERE UserID='"+userID+"' and Password1='"+Password+"'";
            con.Open();
            
            SqlCommand cmd = new SqlCommand(query1, con);
            if (con.State == ConnectionState.Open)
            {
               
                if (cmd.ExecuteNonQuery()>1)
                {
                    MessageBox.Show("What!!!\n Try Again!!", "Wrong credential!", MessageBoxButtons.OKCancel);
                    
                }
            else
                {
                    type = cmd.ExecuteScalar() as string;
                   
                    if (type == "CLERK")
                    {
                       new Clerk_Form().Show();
                       
                        flag = true;
                    }
                    else if (type == "MANAGER")
                    {
                        new Manager_Form().Show();
                        flag = true;
                    }
                    else if(type =="CHECKER")
                    {
                        new TokenChecker_Form().Show();
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show("UserID or Password Invalid\n Try Again!!", "Wrong credential!", MessageBoxButtons.OKCancel);

                    }
                }
            }
            else
            {
                MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OKCancel);
            }
            con.Close();
            return flag;
        }
    }
}
