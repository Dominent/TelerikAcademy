namespace RangeExceptions
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            const int min = 0;
            const int max = 20;

            var input = Convert.ToInt32(Console.ReadLine());

            if (input > max && input < min)
            {
                throw new InvalidRangeException<int>(min, max, "Number out of range");
            }
        }
    }
}
