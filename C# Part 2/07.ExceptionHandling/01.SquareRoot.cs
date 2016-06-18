using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double input = Convert.ToDouble(Console.ReadLine());
                if(input < 0) Console.WriteLine("Invalid number");
                else Console.WriteLine("{0:F3}", Math.Sqrt(input));
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
