using System;
using System.Linq;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = new int[Math.Max(input[0], input[1]) + 1];
            int[] firstArr= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int remainder = 0;
            for (int i = 0; i < Math.Min(input[0], input[1]); i++)
            {
                result[i] = (firstArr[i] + secondArr[i] + remainder) % 10;
                remainder = (firstArr[i] + secondArr[i] + remainder) / 10;
            }

            if (input[0] > input[1])
            {
                for (int i = input[1]; i < input[0]; i++)
                {
                    result[i] = (firstArr[i] + remainder) % 10;
                    remainder = (firstArr[i] + remainder) / 10;
                }
            }
            else if (input[1] > input[0])
            {
                for (int i = input[0]; i < input[1]; i++)
                {
                    result[i] = (secondArr[i] + remainder) % 10;
                    remainder = (secondArr[i] + remainder) / 10;
                }
            }

            result[Math.Max(input[0], input[1])] = remainder;

            Console.WriteLine(String.Join(" ", result).TrimEnd('0'));
        }
    }
}
