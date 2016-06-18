using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class MergeSort
    {
        static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[valN];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            numbers = MergeSortRecursively(numbers);

            foreach (int num in numbers)
                Console.WriteLine(num);
        }

        public static int[] MergeSortRecursively(int[] input)
        {
            // Base case. A list of zero or one elements is sorted, by definition.
            if (input.Length <= 1)
                return input;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < input.Length; i++)
                if (i % 2 == 0)
                    right.Add(input[i]);
                else
                    left.Add(input[i]);

            left = MergeSortRecursively(left.ToArray()).ToList();
            right = MergeSortRecursively(right.ToArray()).ToList();

            return Merge(left, right);
        }

        private static int[] Merge(List<int> left, List<int> right)
        {
            List<int> output = new List<int>();

            while (left.Count > 0 && right.Count > 0)
                Result(left.First() <= right.First() ? left : right, output);

            while (left.Count > 0)
                Result(left, output);
            while (right.Count > 0)
                Result(right, output);

            return output.ToArray();
        }

        private static void Result(List<int> input, List<int> output)
        {
            output.Add(input.First());
            input.RemoveAt(0);
        }
    }
}