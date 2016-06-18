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

        static int BinaryConverter(string input)
        {
            char[] temp = input.ToCharArray();
            int decimalNum = 0;

            for (int i = 0; i < temp.Length; i++)
                if (temp[(temp.Length - 1 - i)] - 48 == 1) // 0 Unicode - 48
                    decimalNum += (int)Math.Pow(2, i);

            return decimalNum;
        }

    }

}
