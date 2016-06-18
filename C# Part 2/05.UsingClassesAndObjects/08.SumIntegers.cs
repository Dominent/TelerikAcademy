using System;
using System.Linq;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main()
        {
            long[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt64(x)).ToArray();
            Console.WriteLine(input.Sum());
        }
    }
}
