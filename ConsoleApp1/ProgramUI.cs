using Challenge1_KomodoCafeRepo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_KomodoCafe
{
    class ProgramUI
    {
        private MenuRepository _menuRepository = new MenuRepository();
        // Method to start running app
        public void Run()
        {
            ProgramMenu();
        }
        // Method to display and get selection from user
        private void ProgramMenu()
        {
            bool run = true;
            while (run)
            {
                //Display selections
                Console.WriteLine("Please choose a menu item:\n" +
                    "1. View menu\n" +
                    "2. Add menu item\n" +
                    "3. Delete menu item\n" +
                    "4. Exit");
                //Get input
                string selection = Console.ReadLine();
                //Switch for selections
                switch (selection)
                {
                    case "1":
                        ViewMenu();
                        break;
                    case "2":
                        AddMenuItem();
                        break;
                    case "3":
                        DeleteMenuItem();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye");
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number 1-4!");
                        break;
                }
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
            }
        }
        // Call for method to view menu
        private void ViewMenu()
        {
            Console.Clear();
            List<Menu> _listOfMenus = _menuRepository.DisplayMenu();
            // Display object parameters on each line
            foreach (Menu menuItem in _listOfMenus)
            {
                Console.WriteLine($"Number: {menuItem.Number} {menuItem.Name} - {menuItem.Description}  Price: {menuItem.Price}");
            }
        }
        // Call for method to add menu item
        private void AddMenuItem()
        {
            Console.Clear();
            Menu newMenu = new Menu();
            Console.Write("Please enter the meal number: ");
            newMenu.Number = Console.ReadLine();
            Console.Write("Please enter the meal name: ");
            newMenu.Name = Console.ReadLine();
            Console.Write("Please enter the meal description: ");
            newMenu.Description = Console.ReadLine();
            Console.Write("Please enter the meal price: $");
            newMenu.Price = Decimal.Parse(Console.ReadLine());
            Console.Write("Please enter the first ingredient: ");
            newMenu.Ingredients.Add(Console.ReadLine());
            string running = "y";
            while (running.Contains("y"))
            {
                Console.WriteLine("Is there another ingredient? (y/n): ");
                Console.ReadLine().ToLower();
                if (running.Contains("y"))
                {
                    Console.Write("Please enter the next ingredient");
                    newMenu.Ingredients.Add(Console.ReadLine());
                }
            }
                _menuRepository.AddToMenu(newMenu);
        }
        // Call for method to delete menu item
        private void DeleteMenuItem()
        {
            Console.Clear();
            ViewMenu();
            Console.Write("Please enter the number of the menu item to delete: ");
            string number = Console.ReadLine();
            bool deleteMethod = _menuRepository.RemoveFromMenu(number);
            if(deleteMethod)
            {
                Console.WriteLine("Menu item was deleted!");
            }
            else
            {
                Console.WriteLine("Unable to delete!");
            }
        }
    }
}
