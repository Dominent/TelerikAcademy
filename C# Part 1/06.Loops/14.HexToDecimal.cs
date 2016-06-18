using System;
using System.Numerics;
using System.Text;

namespace HexToDecimal
{
    class HexToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Converter(input));
        }

        static BigInteger Converter(string input) // Convert Hexadecimal to Decimal
        {
            char[] hexadecimal = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            BigInteger sum = 0;

            for (int i = 0; i < temp.Length; i++)
                sum += ((Array.IndexOf(hexadecimal, temp[i])) * (BigInteger)Math.Pow(16, i));

            return sum;
        }
    }

}
