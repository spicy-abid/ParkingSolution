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
    public class Clerk: Person
    {
        SqlConnection con = new SqlConnection("Data Source=ABID\\SQLEXPRESS;Initial Catalog=ParkingSolution;Integrated Security=True");
        private int slot;
        private int uniqId;
        private Token[] token = new Token[25];
        private string vehicleNumber;
        private String GenerateID;
        private string Ttype;
        private double Duration;
        //double d;
        private static double TokenPrice;
        //private double price;
        public Clerk() 
        {

        }
        public Clerk(string name, ulong Nid,  string type,string userID,string Password):base( name, Nid,type,userID,Password)
        {
            
         
            


        }



        public int UniqId
        {
            set { UniqId1 = value; }

        }

        public string VehicleNumber { get => vehicleNumber; set => vehicleNumber = value; }
        public int Slot { get => slot; set => slot = value; }
        public int UniqId1 { get => uniqId; set => uniqId = value; }
        public double Duration1 { get => Duration; set => Duration = value; }
        public string Ttype1 { get => Ttype; set => Ttype = value; }
        public double TokenPrice1 { get => TokenPrice;}
        public string GenerateID1 { get => GenerateID;}

        public bool InsertToken(Token t)
        {

            //bool flag = false;
            // for(int i=1; i<token.Length;i++)
            //{
            // if (token==null)
            //{

            //flag = true;
            // break;
            //}
            // }
            token[slot] = t;
            token[slot].PriceOperation(Duration);
            if (token[slot] == null)
                return false;
            return true;

            
        }
        public void TokenOperation()
        {
            GenerateID = Name.Substring(0, 1) + vehicleNumber;
            Token to = new Token(GenerateID1, Type1, slot);
            
            
            InsertToken(to);
            if (InsertToken(to)==true)
            {
                string query1 = "INSERT INTO SlotTable VALUES ('" + slot + "','" + GenerateID1 + "','" + vehicleNumber + "')";
  
                con.Open();
                SqlCommand cmd = new SqlCommand(query1, con);
                
                if (con.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Booked", "Token", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Error!", "From insert token!", MessageBoxButtons.OKCancel);
                }
                con.Close();

               
            }
            else
            {
                MessageBox.Show("Ooops Sorry", "Error", MessageBoxButtons.OKCancel);
            }
        }
        public void ShowAllToken(int t)
        {
            /*  for(int i= 1;i<token.Length;i++)
              {
                  if(token[t]!=null)
                  {
                      token[t].show();
                      break;
                  }
                  else
                  {
                      MessageBox.Show("Oops Sorry\nSomething Wrong", "Empty", MessageBoxButtons.OKCancel);
                      break;
                  }
              }*/
            try
            {
                TokenPrice = token[t].Price;
                string Price = TokenPrice.ToString();

                string query2 = "INSERT INTO CustomerTable VALUES ('" + Name + "','" + Nid1 + "','" + GenerateID1 + "','" + vehicleNumber + "','" + TokenPrice + "','" + Ttype1 + "')";

                SqlCommand cmd1 = new SqlCommand(query2, con);
                if (con.State == ConnectionState.Open)
                {

                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Successfully inserted in the Customer", "Serra", MessageBoxButtons.OKCancel);
                }
                else if
                    (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Successfully inserted in the Customer ", "Serra", MessageBoxButtons.OKCancel);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Error!", "From Show all token!", MessageBoxButtons.OKCancel);
                }

               // MessageBox.Show(Price + "\n" + GenerateID, "welcome", MessageBoxButtons.OKCancel);
            }
            catch(Exception ex)
            {

                MessageBox.Show("Error!\n"+ex.ToString(), "Inside Clerk!", MessageBoxButtons.OKCancel);
            }
            
             

        }
       // public bool CustomerTableOp(int t)
        //{
        //    bool flag = false;
            
           // return Flag;
       // }
        

    }
}
