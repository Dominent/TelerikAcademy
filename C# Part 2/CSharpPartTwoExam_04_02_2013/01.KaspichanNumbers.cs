using System;
using System.Collections.Generic;
using System.Text;

namespace KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main()
        {
            var list = new List<string>();

            const string lowerCase = " abcdefghi";
            const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var strBuilder = new StringBuilder();

            foreach (char lowerLetter in lowerCase)
            {
                foreach (char upperLetter in upperCase)
                {
                    strBuilder.Append(lowerLetter);
                    strBuilder.Append(upperLetter);
                    list.Add(strBuilder.ToString().Trim(' '));
                    strBuilder.Clear();
                }
            }

            ulong input = Convert.ToUInt64(Console.ReadLine());
            if (input == 0)
            {
                Console.WriteLine("A");
            }
            else
            {
                strBuilder.Clear();
                while (input > 0)
                {
                    strBuilder.Insert(0, list[(int)(input % 256)]);
                    input /= 256;
                }
                Console.WriteLine(strBuilder.ToString());
            }

        }
    }
}
