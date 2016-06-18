using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace CalculationProblem
{
    class CalculationProblem
    {
        static long MeowToDec(string meow)
        {
            long result = 0;

            foreach (var digit in meow)
            {
                result = (digit - 'a') + result * 23;
            }

            return result;
        }

        static string DecToMeow(long meow)
        {
            var strBuilder = new StringBuilder();

            const string table = "abcdefghijklmnopqrstuvw";

            while (meow > 0)
            {
                strBuilder.Insert(0, table[(int)(meow % 23)]);
                meow /= 23;
            }

            return strBuilder.ToString();
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            long sum = 0;

            foreach (var str in input)
            {
                sum += MeowToDec(str);
            }

            Console.WriteLine("{0} = {1}", DecToMeow(sum), sum);
        }
    }
}
