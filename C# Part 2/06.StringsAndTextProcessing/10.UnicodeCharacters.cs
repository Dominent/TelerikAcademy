using System;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();

            foreach (var ch in input) Console.Write(ToUnicode(ch));
            Console.WriteLine();
        }
        static string ToUnicode(char c) => ("\\u" + $"{(int)c:X4}");
    }
}
