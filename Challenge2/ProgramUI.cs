using Challenge2Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class ProgramUI
    {
        private ClaimsRepository _claimsRepository = new ClaimsRepository();
        // Entry point
        public void Run()
        {
            ProgramMenu();
        }
        // User Menu
        private void ProgramMenu()
        {
            bool run = true;
            while (run)
            {
                //Display selections
                Console.WriteLine("Please choose a menu item:\n" +
                    "1. See all claims\n" +
                    "2. Take care of next claim\n" +
                    "3. Enter a new claim\n" +
                    "4. Exit");
                //Get input
                string selection = Console.ReadLine();
                //Switch for selections
                switch (selection)
                {
                    case "1":
                        SeeAllClaims();
                        break;
                    case "2":
                        NextClaim();
                        break;
                    case "3":
                        NewClaim();
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
        //Method to see all claims
        private void SeeAllClaims()
        {

        }
        //Method to take care of next claim
        private void NextClaim()
        {

        }
        //Method to enter new claim
        private void NewClaim()
        {
            Console.Clear();
            Claims claims = new Claims();
            Console.Write("Please enter the meal number: ");
            newMenu.Number = Console.ReadLine();
            Console.Write("Please enter the meal name: ");
            newMenu.Name = Console.ReadLine();
            Console.Write("Please enter the meal description: ");
            newMenu.Description = Console.ReadLine();
            Console.Write("Please enter the meal price: $");
            newMenu.Price = Decimal.Parse(Console.ReadLine());
        }

        

    }
}
