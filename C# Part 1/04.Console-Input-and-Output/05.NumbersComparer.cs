using System;
using System.Linq;

namespace NumbersComparer
{
    class NumbersComparer
    {
        static void Main()
        {
            double[] input = new double[2];

            for (int i = 0; i < 2; i++) input[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(input.Max());
        }
    }
}
