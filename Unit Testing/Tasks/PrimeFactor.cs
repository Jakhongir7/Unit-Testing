using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing.Tasks
{
    public class PrimeFactor
    {
        public static string CheckPrimeComposite(int n)
        {
            int m = n / 2;
            if (n <= 0 || n > 100) throw new ArgumentOutOfRangeException("You should provide some text.");
            if (n == 1)
            {
                return "1";
            }
            else if (n == 2 || n == 3)
            {
                return "Prime";
            }
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    return "Composite";
                }
            }
            return "Prime";
        }
    }
}
