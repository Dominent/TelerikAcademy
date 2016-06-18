namespace Patterns
{
    using System;
    using System.Linq;

    public static class Extensions
    {
        /* Fills the matrix when multiple input is given on a single line. Example: 2 10 14 15 */
        public static void Fill(this int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                var readLine = Console.ReadLine();
                if (readLine != null)
                {
                    int[] input = readLine
                        .Split(' ')
                        .Select(x => Convert.ToInt32(x))
                        .ToArray();
                    for (int j = 0; j < size; j++) matrix[i, j] = input[j];
                }
            }
        }
    }

    class Patterns
    {
        static void Main()
        {
            int size = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[size, size];

            matrix.Fill(size);

            int sum = 0;
            for (int x = 0; x < size - 2; x++)
                for (int y = 0; y < size - 4; y++)
                    sum = Math.Max(sum, Pattern(matrix, x, y));

            Console.WriteLine("{0} {1}", (sum != -1 ? "YES": "NO"), sum);

        }

        static int Pattern(int[,] matrix, int startX, int startY)
        {
            var counter = 0;
            int x = 0, y = 0;

            var previousElement = matrix[startX, startY];

            var sum = previousElement;

            while (counter < 6)
            {
                if (y < 2)
                    ++y;
                else if (x < 2)
                    ++x;
                else
                    ++y;

                int currentElement = matrix[startX + x, startY + y];

                if (currentElement != previousElement + 1)
                    return -1;

                sum += currentElement;

                ++counter;

                previousElement = currentElement;
            }

            return sum;
        }
    }
}
