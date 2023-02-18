using System;
using System.Collections;
using System.Xml.Linq;


namespace ProductAutomat
{

    public class Program
    {

        readonly static Food Sandwich1 = new Food("BLT", "bröd, sallad, tomat, bacon, majonäs", 70);
        readonly static Food Sandwich2 = new Food("Toast Skagen", "bröd, sagenröda, löjrom", 90);
        readonly static Food Sandwich3 = new Food("Italian B.M.T", "bröd, salami, pepperoni, skinka", 80);

        static List<InfoProducts> foodList = new List<InfoProducts>();

        readonly static Drinks Drink1 = new Drinks("Mineralvatten", "Ramlösa", 25);
        readonly static Drinks Drink2 = new Drinks("Coca-Cola", "Läsk", 30);
        readonly static Drinks Drink3 = new Drinks("Kaffe", "Varm dryck", 20);

        static List<InfoProducts> drinkList = new List<InfoProducts>();

        readonly static Clothes Sweatshirt1 = new Clothes("Stickad Tröja", "Röd", 250);
        readonly static Clothes Sweatshirt2 = new Clothes("T-shirt", "Blå", 300);
        readonly static Clothes Sweatshirt3 = new Clothes("Tröja", "Brun", 350);

        static List<InfoProducts> clothesList = new List<InfoProducts>();


        public static void Main(String[] args)
        {

            List<MenuItem> mainMenuList = new List<MenuItem>()
            {
                new MenuItem("1.Mat"),
                new MenuItem("2.Dryck"),
                new MenuItem("3.Kläder"),
                new MenuItem("4.Saldo"),
                new MenuItem("9.Avsluta program")
            };

            Menu mainMenu = new Menu(mainMenuList);

            List<MenuItem> foodMenuList = new List<MenuItem>()
            {
                new MenuItem("1.BLT"),
                new MenuItem("2.Toast Skagen"),
                new MenuItem("3.Italian B.M.T"),
                new MenuItem("8.Gå tillbaka till huvudmeny"),
            };

            Menu foodMenu = new Menu(foodMenuList);

            List<MenuItem> drinkMenuList = new List<MenuItem>()
            {
                new MenuItem("1.Ramlösa"),
                new MenuItem("2.Coca-Cola"),
                new MenuItem("3.Kaffe"),
                new MenuItem("8.Gå tillbaka till huvudmeny"),
            };

            Menu drinkMenu = new Menu(drinkMenuList);

            List<MenuItem> clothesMenuList = new List<MenuItem>()
            {
                new MenuItem("1.Stickad tröja"),
                new MenuItem("2.T-shirt"),
                new MenuItem("3.Tröja"),
                new MenuItem("8.Gå tillbaka till huvudmeny"),
            };

            Menu clothesMenu = new Menu(clothesMenuList);


            foodList.Add(Sandwich1);
            foodList.Add(Sandwich2);
            foodList.Add(Sandwich3);

            drinkList.Add(Drink1);
            drinkList.Add(Drink2);
            drinkList.Add(Drink3);

            clothesList.Add(Sweatshirt1);
            clothesList.Add(Sweatshirt2);
            clothesList.Add(Sweatshirt3);


            Console.WriteLine("Välkommen! Var god att sätt in pengar innan du börjar handla:");
            int money = Convert.ToInt32(Console.ReadLine());
            Machine machine = new Machine(money);


            while (true)
            {
                int selectedChoice = mainMenu.printMenu();

                MenuHelper.menu(selectedChoice, foodMenu, drinkMenu, clothesMenu, foodList, drinkList, clothesList, machine);

            }



        }
    }
}













