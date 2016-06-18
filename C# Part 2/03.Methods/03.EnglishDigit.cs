using System;
using System.Linq;

namespace EnglishDigit
{
    class EnglishDigit
    {
        static void Main()
        {
            DigitToWord( Console.ReadLine().ToCharArray().LastOrDefault() - '0');
        }

        public static void DigitToWord(int digit)
        {
            string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine(numbers[digit]);
        }
    }
}
