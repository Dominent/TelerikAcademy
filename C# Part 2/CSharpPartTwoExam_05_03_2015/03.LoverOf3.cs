using System;
using System.Linq;

namespace LoverOf3
{
    class LoverOf3
    {
        public enum Directions
        {
            UKNOWN,
            UP_RIGHT,
            DOWN_RIGHT,
            UP_LEFT,
            DOWN_LEFT
        }

        static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(z => Convert.ToInt32(z)).ToArray();

            ulong[,] matrix = new ulong[dimensions[0], dimensions[1]];

            FillMatrix(matrix);

            var ouput = GetOutput(matrix);

            Console.WriteLine(ouput);
        }

        public static void FillMatrix(ulong[,] matrix)
        {
            var lengthX = matrix.GetLength(0);
            var lengthY = matrix.GetLength(1);

            for (long x = lengthX - 1, counter = 0; x > -1; x--, counter += 3)
            {
                var newCounter = counter;
                for (long y = 0; y < lengthY; y++)
                {
                    matrix[x, y] = (ushort)newCounter;
                    newCounter += 3;
                }
            }
        }

        public static void PrintMatrix(ulong[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static Directions GetDirection(string input)
        {
            var dir = Directions.UKNOWN;
            switch (input)
            {
                case "RU":
                case "UR":
                    dir = Directions.UP_RIGHT;
                    break;
                case "LU":
                case "UL":
                    dir = Directions.UP_LEFT;
                    break;
                case "DL":
                case "LD":
                    dir = Directions.DOWN_LEFT;
                    break;
                case "DR":
                case "RD":
                    dir = Directions.DOWN_RIGHT;
                    break;
            }
            return dir;
        }

        public static ulong GetOutput(ulong[,] matrix)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            ulong sum = 0;

            var x = matrix.GetLength(0) - 1;
            var y = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                var dir = GetDirection(input[0]);
                var moves = Convert.ToInt32(input[1]);

                bool collision = false;
                for (int j = 1; j < moves; j++)
                {
                    if (collision) break;
                    if (dir == Directions.UP_RIGHT)
                    {
                        if ((x - 1 >= 0 && y + 1 < matrix.GetLength(1)))
                        {
                            --x;
                            ++y;
                            sum += GetValue(matrix, x, y);
                        }
                        else
                        {
                            collision = true;
                            break;
                        }
                    }
                    else if (dir == Directions.UP_LEFT)
                    {
                        if ((x - 1 >= 0 && y - 1 >= 0))
                        {
                            --x;
                            --y;
                            sum += GetValue(matrix, x, y);
                        }
                        else
                        {
                            collision = true;
                            break;
                        }
                    }
                    else if (dir == Directions.DOWN_RIGHT)
                    {
                        if ((x + 1 < matrix.GetLength(0) && y + 1 < matrix.GetLength(1)))
                        {
                            ++x;
                            ++y;
                            sum += GetValue(matrix, x, y);
                        }
                        else
                        {
                            collision = true;
                            break;
                        }
                    }
                    else if (dir == Directions.DOWN_LEFT)
                    {
                        if ((x + 1 < matrix.GetLength(0) && y - 1 < matrix.GetLength(1)))
                        {
                            ++x;
                            --y;
                            sum += GetValue(matrix, x, y);
                        }
                        else
                        {
                            collision = true;
                            break;
                        }
                    }
                }

            }
            return sum;
        }

        public static ulong GetValue(ulong[,] matrix, int x, int y)
        {
            if (matrix[x, y] != 1)
            {
                var number = matrix[x, y];
                matrix[x, y] = 1;
                return number;
            }
            return 0;
        }
    }
}
