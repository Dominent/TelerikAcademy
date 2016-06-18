using System;

namespace QuickSort
{
    internal class QuickSort
    {
        private static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[valN];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            QuickSortRecursively(numbers, 0, numbers.Length - 1);

            foreach (int num in numbers)
                Console.WriteLine(num);
        }

        private static void QuickSortRecursively(int[] numbers, int start, int end)
        {
            if (start < end)
            {
                int pivot = numbers[end];
                int pivotIndex = start;

                for (int i = start; i < end; i++)
                {
                    if (numbers[i] <= pivot)
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[pivotIndex];
                        numbers[pivotIndex] = temp;

                        pivotIndex++;
                    }
                }

                numbers[end] = numbers[pivotIndex];
                numbers[pivotIndex] = pivot;

                QuickSortRecursively(numbers, start, pivotIndex - 1);
                QuickSortRecursively(numbers, pivotIndex + 1, end);
            }
        }
    }
}
