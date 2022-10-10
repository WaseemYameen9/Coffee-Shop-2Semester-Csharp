using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffees_hop.BL;
using Coffees_hop.DL;
using Coffees_hop.UI;

namespace Coffees_hop.BL
{
    class CoffeeShop
    {
        private string name;
        private List<MenuItem> menu = new List<MenuItem>();
        private List<MenuItem> orders = new List<MenuItem>();

        public CoffeeShop()
        {
            name = "Tesha's";
        }
        public string getName()
        {
            return name;
        }

        public List<MenuItem> getMenuList()
        {
            return menu;
        }

        public List<MenuItem> getOrdersList()
        {
            return orders;
        }
    }
}
