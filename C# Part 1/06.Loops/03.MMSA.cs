using System;

class MMSA
{
    static void Main()
    {
        double sum = 0;
        double min = int.MaxValue;
        double max = int.MinValue;

        int input = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            double temp = Convert.ToDouble(Console.ReadLine());
            sum += temp;
            if (temp > max)
                max = temp;
            if (temp < min)
                min = temp;
        }

        Console.WriteLine("min={0:F2}\nmax={1:F2}\nsum={2:F2}\navg={3:F2}", min, max, sum, (sum / input));
    }
}

