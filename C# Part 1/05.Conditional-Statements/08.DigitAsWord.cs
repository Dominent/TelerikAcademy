using System;

namespace DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "not a digit" };
            long input = 0;

            try
            {
                input = Convert.ToInt64(Console.ReadLine());
                if (input >= 0 && input <= 9)
                    Console.WriteLine(numbers[input]);
                else
                    Console.WriteLine(numbers[10]);
            }
            catch (Exception)
            {
                Console.WriteLine(numbers[10]);
            }
        }
    }
}
