using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager2
{
    public class FundraiserManager
    {
        Fundraiser fundraiser = new Fundraiser();
        UserData userData = new UserData();
        
        
        string UserChoice;

        public void SetUpFundraiser()
        {
            fundraiser.FundraiserName = userData.GetUserInputAsString("What is the fundraiser name?");
            fundraiser.GroupGoalAmount = userData.GetUserInputAsDecimal("What is the fundraiser goal amount?");
            fundraiser.ItemsForSale.ProductName = userData.GetUserInputAsString("What are you selling to reach this goal?");
            fundraiser.ItemsForSale.ProductPrice = userData.GetUserInputAsDecimal("How much does each item cost?");
            fundraiser.ItemsForSale.ProfitPerSale = userData.GetUserInputAsDecimal("How much profit per item sold in dollars and cents?");

            FIleWriter.WriteRecordToFile(fundraiser.FundraiserName + ".txt", fundraiser.FundraiserName);
            FIleWriter.AddRecordToFile(fundraiser.FundraiserName + ".txt",  fundraiser.GroupGoalAmount.ToString());
            FIleWriter.AddRecordToFile(fundraiser.FundraiserName + ".txt", "Item for Sale: " + fundraiser.ItemsForSale.ProductName);
            FIleWriter.AddRecordToFile(fundraiser.FundraiserName + ".txt", "Price: $" + fundraiser.ItemsForSale.ProductPrice);
            FIleWriter.AddRecordToFile(fundraiser.FundraiserName + ".txt", "Profit per Sale: $" + fundraiser.ItemsForSale.ProfitPerSale);

        }

        public void AddParticipantToGroup()
        {
            string FirstName = userData.GetUserInputAsString("Participant First Name?");
            string LastName = userData.GetUserInputAsString("Participant Last Name?");
            UserChoice = userData.GetUserInputAsString("Add participant? Y or N");
            while (UserChoice.ToLower() == "y")
            {
                
                fundraiser.Participants.Add(new Participant(FirstName, LastName));
                UserChoice = userData.GetUserInputAsString("Add another participant?");
            }

            
            Console.WriteLine("Participant: ");
            Console.ReadKey();      
        }

        public void BringUpExistingFundraiser()
        {
            Console.WriteLine("What is the name of your fundraiser?");

        }



    }
}
