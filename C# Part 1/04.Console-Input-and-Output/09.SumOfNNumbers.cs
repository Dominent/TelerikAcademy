using System;
using System.Linq;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[input];

            for (int i = 0; i < input; i++) numbers[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0}",(int)numbers.Sum());
        }
    }
}
