using System;

namespace Cube
{
    class Cube
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string(' ', input) + new string(':', input));
            Console.WriteLine(new string(' ', input - 1) + ":" + new string('/', input - 2) + ":" + ":");

            for (int i = 1; i < input  -2; i++)
                Console.WriteLine(new string(' ', (input - 1) - i) + ":" + new string('/', input - 2) + ":" + new string('X', i) + ":");

            Console.WriteLine(" " + new string(':', input) + new string('X', input - 2) + ":");

            for (int i = input - 3; i > 0; i--)
                Console.WriteLine(" " + ":" + new string(' ', input - 2) + ":" + new string('X', i) + ":");

            Console.WriteLine(" " + ":" + new string(' ', input - 2) + "::");
            Console.WriteLine(" " + new string(':', input));

        }
    }
}
