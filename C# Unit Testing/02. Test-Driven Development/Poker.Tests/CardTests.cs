namespace Poker.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CardTests
    {
        [Test]
        public void ToString_WhenInvoked_ShouldNotThrowException()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);

            Assert.DoesNotThrow(() => card.ToString());
        }

        [Test]
        public void ToString_WhenInvoked_ShouldFormatCorrectCards()
        {
            var cardFace = CardFace.Ace;
            var cardSuit = CardSuit.Clubs;
            var card = new Card(cardFace, cardSuit);

            var expected = $"{typeof(CardFace).Name}: {Enum.GetName(typeof (CardFace), cardFace)}, {typeof(CardSuit).Name}: {Enum.GetName(typeof(CardSuit), cardSuit)}";
            var actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
