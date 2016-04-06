using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i < 12; i++)
        {
            int output = i % 2 == 0 ? i : -i;
            Console.WriteLine(output);
        }
    }
}

