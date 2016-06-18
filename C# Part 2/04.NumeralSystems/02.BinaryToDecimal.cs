using System;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(BinaryConverter(input));
        }

        static long BinaryConverter(string input)
        {
            long decimalNum = 0;

            for (int i = 0; i < input.Length; i++)
                if (input[(input.Length - 1 - i)] - '0' == 1)
                    decimalNum += (long)Math.Pow(2, i);

            return decimalNum;
        }
    }
}
