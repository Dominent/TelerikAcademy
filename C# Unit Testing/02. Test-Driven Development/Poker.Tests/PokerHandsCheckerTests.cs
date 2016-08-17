namespace Poker.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PokerHandsCheckerTests
    {
        [Test]
        public void IsValidHand_WhenPassedNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PokerHandsChecker().IsValidHand(null));
        }

        [Test]
        public void IsValidHand_WhenPassedHand_ShouldReturnTrueIfInHandContainFiveDistinctCards()
        {
            var distinctCards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
            };
            var hand = new Hand(distinctCards);
            var pokerHandChecker = new PokerHandsChecker();

            var expected = true;
            var actual = pokerHandChecker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsValidHand_WhenPassedHand_ShouldReturnFalseIfInHandNotContainFiveDistinctCards()
        {
            var notDistinctCards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
            };
            var hand = new Hand(notDistinctCards);
            var pokerHandChecker = new PokerHandsChecker();

            var expected = false;
            var actual = pokerHandChecker.IsValidHand(hand);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsFlush_WhenPassedNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PokerHandsChecker().IsFlush(null));
        }

        [Test]
        public void IsFlush_WhenPassedHand_ShouldReturnTrueIfHandContainFiveCardsFromOneCardSuit()
        {
            var distinctCards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
            };
            var hand = new Hand(distinctCards);
            var pokerHandChecker = new PokerHandsChecker();

            var expected = true;
            var actual = pokerHandChecker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsFlush_WhenPassedHand_ShouldReturnFalseIfHandContainFiveCardsFromDifferentCardSuit()
        {
            var notDistinctCards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
            };
            var hand = new Hand(notDistinctCards);
            var pokerHandChecker = new PokerHandsChecker();

            var expected = false;
            var actual = pokerHandChecker.IsFlush(hand);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsFourOfAKind_WhenPassedNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PokerHandsChecker().IsFourOfAKind(null));
        }

        [Test]
        public void IsFourOfAKind_WhenPassedHand_ShouldReturnTrueIfHandContainFourCardsFromOneCardFace()
        {
            var distinctCards = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
            };
            var hand = new Hand(distinctCards);
            var pokerHandChecker = new PokerHandsChecker();

            var expected = true;
            var actual = pokerHandChecker.IsFourOfAKind(hand);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsFourOfAKind_WhenPassedHand_ShouldReturnFalseIfHandDoesNotContainFourCardsFromOneCardFace()
        {
            var notDistinctCards = new List<ICard>()
            {
                 new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
            };
            var hand = new Hand(notDistinctCards);
            var pokerHandChecker = new PokerHandsChecker();

            var expected = false;
            var actual = pokerHandChecker.IsFourOfAKind(hand);

            Assert.AreEqual(expected, actual);
        }
    }
}
