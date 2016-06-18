using System;

class CompareCharArrays
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        int length = 0;
        if (first.Length > second.Length)
            length = second.Length;
        else
            length = first.Length;

        for (int i = 0; i < length; i++)
            if (first[i] > second[i])
                Print('>');
            else if (first[i] < second[i])
                Print('<');

        if (first.Length > second.Length)
            Print('>');
        else if (first.Length < second.Length)
            Print('<');
        else
            Print('=');
    }

    private static void Print(char symbol)
    {
        Console.WriteLine("{0}", symbol);
        Environment.Exit(0);
    }
}




