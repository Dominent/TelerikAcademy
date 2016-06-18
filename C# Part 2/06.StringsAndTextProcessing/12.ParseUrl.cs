using System;
using System.Text.RegularExpressions;

namespace ParseUrl
{
    class ParseUrl
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"(.*):\/\/(.+?)\/(.*)";
            var rgx = new Regex(pattern);
            var match = rgx.Match(input);

            Console.WriteLine("[protocol] = {1}\n[server] = {0}\n[resource] = {2}\n", match.Groups[2], match.Groups[1],
                "/" + match.Groups[3]);

        }
    }
}
