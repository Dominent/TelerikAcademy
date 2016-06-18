using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            long input = Convert.ToInt64(Console.ReadLine());

            if (input >= 1 && input <= 3)
                Console.WriteLine("{0}", input * 10);
            else if (input >= 4 && input <= 6)
                Console.WriteLine("{0}", input * 100);
            else if (input >= 7 && input <= 9)
                Console.WriteLine("{0}", input * 1000);
            else
                Console.WriteLine("invalid score");
        }
    }
}
