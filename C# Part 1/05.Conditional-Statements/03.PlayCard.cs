using System;

namespace PlayCard
{
    class PlayCard
    {
        static void Main()
        {
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            string input = Console.ReadLine();
            bool isCard = false;

            foreach (var val in cards)
            {
                if (input == val)
                {
                    Console.WriteLine("yes {0}", val);
                    isCard = true;
                    break;
                }
            }

            if(!isCard)
                Console.WriteLine("no {0}", input);
        }
    }
}
