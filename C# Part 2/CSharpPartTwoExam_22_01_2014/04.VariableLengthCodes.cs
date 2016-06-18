using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariableLengthCodes
{
    class VariableLengthCodes
    {
        static void Main()
        {
            var input = string.Join("", Console.ReadLine()
                .Split(' ')
                .Select(x => Convert.ToString(Convert.ToInt32(x), 2)
                .PadLeft(8, '0'))
                .ToArray());

            var code = input.Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(x => x.Length);

            int n = Convert.ToInt32(Console.ReadLine());
            char[] reverseTable = new char[n + 1];

            for (int i = 0; i < n ; i++)
            {
                var line = Console.ReadLine();
                int index = int.Parse(line.Substring(1));
                reverseTable[index] = line[0];
            }
            var text = code.Select(x => reverseTable[x]).ToArray();

            Console.WriteLine(text);


        }
    }
}


