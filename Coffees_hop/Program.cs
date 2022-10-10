using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coffees_hop.BL;
using Coffees_hop.DL;
using Coffees_hop.UI;

namespace Coffees_hop
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            CoffeeShopDL.load1();
            CoffeeShopDL.load2();
            bool flag = true;
            while (flag)
            {
                int option = MainMenuUI.menu();
                if(option == 1)
                {
                   CoffeeShopDL.shop.getMenuList().Add(MenuItemUI.AddMenuItem());
                }
                if(option == 2)
                {
                    CoffeeShopUI.ViewCheapest();
                }
                if(option == 3)
                {
                    CoffeeShopUI.ViewDrinkMenu();
                }
                if(option == 4)
                {
                   CoffeeShopUI.ViewFoodMenu();
                }
                if(option == 5)
                {
                    CoffeeShopDL.shop.getOrdersList().Add(CoffeeShopUI.Addorder());
                    Console.WriteLine("___ORDER_ADDED____");
                    Console.ReadKey();
                }
                if(option == 6)
                {
                    bool flag1 = CoffeeShopUI.fullfillorders();

                    if (flag1 == true)
                    {
                        Console.Write("____ORDER_FULFILED____");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("____ITEM_DOES_NOT_EXIST____");
                        Console.ReadKey();
                    }
                }
                if(option == 7)
                {
                    CoffeeShopUI.ViewOrderList();
                }
                if(option == 8)
                {
                    CoffeeShopUI.totalpayable();
                }
                if(option == 9)
                {
                    CoffeeShopDL.store1();
                    CoffeeShopDL.store2();
                    flag = false;
                }

            }
        }

    }
}
