using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager2
{
    class GoalTracker
    {
        //write up functions for calculating sales totals, goal progress.

        Fundraiser fundraiser = new Fundraiser();

        decimal GoalAmount;
        decimal PersonalGoalAmount;
        int NumberOfItemsSold;
        decimal ProgressTowardGoal;
        decimal Overage;
        decimal Shortfall;
        bool IsGoalAmountReached;
        decimal PricePerItem;
        decimal ProfitPerSale;

        public decimal SetPersonalGoalAmount()
        {
            return PersonalGoalAmount = GoalAmount / fundraiser.Participants.Count();            
        }

        public decimal GetProgressTowardGoal()
        {
            return GoalAmount; 
        }
    }
}
