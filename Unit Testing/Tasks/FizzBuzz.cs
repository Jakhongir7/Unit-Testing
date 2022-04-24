using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing.Tasks
{
    class FizzBuzz
    {
        public static string ReplaceWithFizzBuzz(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (n % 3 == 0)
            {
                return "Fizz";
            }
            else if (n % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return n.ToString();
            }
        }
    }
}
