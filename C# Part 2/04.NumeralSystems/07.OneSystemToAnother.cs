using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace OneSystemToAnother
{
    public static class ConvertTo
    {
        public static string ConvertFromAnyToAny(this string input, int baseFrom, int baseTo)
            => ToAnyBase(FromAnyBase(input, baseFrom), baseTo);

        private static string FromAnyBase(string input, int baseFrom)
        {
            const string numbers = "0123456789ABCDEF";
            return input.Aggregate<char, BigInteger>(0, (current, digit) => (BigInteger)(numbers.IndexOf(digit.ToString(), StringComparison.Ordinal) + current * baseFrom)).ToString();
        }

        private static string ToAnyBase(string input, int baseTo)
        {
            const string numbers = "0123456789ABCDEF";
            StringBuilder sb = new StringBuilder();
            BigInteger output = BigInteger.Parse(input);
            while (output > 0)
            {
                sb.Insert(0, numbers[(int)(output % baseTo)]);
                output /= baseTo;
            }
            return sb.ToString();
        }
    }

    class OneSystemToAnother
    {
        static void Main()
        {
            int baseFrom = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            int baseTo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input.ConvertFromAnyToAny(baseFrom, baseTo));
        }
    }
}
