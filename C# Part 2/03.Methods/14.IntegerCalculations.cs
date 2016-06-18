using System;
using System.Linq;

namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main(string[] args)
        {
            MinMaxSumAverageProduct(Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray());
        }

        public static void MinMaxSumAverageProduct(int[] input)
        {
            long product = 1;
            foreach (var num in input) product *= num;
            Console.WriteLine("{0}\n{1}\n{2:F2}\n{3}\n{4}\n", input.Min(), input.Max(), input.Average(), input.Sum(), product);
        }
    }
}
