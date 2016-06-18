using System;
using System.Text.RegularExpressions;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"[^(?!.*\b(\(|\))\b).*$]";
            var rgx = new Regex(pattern);
            input = rgx.Replace(input, "");

            int opBracket = 0;
            int clBracket = 0;
            bool isCorrect = false;

            foreach (var ch in input)
            {
                if (ch == '(')
                    opBracket++;
                if (ch == ')')
                    clBracket++;
            }

            if (opBracket == clBracket) isCorrect = true;
            Console.WriteLine(isCorrect ? "Correct" : "Incorrect");
        }
    }
}
