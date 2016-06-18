using System;
using System.Numerics;
using System.Text;

namespace BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Converter(input, 2, 16));

        }

        static string Converter(string input, int baseFrom, int baseTo) // Convert Hexadecimal to Decimal
        {
            BigInteger output = 0;

            #region From
            switch (baseFrom) // Converts everything to base 10.
            {
                case 16:
                    {
                        char[] hexadecimal =
                        {
                        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'
                        };

                        char[] temp = input.ToCharArray();
                        Array.Reverse(temp);


                        for (int i = 0; i < temp.Length; i++)
                            output += ((Array.IndexOf(hexadecimal, temp[i])) * (BigInteger)Math.Pow(16, i));
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < input.Length; i++)
                            if (input[(input.Length - 1 - i)] - '0' == 1)
                                output += (long)Math.Pow(2, i);
                        break;
                    }
                default:
                    break;
            }
            #endregion

            #region To
            switch (baseTo) // Converts from base 10 to any other base.
            {
                case 2:
                    {
                        StringBuilder sb = new StringBuilder();
                        while (output > 0)
                        {
                            if (output % 2 != 0)
                                sb.Append(1);
                            else
                                sb.Append(0);
                            output /= 2;
                        }
                        char[] temp = sb.ToString().ToCharArray();
                        Array.Reverse(temp);
                        return new string(temp);
                    }
                case 16:
                    {
                        string[] hexadecimal =
                        {
                        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E",
                        "F"
                    };
                        StringBuilder sb = new StringBuilder();
                        while (output > 0)
                        {
                            sb.Append(hexadecimal[(int)(output % 16)]);
                            output /= baseTo;
                        }
                        char[] temp = sb.ToString().ToCharArray();
                        Array.Reverse(temp);
                        return new string(temp);
                    }
                default:
                    break;
            }
            #endregion

            return output.ToString();
        }
    }
}
