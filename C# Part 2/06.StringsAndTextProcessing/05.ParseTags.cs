using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"<upcase>(.*?)<\/upcase>";

            var rgx = new Regex(pattern);

            var strBuild = new StringBuilder(); //do it with sb beatch

            strBuild.Append(input);
            foreach (Match match in rgx.Matches(input))
                strBuild.Replace(match.ToString(), match.Groups[1].ToString().ToUpper());

            Console.WriteLine(strBuild.ToString());

        }
    }
}
