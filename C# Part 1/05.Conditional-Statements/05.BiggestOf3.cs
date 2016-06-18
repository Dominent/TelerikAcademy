using System;
using System.Linq;

namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main()
        {
            double[] input = new double[3];

            for (int i = 0; i < 3; i++)
                input[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(input.Max());

        }
    }
}
