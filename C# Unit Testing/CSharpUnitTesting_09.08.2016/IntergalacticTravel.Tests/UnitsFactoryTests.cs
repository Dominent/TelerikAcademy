namespace IntergalacticTravel.Tests
{
    using NUnit.Framework;

    using Exceptions;
    using IntergalacticTravel;

    [TestFixture]
    public class UnitsFactoryTests
    {
        [Test]
        public void GetUnit_WhenValidCorrespondingCommandIsPassed_ShouldReturnNewProcyonUnit()
        {
            var command = "create unit Procyon Gosho 1";
            var unitsFactory = new UnitsFactory();

            var actual = unitsFactory.GetUnit(command);

            Assert.IsInstanceOf<Procyon>(actual);
        }

        [Test]
        public void GetUnit_WhenValidCorrespondingCommandIsPassed_ShouldReturnNewLuytenUnit()
        {
            var command = "create unit Luyten Gosho 1";
            var unitsFactory = new UnitsFactory();

            var actual = unitsFactory.GetUnit(command);

            Assert.IsInstanceOf<Luyten>(actual);
        }

        [Test]
        public void GetUnit_WhenValidCorrespondingCommandIsPassed_ShouldReturnNewLacailleUnit()
        {
            var command = "create unit Lacaille Gosho 1";
            var unitsFactory = new UnitsFactory();

            var actual = unitsFactory.GetUnit(command);

            Assert.IsInstanceOf<Lacaille>(actual);
        }

        [Test]
        public void GetUnit_WhenCorrespondingCommandIsNull_ShouldThrowInvalidUnitCreationCommandException()
        {
            var unitsFactory = new UnitsFactory();

            Assert.Throws<InvalidUnitCreationCommandException>(() => unitsFactory.GetUnit(null));
        }

        [Test]
        public void GetUnit_WhenCorrespondingCommandIsEmpty_ShouldThrowInvalidUnitCreationCommandException()
        {
            var unitsFactory = new UnitsFactory();

            Assert.Throws<InvalidUnitCreationCommandException>(() => unitsFactory.GetUnit(""));
        }
    }
}
