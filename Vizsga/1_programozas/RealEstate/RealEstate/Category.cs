using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate
{
    internal class Category
    {
        private int id;
        private string name;
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        override
        public string ToString()
        {
            return id.ToString() + ", " + name.ToString();
        }
    }
}
