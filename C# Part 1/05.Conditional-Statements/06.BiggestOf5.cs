using System;
using System.Linq;

namespace BiggestOf5
{
    class BiggestOf5
    {
        static void Main()
        {
            double[] input = new double[5];

            for (int i = 0; i < 5; i++)
                input[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(input.Max());
        }
    }
}
