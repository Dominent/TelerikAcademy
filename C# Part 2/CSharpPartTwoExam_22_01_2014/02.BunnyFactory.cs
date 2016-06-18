using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace BunnyFactory
{
    class BunnyFactory
    {
        static void Main()
        {
            GetOutput(ReadInput());
        }

        public static string ReadInput()
        {
            var strBuilder = new StringBuilder();

            string input = Console.ReadLine();
            strBuilder.Append(input);
            while (input != "END")
            {
                input = Console.ReadLine();
                if (input != null && char.IsDigit(input[0])) strBuilder.Append(input);
            }

            return strBuilder.ToString();
        }

        public static void GetOutput(string input)
        {
            var strBuilder = new StringBuilder(input);

            int counter = 0;
            while (true)
            {
                if (counter < strBuilder.Length)
                    counter++;
                else
                    break;

                var s = 0;
                for (int i = 0; i < counter; i++) s += (strBuilder[i] - '0');

                if (strBuilder.Length >= s)
                    strBuilder.Remove(0, counter);
                else
                    break;

                int sum = 0;
                BigInteger product = 1;

                for (int i = 0; i < s; i++)
                {
                    sum += (strBuilder[i] - '0');
                    product *= (strBuilder[i] - '0');
                }
                strBuilder.Remove(0, s);

                strBuilder.Insert(0, product);
                strBuilder.Insert(0, sum);

                for (int i = 0; i < 2; i++) strBuilder.Replace(i.ToString(), String.Empty);
            }

            for (int i = 0; i < strBuilder.Length - 1; i++)
                Console.Write(strBuilder[i] + " ");
            Console.WriteLine(strBuilder.ToString().Last());
        }
    }
}
