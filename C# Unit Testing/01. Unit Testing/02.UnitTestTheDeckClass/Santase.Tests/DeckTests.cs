namespace Santase.Tests
{
    using Logic;
    using Logic.Cards;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void ChangeTrumpCard_WhenPassedNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => (new Deck()).ChangeTrumpCard(null));
        }

        [Test]
        public void GetNextCard_WhenReturnCardsAreFinished_ShouldThrowInternalGameException()
        {
            var deck = new Deck();
            var cardsInDeck = 24;

            for (int i = 0; i < cardsInDeck; i++)
                deck.GetNextCard();

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

        [Test]
        [TestCase(15)]
        public void CardsLeft_WhenGetNextCard_ShouldDecreaseCount(int times)
        {
            var deck = new Deck();
            var cardsInDeck = 24;

            for (int i = 0; i < times; i++)
                deck.GetNextCard();

            Assert.AreEqual(cardsInDeck - times, deck.CardsLeft);
        }
    }
}
