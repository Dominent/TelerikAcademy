namespace IntergalacticTravel.Tests
{
    using Contracts;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class ResourcesFactoryTests
    {
        [TestCase("create resources gold(20) silver(30) bronze(40)")]
        [TestCase("create resources silver(30) bronze(40) gold(20)")]
        [TestCase("create resources silver(30) gold(20) bronze(40)")]
        [TestCase("create resources bronze(40) gold(20) silver(30)")]
        [TestCase("create resources bronze(40) silver(30) gold(20)")]
        public void GetResources_WhenValidCommandIsPassedNoMatterOrder_ShouldReturnNewlyCreatedResources(string command)
        {
            var resourcesFactory = new ResourcesFactory();

            Assert.IsInstanceOf<IResources>(resourcesFactory.GetResources(command));
        }

        [Test]
        public void GetResources_WhenCommandPassedIsNull_ShouldThrowInvalidOperationExceptionWhichContainsTheStrCommand()
        {
            var resourcesFactory = new ResourcesFactory();

            var ex = Assert.Throws<InvalidOperationException>(() => resourcesFactory.GetResources(null));

            StringAssert.Contains("command", ex.Message);
        }

        [Test]
        public void GetResources_WhenCommandPassedIsEmpty_ShouldThrowInvalidOperationExceptionWhichContainsTheStrCommand()
        {
            var resourcesFactory = new ResourcesFactory();

            var ex = Assert.Throws<InvalidOperationException>(() => resourcesFactory.GetResources(""));

            StringAssert.Contains("command", ex.Message);
        }

        [TestCase("create resources x y z")]
        [TestCase("tansta resources a b")]
        [TestCase("absolutelyRandomStringThatMustNotBeAValidCommand")]
        public void GetResources_WhenCommandPassedIsInvalid_ShouldThrowInvalidOperationExceptionWhichContainsTheStrCommand(string command)
        {
            var resourcesFactory = new ResourcesFactory();

            var ex = Assert.Throws<InvalidOperationException>(() => resourcesFactory.GetResources(command));

            StringAssert.Contains("command", ex.Message);
        }

        [TestCase("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [TestCase("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [TestCase("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void GetResources_WhenCommandPassedIsValidButResourceAmountValuesLargerThanUIntMaxValue_ShouldThrowOverflowExceptio(string command)
        {
            var resourcesFactory = new ResourcesFactory();

            Assert.Throws<OverflowException>(() => resourcesFactory.GetResources(command));
        }
    }
}
