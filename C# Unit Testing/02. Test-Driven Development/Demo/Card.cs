using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder.Append($"{typeof(CardFace).Name}: ");
            strBuilder.Append($"{ Enum.GetName(typeof(CardFace), this.Face)}, ");
            strBuilder.Append($"{typeof(CardSuit).Name}: ");
            strBuilder.Append($"{ Enum.GetName(typeof(CardSuit), this.Suit)}");

            return strBuilder.ToString();
        }
    }
}
