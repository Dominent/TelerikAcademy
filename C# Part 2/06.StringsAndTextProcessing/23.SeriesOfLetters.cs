using System;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char previousCh = input[0];

            foreach (var ch in input)
            {
                var currentCh = ch;
                if(currentCh == previousCh) continue;
                else Console.Write(previousCh);
                previousCh = currentCh;
            }
            Console.WriteLine(previousCh);
        }
    }
}
