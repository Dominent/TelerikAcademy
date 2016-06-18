using System;
using System.Linq;

namespace EvenDifferences
{
    class EvenDifferences
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToList();

            var index = 1;
            var output = 0L;
            while (index < input.Count)
            {
                var a = input[index - 1];
                var b = input[index];

                var aDiff = Math.Max(a, b) - Math.Min(a, b);

                if (aDiff % 2 == 0) // Even
                {
                    index += 2;
                    output += aDiff;
                }
                else // Odd
                {
                    index += 1;
                }

                if (index > input.Count - 1) break;
            }

            Console.WriteLine(output);
        }
    }
}
