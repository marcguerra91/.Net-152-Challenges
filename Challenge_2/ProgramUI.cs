using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
     class ProgramUI
    {   
        ClaimRepository _contentClaim = new ClaimRepository();
        Queue<Claim> queItems = new Queue<Claim>();
        public void Run()
        {
            Claim firstClaim = new Claim(1, "Car", "Car accident on 465.", 400.00m, new DateTime(2018, 04, 25), new DateTime(2018, 04, 27), true);
            Claim secondClaim = new Claim(2, "House", "House fire in kitchen.", 4000.00m, new DateTime(2018, 04, 26), new DateTime(2018, 04, 28), true);
            Claim thirdClaim = new Claim(3, "Theft", "Stolen pancakes.\t", 4.00m, new DateTime(2018, 04, 27), new DateTime(2018, 06, 01), false);
            _contentClaim.AddContentToQueue(firstClaim);
            _contentClaim.AddContentToQueue(secondClaim);
            _contentClaim.AddContentToQueue(thirdClaim);

            queItems = _contentClaim.GetClaimsQueue();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose a menu item:" +
                    "\n1. See all claims" +
                    "\n2. Take care of next claim" +
                    "\n3. Enter a new claim" +
                    "\n4. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: //see all claims
                        ViewClaimQueue();
                        break;
                    case 2: //take care of next claim
                        TakeCareOfNextClaim();
                        break;
                    case 3: //enter a new claim
                        EnterNewClaim();
                        break;
                    case 4: //exit
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid response. (1-4)");
                        Console.ReadLine();
                        break;
                }
                
            }
        }
        private void EnterNewClaim()
        {
            Claim newClaim = new Claim();
            Console.WriteLine("Please assign an identification number for the claim ID:");
            newClaim.ClaimID = int.Parse(Console.ReadLine());
            Console.WriteLine("Assign a claim type (MUST BE: Car, Home, Theft)");
            newClaim.ClaimType = Console.ReadLine();
            Console.WriteLine("Enter a description of the claim");
            newClaim.Description = Console.ReadLine();
            Console.WriteLine("Enter the claim amount");
            newClaim.ClaimAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the date of the incident in the following format: YYYY, MM, DD");
            newClaim.DateOfIncident = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter the date of the claim in the following format: YYYY, MM, DD");
            newClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("The claim must be made up to 30 days after the incident took place to be valid. Is the claim valid? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if(response == "yes")
            {
                newClaim.IsValid = true;
            }
            else
            {
                newClaim.IsValid = false;
            }
            Console.Clear();
            _contentClaim.AddContentToQueue(newClaim);
        }

        private void ViewClaimQueue()
        {
            Console.Clear();
            Queue<Claim> claimQue = _contentClaim.GetClaimsQueue();
            foreach(Claim content in claimQue)
            {
                Console.WriteLine($"ClaimID\t Type\t Description\t\t Amount\t\t DateOfAccident\t\t DateOfClaim\t\t\t\t IsValid\t\n{content.ClaimID}\t {content.ClaimType}\t {content.Description}\t ${content.ClaimAmount}\t {content.DateOfIncident}\t {content.DateOfClaim}\t\t {content.IsValid}\n\n ");
            }
        }
        private void TakeCareOfNextClaim()
        {
            Console.Clear();
            var item = queItems.Peek();
            Console.WriteLine($"ClaimID\t Type\t Description\t\t Amount\t\t DateOfAccident\t\t DateOfClaim\t\t\t\t IsValid\t\n{item.ClaimID}\t {item.ClaimType}\t {item.Description}\t ${item.ClaimAmount}\t {item.DateOfIncident}\t {item.DateOfClaim}\t\t {item.IsValid}\n");
            Console.WriteLine("\nWould you like to manage this claim? (yes/no)\n");
            string response = Console.ReadLine().ToLower();
            if(response == "yes")
            {
                queItems.Dequeue();
            }Console.Clear();
        }
    }
}
