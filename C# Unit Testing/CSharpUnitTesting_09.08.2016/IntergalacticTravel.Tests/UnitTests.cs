namespace IntergalacticTravel.Tests
{
    using Contracts;
    using Moq;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Pay_WhenPassedNull_ShouldThrowNullReferenceException()
        {
            var unitId = 01;
            var unitName = "Pesho";

            var unit = new Unit(unitId, unitName);

            Assert.Throws<NullReferenceException>(() => unit.Pay(null));
        }

        [Test]
        public void Pay_WhenInputIsValid_ShouldDecreaseTheAmountOfResourcesOfOwnerByAmountOfCost()
        {
            var resourceStub = new Mock<IResources>();
            resourceStub.Setup(x => x.GoldCoins).Returns(400);
            resourceStub.Setup(x => x.SilverCoins).Returns(300);
            resourceStub.Setup(x => x.BronzeCoins).Returns(100);

            var unitId = 01;
            var unitName = "Pesho";

            var unit = new Unit(unitId, unitName);

            unit.Resources.GoldCoins = 400;
            unit.Resources.SilverCoins = 300;
            unit.Resources.BronzeCoins = 100;

            unit.Pay(resourceStub.Object);
            
            Assert.AreEqual(unit.Resources.GoldCoins, 0);
            Assert.AreEqual(unit.Resources.SilverCoins, 0);
            Assert.AreEqual(unit.Resources.BronzeCoins, 0);
        }
    }
}
