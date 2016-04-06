using System;

class LongSequence
{
    static void Main()
    {
        int output = 0;
        for (int i = 2; i < 1002; i++)
        {
            output = i % 2 == 0 ? i : -i;
            Console.WriteLine(output);
        }
    }
}

