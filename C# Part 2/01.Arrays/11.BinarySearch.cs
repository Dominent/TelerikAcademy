using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[input];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            int pattern = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", BinarySearchRecursion(0, numbers.Length - 1, pattern, numbers));
        }

        static int BinarySearchRecursion(int low, int high, int pattern, int[] sortedArr)
        {
            if (low <= high)
            {
                int mid = (low + high) / 2;
                if (pattern == sortedArr[mid])
                    return mid;
                if (pattern > sortedArr[mid])
                    low = mid + 1;
                if (pattern < sortedArr[mid])
                    high = mid - 1;

                return BinarySearchRecursion(low, high, pattern, sortedArr);
            }
            return -1;
        }
    }
}