using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundraiserManager2
{
    public class UserData
    {
        public string GetUserInputAsString(string UserDataNeeded)
        {
            Console.WriteLine(UserDataNeeded);
            return Console.ReadLine();
        }

        public decimal GetUserInputAsDecimal(string UserDataNeeded)
        {
            Console.WriteLine(UserDataNeeded);
            return Convert.ToDecimal(Console.ReadLine());
        }

        public float GetUserInputAsFloat(string UserDataNeeded)
        {
            Console.WriteLine(UserDataNeeded);
            return Convert.ToSingle(Console.ReadLine());
        }

        public int GetUserInputAsInt(string UserDataNeeded)
        {
            Console.WriteLine(UserDataNeeded);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
