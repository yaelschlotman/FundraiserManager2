using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager2
{
    public class Fundraiser
    {
        
        public Item ItemsForSale = new Item();
        public string FundraiserName { get; set; }
        public decimal GroupGoalAmount { get; set; }
        public int NumberOfItemsSold { get; set; }
        public decimal GroupProgess { get; set; }
        public bool  IsGroupGoalReached { get; set; }

        public List<Participant> Participants = new List<Participant>();


    }
}
