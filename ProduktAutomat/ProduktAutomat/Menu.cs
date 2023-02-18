using System;
namespace ProductAutomat
{
    public class Menu
    {
        private List<MenuItem> menuItems { get; }

        public Menu(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }


        public int printMenu()
        {
            foreach (MenuItem menuItem in menuItems)
            {
                Console.WriteLine(menuItem.Menutext);
            }


            int selectedChoice = Convert.ToInt32(Console.ReadLine());
            return selectedChoice - 1;

        }

    }
}

