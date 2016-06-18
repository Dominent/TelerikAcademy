using System;
using System.Text;

namespace DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Converter(input, 16));
        }

        static string Converter(string input, int baseNum) // Convert Decimal to Hexadecimal
        {
            string[] hexadecimal = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            long temp = Convert.ToInt64(input);

            StringBuilder sb = new StringBuilder();

            while (temp > 0)
            {
                sb.Append(hexadecimal[temp % 16]);
                temp /= baseNum;
            }

            char[] output = sb.ToString().ToCharArray();
            Array.Reverse(output);

            return new string(output);
        }
    }
}
