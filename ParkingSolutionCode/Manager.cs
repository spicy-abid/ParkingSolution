using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSolution
{
    class Manager:Person
    {
        private string GeneratedUserID;

        public Manager()
        {

        }

        public Manager(string name, ulong Nid, string type, string userID, string Password) : base(name, Nid, type, userID,Password)
        {

        }

        public string GeneratedUserID1 { get => GeneratedUserID; set => GeneratedUserID = value; }
    }
}
