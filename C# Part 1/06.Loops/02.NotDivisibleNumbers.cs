using System;
using System.Text;

class NotDivisibleNumbers
{
    static void Main()
    {
        ulong input = Convert.ToUInt64(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (ulong i = 1; i <= input; i++)
            if (i % 3 != 0 && i % 7 != 0)
                sb.Append(string.Format(" {0}", i));

        Console.WriteLine(sb.ToString().TrimStart(' '));
    }
}

