using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            bool isLeap = DateTime.IsLeapYear(int.Parse(Console.ReadLine()));
            Console.WriteLine(isLeap ? "Leap" : "Common");
        }
    }
}
