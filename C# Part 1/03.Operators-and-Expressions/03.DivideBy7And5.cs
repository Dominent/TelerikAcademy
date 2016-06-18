using System;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1}", ((input % 5 == 0 && input % 7 == 0) ? "true" : "false"), input);
        }
    }
}
