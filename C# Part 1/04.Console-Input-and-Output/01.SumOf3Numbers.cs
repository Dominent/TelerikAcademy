using System;
using System.Linq;

namespace SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            int[] input = new int[3];
            for (int i = 0; i < 3; i++)
                input[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input.Sum());
        }
        
    }
}
