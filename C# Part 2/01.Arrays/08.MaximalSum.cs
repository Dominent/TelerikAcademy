using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[valN];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MaxSubArraySum(numbers));
        }
        static int MaxSubArraySum(int[] input)
        {
            int maxSoFar = 0, maxEndingHere = 0;
            for (int i = 0; i < input.Length; i++)
            {
                maxEndingHere +=input[i];
                if (maxEndingHere < 0) maxEndingHere = 0;
                else if (maxSoFar < maxEndingHere) maxSoFar = maxEndingHere;
            }
            return maxSoFar;
        }
    }
}
