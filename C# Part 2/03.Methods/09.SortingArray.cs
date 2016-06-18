using System;
using System.Linq;

namespace SortingArray
{
    class SortingArray
    {
        static void Main()
        {
            int index = Convert.ToInt32(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Console.WriteLine(String.Join(" ", SortArr(input, index)));
        }

        static int[] SortArr(int[] arr, int maxNumbers)
        {
            Array.Sort(arr);
            if (arr.Length <= maxNumbers)
                Array.Resize(ref arr,maxNumbers);

            return arr;
        }
    }
}
