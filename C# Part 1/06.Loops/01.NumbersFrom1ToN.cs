using System;
using System.Text;

class NumbersFrom1ToN
{
    static void Main()
    {
        ulong input = Convert.ToUInt64(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (ulong i = 1; i <= input; i++)
            sb.Append(string.Format(" {0}", i));

        Console.WriteLine(sb.ToString().TrimStart(' '));
        
    }
}

