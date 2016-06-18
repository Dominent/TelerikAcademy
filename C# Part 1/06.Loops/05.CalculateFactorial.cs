using System;

class CalculateFactorial
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());
        double valX = Convert.ToDouble(Console.ReadLine());
        double sum = 1;
        for (int i = 1; i <= valN; i++)
            sum = sum + (Factorial(i)) / Math.Pow(valX, i);

        Console.WriteLine("{0:F5}", sum);
    }

    private static int Factorial(int input)
    {
        if (input == 0) return 1;
        return input * Factorial(input - 1);
    }
}

