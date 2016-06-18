using System;
using System.Linq;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main()
        {
            var input =
                Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

            bool[] hasStepped = new bool[input.Count];

            var count = Convert.ToInt32(Console.ReadLine());

            long sum = 0;

            for (int i = 0; i < count; i++)
            {
                var pattern = Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

                var coins = input[0];
                var index = 0;

                hasStepped[index] = true;

                for (int j = 0; j < pattern.Count; j++)
                {
                    index += pattern[j];
                    if(index < 0 || index > input.Count - 1) break;

                    if (!hasStepped[index])
                    {
                        coins += input[index];
                        hasStepped[index] = true;
                    }
                    else
                        break;

                    if (j == pattern.Count - 1)
                    {
                        j = -1;
                    }
                }
                sum = Math.Max(sum, coins);

                Array.Clear(hasStepped, 0, hasStepped.Length);
            }

            Console.WriteLine(sum);
        }

    }
}
