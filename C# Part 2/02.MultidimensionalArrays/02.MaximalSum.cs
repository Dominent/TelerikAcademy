using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        private static void Main()
        {
            int[] dimensions =
                Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];

            int sum = 0;
            int maxSum = int.MinValue;

            for (int x = 0; x < rows; x++)
            {
                int[] input =
                    Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();
                for (int y = 0; y < cols; y++)
                    matrix[x, y] = input[y];
            }

            for (int x = 0; x < rows - 2; x++)
            {
                for (int y = 0; y < cols - 2; y++)
                {
                    sum = matrix[x, y]
                                + matrix[x, y + 1]
                                + matrix[x, y + 2]
                                + matrix[x + 1, y]
                                + matrix[x + 1, y + 1]
                                + matrix[x + 1, y + 2]
                                + matrix[x + 2, y]
                                + matrix[x + 2, y + 1]
                                + matrix[x + 2, y + 2];
                            if (sum > maxSum)
                                maxSum = sum;
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
