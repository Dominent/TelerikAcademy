namespace Poker.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class HandTests
    {
        [Test]
        public void ToString_WhenInvoked_ShouldNotThrowException()
        {
            var cards = new List<ICard>();
            var hand = new Hand(cards);

            Assert.DoesNotThrow(() => hand.ToString());
        }

        [Test]
        public void ToString_WhenInvoked_ShouldFormatCorrectHands()
        {
            var cards = new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts)
            };
            var hand = new Hand(cards);

            var expected = string.Join(", ", cards);
            var actual = hand.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
