using System;
using System.Linq;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[valN];
            int number = 0;
            int bestNumber = 0;
            int count = 1;
            int bestCount = 0;

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                number = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                    if (number == numbers[j])
                        ++count;

                if (count > bestCount)
                {
                    bestNumber = number;
                    bestCount = count;
                    
                }
                count = 1;
            }
            Console.WriteLine("{0} ({1} times)", bestNumber, bestCount);
        }
    }
}
