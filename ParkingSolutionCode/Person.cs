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
    public class Person
{
        SqlConnection con = new SqlConnection("Data Source=ABID\\SQLEXPRESS;Initial Catalog=ParkingSolution;Integrated Security=True");

        private string name;
        private ulong Nid;
        private string UserID;
        private string Type;
        private string Password;
    //private string Address;
 
    public Person()
    {

    }
    public  Person(string name, ulong Nid,string type,string UserID,string Password)
    {
        this.Name = name;
        this.Nid1 = Nid;
        this.Type1 = type;
            this.UserID1 = UserID;
            this.Password = Password;
            this.EmployeeOp();
        
        
    }



        public string Type1 { get => Type; set => Type = value; }
        public ulong Nid1 { get => Nid; set => Nid = value; }
        public string Name { get => name; set => name = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string UserID1 { get => UserID; set => UserID = value; }

        public void EmployeeOp()
        {


            string query1 = "INSERT INTO EmpTable VALUES ('" +this.Name+ "','" + this.Type + "','" +this. UserID + "','" + this.Nid + "','" + Password1 + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query1,con);
            if(con.State==ConnectionState.Open)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted", "Serra", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show("Error!","Connection Error!",MessageBoxButtons.OKCancel);
            }
            con.Close();
            
        }


        public void ShowInfo()
    {

        }
    }
}
