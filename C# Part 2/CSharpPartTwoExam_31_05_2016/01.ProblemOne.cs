using System;
using System.Numerics;
using System.Text;

namespace ExamProblemOne
{
    class ExamProblemOne
    {
        static void Main()
        {
            string firstInput = Console.ReadLine();

            string opperator = Console.ReadLine();

            string secInput = Console.ReadLine();

            BigInteger output = 0;
            switch (opperator)
            {
                case "-":
                    output = ToDecimal(firstInput) - ToDecimal(secInput);
                    Console.WriteLine(ToEbaliMuMaikata(output));
                    break;
                case "+":
                    output = ToDecimal(firstInput) + ToDecimal(secInput);
                    Console.WriteLine(ToEbaliMuMaikata(output));
                    break;
                default:
                    break;
            }
        }

        public static BigInteger ToDecimal(string input)
        {
            string[] table = new[] { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
            var strBuilder = new StringBuilder();

            for (int i = 0; i < input.Length; i += 3)
            {
                strBuilder.Append(Array.IndexOf(table, input.Substring(i, 3)));
            }

            return BigInteger.Parse(strBuilder.ToString());
        }

        public static string ToEbaliMuMaikata(BigInteger input)
        {
            string[] table = new[] { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };
            var stringosvane = input.ToString();

            var strBuilder = new StringBuilder();

            foreach (var digit in stringosvane)
            {
                strBuilder.Append(table[digit - '0']);
            }

            return strBuilder.ToString();
        }
    }
}
