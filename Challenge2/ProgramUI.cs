using Challenge2_KomodoClaimsDeptRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_KomodoClaimsDept
{
    class ProgramUI
    {
        private ClaimsRepository _claimsRepository = new ClaimsRepository();
        // Entry point
        public void Run()
        {
            SeedClaims();
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
        //Call method to see all claims
        private void SeeAllClaims()
        {
            Console.Clear();
            Console.WriteLine("ClaimID     Type     Description          Amount     DateOfAccident     DateOfClaim     IsValid");
            Queue<Claims> claimQueue = _claimsRepository.GetClaims();
            // Display object parameters on each line
            foreach (Claims claim in _claimsRepository)
            {
                Console.WriteLine($"Claim: {claim.ClaimID} {claim.TypeOfClaim} {claim.Description} {claim.ClaimAmt}{claim.DateOfIncident}{claim.DateOfClaim}{claim.IsValid}");
            }
            Console.ReadKey();
        }
        //Call method to take care of next claim... .Peek method?
        private void NextClaim()
        {
            Console.Clear();
            Queue<Claims> claimQueue = _claimsRepository.GetClaims();
            claimQueue.Peek()
            {
                Console.WriteLine($"ClaimID: {claim.ClaimID}\n" +
                    $"\n" +
                    $"Type: {claim.TypeOfClaim}\n" +
                    $"\n" +
                    $"Description: {claim.Description}\n" +
                    $"\n" +
                    $"Amount: {claim.ClaimAmt}\n" +
                    $"\n" +
                    $"DateOfAccident: {claim.DateOfIncident}\n" +
                    $"\n" +
                    $"DateOfClaim: {claim.DateOfClaim}\n" +
                    $"\n" +
                    $"IsValid: {claim.IsValid}\n" +
                    $"\n");
            }
            Console.Write("Do you want to deal with this claim now(y/n)?");
            string ans = Console.ReadLine().ToLower();
            if (ans.Contains("y"))
            {
                _claimQueue.DequeueClaims(claim);
                Console.WriteLine("Claim was taken off of queue!");
                Console.ReadKey();
            }
        }
        //Call method to enter new claim
        private void NewClaim()
        {
            Console.Clear();
            Claims newClaims = new Claims();
            Console.Write("Please enter the claim ID: ");
            newClaims.ClaimID = Console.ReadLine();
            Console.Write("Please enter the claim type... Car, Home, or Theft: ");
            newClaims.TypeOfClaim = Console.ReadLine();
            Console.Write("Please enter the claim description: ");
            newClaims.Description = Console.ReadLine();
            Console.Write("Please enter the claim amount: $");
            newClaims.ClaimAmt = Decimal.Parse(Console.ReadLine());
            Console.Write("Please enter the date the incident occurred as dd/mm/yyyy: ");
            DateTime DI = DateTime.Parse(Console.ReadLine());
            newClaims.DateOfIncident = DI;
            Console.Write("Please enter the claim date as dd/mm/yyyy: ");
            DateTime DC = DateTime.Parse(Console.ReadLine());
            newClaims.DateOfClaim = DC;
            double ClaimAge = (DC - DI).TotalDays;
            if (ClaimAge < 30)
            {
                newClaims.IsValid = true;
            }
            else
            {
                newClaims.IsValid = false;
            }
            _claimsRepository.AddClaims(newClaims);
        }
        private void SeedClaims()
        {
            DateTime C1DI = DateTime.Parse("04/25/2018");
            DateTime C1DC = DateTime.Parse("04/27/2018");
            DateTime C2DI = DateTime.Parse("04/11/2018");
            DateTime C2DC = DateTime.Parse("04/12/2018");
            DateTime C3DI = DateTime.Parse("04/27/2018");
            DateTime C3DC = DateTime.Parse("06/01/2018");
            Claims claim1 = new Claims("1", "Car", "Car accident on 465.", 400.00m, C1DI, C1DC, true);
            Claims claim2 = new Claims("2", "Home", "House fire in kitchen.", 4000.00m, C2DI, C2DC, true);
            Claims claim3 = new Claims("3", "Theft", "Stolen pancakes.", 4.00m, C3DI, C3DC, false);
            _claimsRepository.AddClaims(claim1);
            _claimsRepository.AddClaims(claim2);
            _claimsRepository.AddClaims(claim3);

        }



    }
}
