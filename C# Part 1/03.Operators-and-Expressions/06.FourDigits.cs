using System;
using System.Linq;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            int sum = input.Sum(val => (Convert.ToInt32(val) - 48));
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}",
                (input[3] - 48),
                (input[2] - 48),
                (input[1] - 48),
                (input[0] - 48));
            Console.WriteLine("{0}{1}{2}{3}",
                (input[3] - 48),
                (input[0] - 48),
                (input[1] - 48),
                (input[2] - 48));
            Console.WriteLine("{0}{1}{2}{3}",
                (input[0] - 48),
                (input[2] - 48),
                (input[1] - 48),
                (input[3] - 48));
        }
    }
}
