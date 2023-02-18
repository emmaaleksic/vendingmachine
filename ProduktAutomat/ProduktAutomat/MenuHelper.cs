
using System;
using System.Collections;

namespace ProductAutomat
{
    public class MenuHelper
    {

        public static void menu(int selectedMenuNumber,
                                Menu foodMenu,
                                Menu drinkMenu,
                                Menu clothesMenu,
                                List<InfoProducts> foodList,
                                List<InfoProducts> drinkList,
                                List<InfoProducts> clothesList,
                                Machine machine)
        {

            Console.Clear();

            switch (selectedMenuNumber)
            {
                case 0:
                    productMenu(foodMenu, foodList, machine);
                    break;
                case 1:
                    productMenu(drinkMenu, drinkList, machine);
                    break;
                case 2:
                    productMenu(clothesMenu, clothesList, machine);
                    break;
                case 3:
                    Console.WriteLine("Ditt saldo: " + machine.moneyInMachine);
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void productMenu(Menu menu,
                                       List<InfoProducts> productList,
                                       Machine machine)
        {

            int selectedProduct = menu.printMenu();
            if (selectedProduct == 7)
            {
                Console.Clear();
                return;
            }

            InfoProducts product = productList[selectedProduct];
            string name = product.Name;
            string productInfo = product.ProductInfo;
            int price = product.Price;


            Console.Clear();
            Console.WriteLine($"Vill du köpa {name} ({productInfo}) pris: {price}:-");
            Console.WriteLine("1.Ja 2.Nej");

            int buyProduct = Convert.ToInt32(Console.ReadLine());


            if (machine.moneyInMachine < price)
            {
                Console.WriteLine("Köp ej godkänt, fyll på med mer pengar.");
                Console.WriteLine("=======================================");
                return;
            }


            if (buyProduct == 1)
            {
                Console.Clear();
                product.buy();
                machine.buyProduct(price);
                Console.WriteLine("Ditt saldo: " + machine.moneyInMachine);
                product.description();
                product.use();
                Console.WriteLine("=============================");

            }

            else
            {
                Console.Clear();
                return;
            }



        }



    }

}










