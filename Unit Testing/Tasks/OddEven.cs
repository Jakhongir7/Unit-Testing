using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing.Tasks
{
    class OddEven
    {
        public static string CheckOddEven(int n)
        {
            int m = n / 2;
            if (n == 1)
            {
                return "Odd";
            }
            if (n % 2 == 0)
            {
                return "Even";
            }
            for (int i = 3; i <= m; i++)
            {
                if (n % i == 0)
                {
                    return "Odd";
                }
            }
            return "Prime";
        }
    }
}
