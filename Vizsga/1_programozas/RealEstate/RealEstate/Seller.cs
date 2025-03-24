using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Seller
    {
        int id;
        string name;
        string phone;
        public Seller(int id, string name, string phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }

        override
        public string ToString()
        {
            return this.id.ToString() + ", " + this.name.ToString() + ", " + this.phone.ToString();
        }
    }
}
