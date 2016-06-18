using System;
using System.Text;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Converter(input));
        }

        static string Converter(string input) // Convert Decimal to Binary
        {
            long temp = Convert.ToInt64(input);

            StringBuilder sb = new StringBuilder();

            while (temp > 0)
            {
                if (temp % 2 != 0)
                    sb.Append(1);
                else
                    sb.Append(0);
                temp /= 2;
            }

            char[] output = sb.ToString().ToCharArray();
            Array.Reverse(output);

            return new string(output);
        }
    }
}
