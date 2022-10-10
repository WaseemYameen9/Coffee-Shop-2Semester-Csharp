using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffees_hop.DL;
using Coffees_hop.BL;

namespace Coffees_hop.UI
{
    class CoffeeShopUI
    {
        public static void ViewCheapest()
        {
            Console.Clear();
            Console.WriteLine("_________Cheapest item________");
            int i = CoffeeShopDL.returncheapestidx();
            Console.WriteLine("{0} \t\t {1} \t\t {2}", CoffeeShopDL.shop.getMenuList()[i].getName(), CoffeeShopDL.shop.getMenuList()[i].getType(), CoffeeShopDL.shop.getMenuList()[i].getPrice());
            Console.ReadKey();

        }

        public static void ViewDrinkMenu()
        {
            Console.Clear();
            Console.WriteLine("__________DRINK_MENU__________");
            Console.WriteLine("NAME \t\t PRICE");
            for (int i = 0; i < CoffeeShopDL.shop.getMenuList().Count; i++)
            {
                if (CoffeeShopDL.shop.getMenuList()[i].getType() == "drink")
                {
                    Console.WriteLine("{0} \t\t {1}", CoffeeShopDL.shop.getMenuList()[i].getName(), CoffeeShopDL.shop.getMenuList()[i].getPrice());
                }
            }
            Console.ReadKey();
        }
       public static void ViewFoodMenu()
        {
            Console.Clear();
            Console.WriteLine("__________FOOD_MENU__________");
            Console.WriteLine("NAME \t\t PRICE");
            for (int i = 0; i < CoffeeShopDL.shop.getMenuList().Count; i++)
            {
                if (CoffeeShopDL.shop.getMenuList()[i].getType() == "food")
                {
                    Console.WriteLine("{0} \t\t {1}", CoffeeShopDL.shop.getMenuList()[i].getName(), CoffeeShopDL.shop.getMenuList()[i].getPrice());
                }
            }
            Console.ReadKey();
        }

       public static MenuItem Addorder()
        {
            Console.Clear();
            Console.WriteLine("____________________________________");
            Console.WriteLine("Enter Your Order :");
            string order = Console.ReadLine();
            int idx = CoffeeShopDL.checkorder(order);
            MenuItem s = new MenuItem(CoffeeShopDL.shop.getMenuList()[idx].getName(), CoffeeShopDL.shop.getMenuList()[idx].getType(), CoffeeShopDL.shop.getMenuList()[idx].getPrice());
            return s;

        }
        public static void ViewOrderList()
        {
            Console.Clear();
            Console.WriteLine("______________ORDER_LIST____________");
            Console.WriteLine("NAME \t\t TYPE \t\t PRICE");
            for (int i = 0; i < CoffeeShopDL.shop.getOrdersList().Count; i++)
            {

                Console.WriteLine("{0} \t\t {1} \t\t {2}", CoffeeShopDL.shop.getOrdersList()[i].getName(), CoffeeShopDL.shop.getOrdersList()[i].getType(), CoffeeShopDL.shop.getOrdersList()[i].getPrice());

            }
            Console.ReadKey();
        }

        public static void totalpayable()
        {
            Console.Clear();
            double total = CoffeeShopDL.calculatetotal();
            Console.Write("TOTAL : {0}", total);
            Console.ReadKey();
        }
        public static bool fullfillorders()
        {
            Console.Clear();
            Console.WriteLine("                    _____________________");
            Console.WriteLine("Enter Order name :");
            string name = Console.ReadLine();
            int idx = CoffeeShopDL.checkorderList(name);
            if (idx == 20)
            {
                return false;
            }
            else
            {

                CoffeeShopDL.shop.getOrdersList().RemoveAt(idx);
                return true;
            }
        }

    }
}
