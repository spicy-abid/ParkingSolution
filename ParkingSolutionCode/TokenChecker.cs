using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSolution
{
    class Tokenchecker:Person
    {
        public Tokenchecker()
        {
        }

        public Tokenchecker(string name, ulong Nid, string type, string userID, string Password) : base(name, Nid, type, userID,Password)
        {

        }
    }

}
