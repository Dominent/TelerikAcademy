using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace MultiverseCommunication
{
    class MultiverseCommunication
    {
        static void Main()
        {
            const string hexKey = "0123456789ABCDEF";
            string[] digits = { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA" };

            string input = Console.ReadLine();
            var strBuild = new StringBuilder();
            var index = new List<char>();

            for (int i = 1; i <= input.Length; i++)
            {
                strBuild.Append(input[i - 1]);
                if (i % 3 == 0)
                {
                    var temp = Array.IndexOf(digits, strBuild.ToString());
                    index.Add(hexKey[temp]);
                    strBuild.Clear();
                }
            }
            strBuild.Clear();
            foreach (var num in index)
            {
                strBuild.Append(num);
            }

            Console.WriteLine(FromAnyBase(strBuild.ToString(), 13));
        }

        private static string FromAnyBase(string input, int baseFrom)
        {
            const string numbers = "0123456789ABCDEF";
            return input.Aggregate<char, BigInteger>(0, (current, digit) => (BigInteger)(numbers.IndexOf(digit.ToString(), StringComparison.Ordinal) + current * baseFrom)).ToString();
        }
    }
}
