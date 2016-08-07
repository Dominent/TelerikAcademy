namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Contracts;
    using Mocks;
    using Controllers;
    using Models;
    using MSTestExtensions;
    using Telerik.JustMock;

    [TestClass]
    public class CarsControllerTests : BaseTest
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        // : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        public void Details_WhenPassedIncorrectId_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => (new CarsController()).Details(-1));
        }

        [TestMethod]
        public void Search_WhenPassedEmptyString_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => (new CarsController()).Search(""));
        }

        [TestMethod]
        public void Search_WhenPassedNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => (new CarsController()).Search(null));
        }

        [TestMethod]
        public void Search_WhenPassedCorrectCondition_ShouldReturnNewView()
        {
            var mockedICarsRepository = Mock.Create<ICarsRepository>();

            var carsController = new CarsController(mockedICarsRepository);

            Assert.IsInstanceOfType(carsController.Search(Arg.AnyString), typeof(IView));
        }

        [TestMethod]
        public void Sort_WhenPassedNullParameter_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CarsController().Sort(null));
        }

        [TestMethod]
        public void Sort_WhenPassedInvalidParameter_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CarsController().Sort(Arg.AnyString));
        }

        [TestMethod]
        public void Sort_WhenPassedCorrectParameter_ShouldReturnView()
        {
            var mockedICarsRepository = Mock.Create<ICarsRepository>();

            var carsController = new CarsController(mockedICarsRepository);

            Assert.IsInstanceOfType(carsController.Sort("make"), typeof(IView));
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
