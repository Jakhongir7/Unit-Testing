using System;
using Unit_Testing.Tasks;

namespace Unit_Testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter the Number within specified range from 1 to 100 to check Prime factor, Odd/Even and FizzBuzz (divisibility by 3 and 5): ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine(PrimeFactor.CheckPrimeComposite(num));

                Console.WriteLine(FizzBuzz.ReplaceWithFizzBuzz(num));

                Console.WriteLine(OddEven.CheckOddEven(num));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
