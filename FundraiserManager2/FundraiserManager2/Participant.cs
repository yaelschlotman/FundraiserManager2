using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager2
{
    public class Participant
    {
        public Item items = new Item();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NumberOfItemsSold { get; set; }
        public decimal PersonalGoalAmount { get; set; }
        public decimal PersonalProgress { get; set; }
        public decimal PersonalOverage { get; set; }
        public decimal PersonalShortfall { get; set; }
        public bool IsPersonalGoalReached { get; set; }

        public Participant(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
