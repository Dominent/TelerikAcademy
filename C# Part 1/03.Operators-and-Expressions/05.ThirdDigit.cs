using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 3; i++)  input /= 10;

            input %= 10;

            if (input == 7) Console.WriteLine("true");
            else Console.WriteLine("false {0}", input);
        }
    }
}
