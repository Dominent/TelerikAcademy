using System;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            input = input.Replace(@"\", String.Empty);
            Console.WriteLine(input.PadRight(20, '*'));
        }
    }
}
