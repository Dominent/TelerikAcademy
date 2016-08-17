using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder.Append(string.Join(", ", Cards));

            return strBuilder.ToString();
        }
    }
}
