using System;
using System.Text;

class PrintADeck
{
    static void Main()
    {
        string[] cardSigns = { " of spades", " of clubs", " of hearts", " of diamonds" };
        string[] cardNumbers = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        StringBuilder sb = new StringBuilder();

        string input = Console.ReadLine().Trim();

        //0 is 2
       
        for (int i = 0; i <= Array.IndexOf(cardNumbers, input); i++)
        {
            foreach (var sign in cardSigns)
                sb.Append($", {cardNumbers[i] + sign}");

            Console.WriteLine(sb.ToString().TrimStart(',', ' '));
            sb.Clear();
        }
    }
}
