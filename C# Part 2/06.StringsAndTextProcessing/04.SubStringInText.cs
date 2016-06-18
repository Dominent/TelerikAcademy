using System;

namespace SubStringInText
{
    class SubStringInText
    {
        static void Main()
        {
            string word = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();

            int count = -1;
           
            for (int i = 0; i < input.Length; i++)
            {
                i = input.IndexOf(word, i, StringComparison.Ordinal);
                count++;
                if(i == -1)break;
            }
            Console.WriteLine(count);
        }
    }
}
