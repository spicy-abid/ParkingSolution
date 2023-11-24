using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingSolution
{
    public class Token
    {
        /* private double date;
         
        
        private double penalty;*/
        private string TokenID;
        private double price;
        //double Duration;
        private string TokenType;
        private int slot;
        



        public Token()
        {

        }

        public Token(string tokenID, string tokenType,int slot)
        {
            TokenID1 = tokenID;
            TokenType1 = tokenType;
            this.Slot = slot;
        }
        public string TokenID1 { get => TokenID; set => TokenID = value; }
        public double Price { get => price; set => price = value; }
        public string TokenType1 { get => TokenType; set => TokenType = value; }
        public int Slot { get => slot; set => slot = value; }

        public void PriceOperation(double Duration)
        {
             price = Duration * 50;
            
          
        }
        public void panaltyCount(double penalty)
        {

        }
        public void FreeOrPaidChecker()
        {

        }
        public void Show()
        {
            
            string Price = price.ToString();

         //   MessageBox.Show(Price+"\n"+TokenID1, "welcome", MessageBoxButtons.OKCancel);
            
            
        }
    }
}
