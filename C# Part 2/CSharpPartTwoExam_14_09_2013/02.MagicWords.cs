using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagicWords
{
    class MagicWords
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var input = new List<string>();

            for (int i = 0; i < n; i++) input.Add(Console.ReadLine());

            var strBuilder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                int index = (input[i].Length % (n + 1));
                var word = input[i];

                input[i] = null;
                input.Insert(index, word);
                input.Remove(null);
            }

            var maxLength = input.Max(x => x.Length);

            for (int i = 0; i < maxLength; i++)
            {
                foreach (var str in input.Where(str => str.Length > i))
                {
                    strBuilder.Append(str[i]);
                }
            }
            Console.WriteLine(strBuilder.ToString());
        }
    }
}
