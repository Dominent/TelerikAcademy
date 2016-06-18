using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            Console.WriteLine(Reverse(Console.ReadLine()));
        }

        public static string Reverse(string input)
        {
            char[] output = input.ToCharArray();
            Array.Reverse(output);

            return new string(output);
        }
    }
}
