using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProgramUI
    {
        private MenuRepository _menuRepository = new MenuRepository();

        public void Run()
        {
            ProgramMenu();
        }
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
        // Method to view menu
        private void ViewMenu()
        {

        }
        // Method to add menu item
        private void AddMenuItem()
        {

        }
        // Method to delete menu item
        private void DeleteMenuItem()
        {

        }

    }
}
