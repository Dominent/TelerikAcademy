using System;
using System.Text.RegularExpressions;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
            Console.WriteLine(Regex.Replace(Console.ReadLine(), "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)"));
        }
    }
}
