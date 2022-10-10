using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffees_hop.DL;
using Coffees_hop.BL;
using Coffees_hop.UI;
using System.IO;

namespace Coffees_hop.DL
{
    class CoffeeShopDL
    {
        public static CoffeeShop shop = new CoffeeShop();

        public static int returncheapestidx()
        {
            int x = 0;
            int cheapest = shop.getMenuList()[0].getPrice();
            for (int i = 0; i < shop.getMenuList().Count; i++)
            {
                if (cheapest > shop.getMenuList()[i].getPrice())
                {
                    x = i;
                }
            }
            return x;
        }

        public static int checkorder(string order)
        {
            for (int i = 0; i < shop.getMenuList().Count; i++)
            {
                if (shop.getMenuList()[i].getName() == order)
                {
                    return i;
                }
            }
            return -1;
        }
        public static double calculatetotal()
        {
            double total = 0;
            for (int i = 0; i < shop.getOrdersList().Count; i++)
            {
                total = total + shop.getOrdersList()[i].getPrice();
            }
            return total;
        }

        public static int checkorderList(string name)
        {
            for (int i = 0; i < shop.getOrdersList().Count; i++)
            {
                if (shop.getMenuList()[i].getName() == name)
                {
                    return i;
                }
            }
            return 20;
        }

        public static void store1()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\Coffees_hop\\data.txt";
            StreamWriter f = new StreamWriter(path);
            for (int i = 0; i < shop.getMenuList().Count; i++)
            {
                f.WriteLine("{0},{1},{2}", shop.getMenuList()[i].getName(), shop.getMenuList()[i].getType(), shop.getMenuList()[i].getPrice());

            }
            f.Flush();
            f.Close();
        }
        public static void store2()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\Coffees_hop\\data2.txt";
            StreamWriter f = new StreamWriter(path);
            for (int i = 0; i < shop.getOrdersList().Count; i++)
            {
                f.WriteLine("{0},{1},{2}", shop.getOrdersList()[i].getName(), shop.getOrdersList()[i].getType(), shop.getOrdersList()[i].getPrice());

            }
            f.Flush();
            f.Close();
        }

        public static void load1()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\Coffees_hop\\data.txt";
            StreamReader f = new StreamReader(path);
            string record;
            while((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                string name = splittedrecord[0];
                string type = splittedrecord[1];
                int price = int.Parse(splittedrecord[2]);
                MenuItem s = new MenuItem(name, type, price);
                CoffeeShopDL.shop.getMenuList().Add(s);
            }
            f.Close();
        }
        public static void load2()
        {
            string path = "E:\\Semester 2\\OOP\\week5\\Assignment\\Coffees_hop\\data2.txt";
            StreamReader f = new StreamReader(path);
            string record;
            while ((record = f.ReadLine()) != null)
            {
                string[] splittedrecord = record.Split(',');
                string name = splittedrecord[0];
                string type = splittedrecord[1];
                int price = int.Parse(splittedrecord[2]);
                MenuItem s = new MenuItem(name, type, price);
                CoffeeShopDL.shop.getOrdersList().Add(s);
            }
            f.Close();

        }

    }
}

        
    

