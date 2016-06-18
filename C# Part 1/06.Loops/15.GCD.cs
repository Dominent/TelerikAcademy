using System;

namespace GCD
{
    class GCD
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int valOne = Convert.ToInt32(input[0]);
            int valTwo = Convert.ToInt32(input[1]);

            Console.WriteLine(CalcGcd(Math.Abs(valOne), Math.Abs(valTwo)));
        }

        static int CalcGcd(int a, int b) {//Euclidean algorithm
            while (b != 0) {
                int Remainder = a % b;
                a = b;
                b = Remainder;
            }
            return a;
        }
    }
}
