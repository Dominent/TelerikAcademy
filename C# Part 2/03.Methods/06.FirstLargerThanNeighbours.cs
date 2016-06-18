using System;
using System.Linq;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            Console.WriteLine(Check(input));
        }

        static int Check(int[] input)
        {
            int count = 0;
            for (int i = 1; i < input.Length - 1; i++) if (input[i] > input[i - 1] && input[i] > input[i + 1])
            {
                return i;
            }
            return -1;
        }
    }
}
