using System;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int[] numbers = new int[26]; // a - z -> 26 letters
            for (int i = 0, j = 97; i < numbers.Length; i++, j++)
                numbers[i] = (char)j;

            foreach (char ch in input)
                Console.WriteLine(BinarySearchRecursion(0, numbers.Length - 1, ch, numbers));
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
