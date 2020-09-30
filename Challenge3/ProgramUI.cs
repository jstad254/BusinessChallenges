using Challenge3Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    class ProgramUI
    {
        public BadgeRepository _badgeRepository = new BadgeRepository();

        public void Run()
        {
            Menu();
        }
        private void Menu()
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                // Display Security Admin Menu
                Console.WriteLine("Hello Security Admin. What would you like to do?\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all badges");
                // Get selection
                string selection = Console.ReadLine();
                // Use switch to select method based on selection
                switch (selection)
                {
                    case "1":
                        CreateBadge();
                        break;
                    case "2":
                        UpdateBadge();
                        break;
                    case "3":
                        ListBadge();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye");
                        displayMenu = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number 1-4");
                        break;
                }
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
            }
            // Case 1 - Call create new badge method
            BadgeRepository badgeRepository = new BadgeRepository();
            public void CreateBadge()
            {
                Console.Clear();
                Badges newBadges = new Badges();
                Console.WriteLine("What is the number on the badge:");
                newBadges.BadgeID = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the badge name:");
                newBadges.BadgeName = Console.ReadLine();
                char AnotherDoor = y;
                while (AnotherDoor = y)
                {
                    Console.WriteLine("List a door that it needs access to:");

                    //List<Badges> doorList = _badgeRepository.GetBadges();
                    Console.WriteLine("Any other doors (y/n)?");
                    AnotherDoor = Console.ReadLine();
                }


                _badgeRepository.CreateBadge(newBadges);
            }
            // Case 2 - Call method to update badge... remove door, add door
            public void UpdateBadge()
            {
                bool displayMenu2 = true;
                while (displayMenu2)
                {
                    Console.WriteLine("What is the badge number to update?");

                    Console.WriteLine($"12345 has access to doors A5 & A7");

                    Console.WriteLine("What would you like to do?\n" +
                        "1. Remove a door\n" +
                        "2. Add a door\n" +
                        "3. Return to main menu");
                    string selection2 = Console.ReadLine();
                    switch (selection2)
                    {
                        case "1":
                            Console.WriteLine("Which door would you like to remove?");
                            newBadgeUpdate.doorList.Add(Console.ReadLine());
                            break;
                        case "2":
                            Console.WriteLine("Which door would you like to add?");
                            break;
                        case "3":
                            displayMenu2 = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid number 1-3");
                            break;

                    }
                }
            }

            // Case 3 - Call method to list all badges... ID and doors
            public void ListBadge()
            {
                
            }

    }

}
}
