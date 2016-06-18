using System;
using System.Linq;

namespace GetLargestNumber
{
    internal class GetLargestNumber
    {
        private static void Main()
        {
            int max = int.MinValue;
            int[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            foreach (var num in input) max = GetMax(max, num);

            Console.WriteLine(max);
        }
        public static int GetMax(int valA, int valB) => Math.Max(valA, valB);
    }
}
