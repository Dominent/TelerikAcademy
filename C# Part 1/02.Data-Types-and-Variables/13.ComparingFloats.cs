using System;

class ComparingFloats
{
    static void Main()
    {
        double val1 = Convert.ToDouble(Console.ReadLine());
        double val2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine((Math.Abs(val1 - val2) < 0.000001) ? "true" : "false");
    }
}

