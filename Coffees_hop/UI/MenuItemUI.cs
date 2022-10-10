using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffees_hop.UI;
using Coffees_hop.DL;
using Coffees_hop.BL;

namespace Coffees_hop.UI
{
    class MenuItemUI
    { 
        public static MenuItem AddMenuItem()
        {
            Console.Clear();
            Console.WriteLine("_______>>SUB MENU________");
            Console.Write("Enter Name :");
            string name = Console.ReadLine();
            Console.Write("Enter Type :");
            string type = Console.ReadLine();
            Console.Write("Enter Price :");
            int price = int.Parse(Console.ReadLine());
            MenuItem cmenu = new MenuItem(name, type, price);
            return cmenu;
        }
    }
}
