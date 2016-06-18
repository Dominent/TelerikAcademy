using System;
using System.Linq;

namespace SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            int[] input = new int[5];

            for (int i = 0; i < 5; i++) input[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input.Sum());
        }
    }
}
