using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffees_hop.BL
{
    class MenuItem
    {
        private string name;
        private string type;
        private int price;

        public MenuItem(string name,string type,int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }

        public string getName()
        {
            return name;
        }
        public string getType()
        {
            return type;
        }
        public int getPrice()
        {
            return price;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public void setType(string type)
        {
            this.type = type; 
        }

        public void setprice(int price)
        {
            this.price = price;
        }
    }
}
