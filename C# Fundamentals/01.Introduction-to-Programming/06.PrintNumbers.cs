using System;

class PrintNumbers
{
    static void Main()
    {
        int[] numbers = new int[]{1, 101, 1001};

        foreach (var val in numbers)
        {
            Console.WriteLine(val);
        }
    }
}

