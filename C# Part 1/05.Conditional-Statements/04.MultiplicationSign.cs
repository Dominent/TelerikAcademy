using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double valA = Convert.ToDouble(Console.ReadLine());
            double valB = Convert.ToDouble(Console.ReadLine());
            double valC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(CheckSign(valA * valB * valC));

        }
        static char CheckSign(double input)
        {
            if (input > 0)
                return '+';
            else if (input < 0)
                return '-';
            else
                return '0';
        }
    }
}

