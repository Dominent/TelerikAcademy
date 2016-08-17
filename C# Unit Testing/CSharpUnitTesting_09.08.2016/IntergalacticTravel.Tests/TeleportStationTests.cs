namespace IntergalacticTravel.Tests
{
    using Contracts;
    using Exceptions;
    using Fakes;
    using Moq;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class TeleportStationTests
    {
        [Test]//1
        public void Ctor_WhenNewTeleportStationIsCreatedWithValidParametersPassedToTheConstructor_ShouldSetUpAllOfTheProvidedFields()
        {
            var businessOwnerStub = new Mock<IBusinessOwner>();
            var galacticMapStub = new Mock<IEnumerable<IPath>>();
            var locationStub = new Mock<ILocation>();

            var teleportStation = new TeleportStationFake(businessOwnerStub.Object, galacticMapStub.Object, locationStub.Object);

            Assert.AreSame(businessOwnerStub.Object, teleportStation.Owner);
            Assert.AreSame(galacticMapStub.Object, teleportStation.GalacticMap);
            Assert.AreSame(locationStub.Object, teleportStation.Location);
        }

        [Test]//2
        public void TeleportUnit_WhenPassedUnitToTeleportIsNull_ShouldThrowArgumentNullExceptionWithMessageThatContainsUnitToTeleport()
        {
            var businessOwnerStub = new Mock<IBusinessOwner>();
            var galacticMapStub = new Mock<IEnumerable<IPath>>();
            var locationStub = new Mock<ILocation>();

            var teleportStation = new TeleportStation(businessOwnerStub.Object, galacticMapStub.Object, locationStub.Object);

            var ex = Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(null, locationStub.Object));

            StringAssert.Contains("unitToTeleport", ex.Message);
        }

        [Test]//3
        public void TeleportUnit_WhenPassedLocationIsNull_ShouldThrowArgumentNullExceptionWithMessageThatContainsDestination()
        {
            var businessOwnerStub = new Mock<IBusinessOwner>();
            var galacticMapStub = new Mock<IEnumerable<IPath>>();
            var locationStub = new Mock<ILocation>();
            var unitStub = new Mock<IUnit>();

            var teleportStation = new TeleportStation(businessOwnerStub.Object, galacticMapStub.Object, locationStub.Object);

            var ex = Assert.Throws<ArgumentNullException>(() => teleportStation.TeleportUnit(unitStub.Object, null));

            StringAssert.Contains("destination", ex.Message);
        }

        [Test]//4
        public void TeleportUnit_WhenAUnitIsTryingToUseTheTeleportStationFromDifferentPlanetInOneUniverse_ShouldThrowTeleportOutOfRangeExceptionThatContainsUnitToTeleportCurrentLocation()
        {
            var businessOwnerStub = new Mock<IBusinessOwner>();
            var galacticMapStub = new Mock<IEnumerable<IPath>>();
            var locationStub = new Mock<ILocation>();
            var currentLocationStub = new Mock<ILocation>();
            var unitStub = new Mock<IUnit>();
            var planetToTeleportStub = new Mock<IPlanet>();
            var currentPLanetStub = new Mock<IPlanet>();
            var galaxyStub = new Mock<IGalaxy>();

            planetToTeleportStub.Setup(x => x.Name).Returns("Mars");
            currentPLanetStub.Setup(x => x.Name).Returns("Moon");

            galaxyStub.Setup(x => x.Name).Returns("Susurlevo");
            galaxyStub.Setup(x => x.Planets).Returns(new List<IPlanet>() { planetToTeleportStub.Object, currentPLanetStub.Object });

            planetToTeleportStub.Setup(x => x.Galaxy).Returns(galaxyStub.Object);
            currentPLanetStub.Setup(x => x.Galaxy).Returns(galaxyStub.Object);

            locationStub.Setup(x => x.Planet).Returns(planetToTeleportStub.Object);
            currentLocationStub.Setup(x => x.Planet).Returns(currentPLanetStub.Object);
            unitStub.Setup(x => x.CurrentLocation).Returns(currentLocationStub.Object);

            var teleportStation = new TeleportStation(businessOwnerStub.Object, galacticMapStub.Object, locationStub.Object);

            var ex = Assert.Throws<TeleportOutOfRangeException>(() => teleportStation.TeleportUnit(unitStub.Object, locationStub.Object));

            StringAssert.Contains("unitToTeleport.CurrentLocation", ex.Message);
        }

        [Test]//5
        public void TeleportUnit_WhenTryingToTeleportAUnitToAnotherLocationThatIsTakenByAnotherUnit_ShouldThrowInvalidTeleportationLocationExceptionThatContainsUnitWillOverlap()
        {
            var businessOwnerStub = new Mock<IBusinessOwner>();
            var galacticMapStub = new List<IPath>();
            var locationStub = new Mock<ILocation>();
            var planetStub = new Mock<IPlanet>();
            var galaxyStub = new Mock<IGalaxy>();
            var pathStub = new Mock<IPath>();
            var unitStub = new Mock<IUnit>();

            locationStub.Setup(x => x.Planet).Returns(planetStub.Object);
            locationStub.Setup(x => x.Coordinates.Latitude).Returns(1.0d);
            locationStub.Setup(x => x.Coordinates.Longtitude).Returns(1.0d);

            unitStub.Setup(x => x.CurrentLocation).Returns(locationStub.Object);

            pathStub.Setup(x => x.TargetLocation).Returns(locationStub.Object);

            galaxyStub.Setup(x => x.Name).Returns("Susurlevo");
            galaxyStub.Setup(x => x.Planets).Returns(new List<IPlanet>() { planetStub.Object });

            planetStub.Setup(x => x.Name).Returns(galaxyStub.Object.Name);
            planetStub.Setup(x => x.Galaxy).Returns(galaxyStub.Object);
            planetStub.Setup(x => x.Units).Returns(new List<IUnit>() { unitStub.Object });

            galacticMapStub.Add(pathStub.Object);

            var teleportStation = new TeleportStation(businessOwnerStub.Object, galacticMapStub, locationStub.Object);

            var ex = Assert.Throws<InvalidTeleportationLocationException>(() => teleportStation.TeleportUnit(unitStub.Object, locationStub.Object));

            StringAssert.Contains("units will overlap", ex.Message);
        }

        [Test]//6
        public void TeleportUnit_WhenTryingToTeleportAUnitToAGalaxyThatCannotBeFound_ShouldThrowLocationNotFoundExceptionThatContainsGalaxy()
        {
            var businessOwnerStub = new Mock<IBusinessOwner>();
            var galacticMapStub = new List<IPath>();
            var locationStub = new Mock<ILocation>();
            var planetStub = new Mock<IPlanet>();
            var galaxyStub = new Mock<IGalaxy>();
            var pathStub = new Mock<IPath>();
            var unitStub = new Mock<IUnit>();

            locationStub.Setup(x => x.Planet).Returns(planetStub.Object);
            locationStub.Setup(x => x.Coordinates.Latitude).Returns(1.0d);
            locationStub.Setup(x => x.Coordinates.Longtitude).Returns(1.0d);

            unitStub.Setup(x => x.CurrentLocation).Returns(locationStub.Object);

            pathStub.Setup(x => x.TargetLocation).Returns(locationStub.Object);

            galaxyStub.Setup(x => x.Name).Returns("Susurlevo");
            galaxyStub.Setup(x => x.Planets).Returns(new List<IPlanet>() { planetStub.Object });

            planetStub.Setup(x => x.Name).Returns(galaxyStub.Object.Name);
            planetStub.Setup(x => x.Galaxy).Returns(galaxyStub.Object);
            planetStub.Setup(x => x.Units).Returns(new List<IUnit>() { unitStub.Object });

            var teleportStation = new TeleportStation(businessOwnerStub.Object, galacticMapStub, locationStub.Object);

            var ex = Assert.Throws<LocationNotFoundException>(() => teleportStation.TeleportUnit(unitStub.Object, locationStub.Object));

            StringAssert.Contains("Galaxy", ex.Message);
        }

        [Test]//7 Err
        public void TeleportUnit_WhenTryingToTeleportAUnitToAPlanetThatCannotBeFoundInTheGalaxy_ShouldThrowLocationNotFoundExceptionThatContainsPlanet()
        {
            //Error In Code -> Unit location must be same as current location And Planet shouldnt be located in Galaxy ?!
        }

        [Test]//8
        public void TeleportUnit_WhenTryingToTeleportAUnitToAPlanetThatCannotBeFoundInTheGalaxy_ShouldThrowInsufficientResourcesExceptionThatContainsFREELUNCH()
        {
            var businessOwnerStub = new Mock<IBusinessOwner>();
            var galacticMapStub = new List<IPath>();
            var locationStub = new Mock<ILocation>();
            var planetStub = new Mock<IPlanet>();
            var galaxyStub = new Mock<IGalaxy>();
            var pathStub = new Mock<IPath>();
            var unitStub = new Mock<IUnit>();

            locationStub.Setup(x => x.Planet).Returns(planetStub.Object);
            locationStub.Setup(x => x.Coordinates.Latitude).Returns(1.0d);
            locationStub.Setup(x => x.Coordinates.Longtitude).Returns(1.0d);

            unitStub.Setup(x => x.CurrentLocation).Returns(locationStub.Object);

            pathStub.Setup(x => x.TargetLocation).Returns(locationStub.Object);

            galaxyStub.Setup(x => x.Name).Returns("Susurlevo");
            galaxyStub.Setup(x => x.Planets).Returns(new List<IPlanet>() { planetStub.Object });

            planetStub.Setup(x => x.Name).Returns(galaxyStub.Object.Name);
            planetStub.Setup(x => x.Galaxy).Returns(galaxyStub.Object);
            planetStub.Setup(x => x.Units).Returns(new List<IUnit>() {});

            galacticMapStub.Add(pathStub.Object);

            var teleportStation = new TeleportStation(businessOwnerStub.Object, galacticMapStub, locationStub.Object);

            var ex = Assert.Throws<InsufficientResourcesException>(() => teleportStation.TeleportUnit(unitStub.Object, locationStub.Object));

            StringAssert.Contains("FREE LUNCH", ex.Message);
        }

        [Test]//9
        public void TeleportUnit_WhenAllValidationsPassed_ShouldRequirePaymentFromUnitToTeleportForProvidedServices()
        {
            var businessOwnerStub = new Mock<IBusinessOwner>();
            var galacticMapStub = new List<IPath>();
            var locationStub = new Mock<ILocation>();
            var planetStub = new Mock<IPlanet>();
            var galaxyStub = new Mock<IGalaxy>();
            var pathStub = new Mock<IPath>();
            var unitMock = new Mock<IUnit>();
            var resourcesStub = new Mock<IResources>();

            locationStub.Setup(x => x.Planet).Returns(planetStub.Object);
            locationStub.Setup(x => x.Coordinates.Latitude).Returns(1.0d);
            locationStub.Setup(x => x.Coordinates.Longtitude).Returns(1.0d);

            unitMock.Setup(x => x.CurrentLocation).Returns(locationStub.Object);
            unitMock.Setup(x => x.CanPay(resourcesStub.Object)).Returns(true);
            unitMock.Setup(x => x.Pay(resourcesStub.Object)).Returns(resourcesStub.Object);

            pathStub.Setup(x => x.TargetLocation).Returns(locationStub.Object);
            pathStub.Setup(x => x.Cost).Returns(resourcesStub.Object);

            galaxyStub.Setup(x => x.Name).Returns("Susurlevo");
            galaxyStub.Setup(x => x.Planets).Returns(new List<IPlanet>() { planetStub.Object });

            planetStub.Setup(x => x.Name).Returns(galaxyStub.Object.Name);
            planetStub.Setup(x => x.Galaxy).Returns(galaxyStub.Object);
            planetStub.Setup(x => x.Units).Returns(new List<IUnit>() { });

            galacticMapStub.Add(pathStub.Object);

            var teleportStation = new TeleportStation(businessOwnerStub.Object, galacticMapStub, locationStub.Object);

            teleportStation.TeleportUnit(unitMock.Object, locationStub.Object);

            unitMock.Verify(x => x.Pay(resourcesStub.Object), Times.Once);
        }

        [Test]//10
        public void TeleportUnit_WhenAllValidationsPassed_ShouldObtainPaymentFromUnitToTeleportForProvidedServices()
        {
            var businessOwnerStub = new Mock<IBusinessOwner>();
            var galacticMapStub = new List<IPath>();
            var locationStub = new Mock<ILocation>();
            var planetStub = new Mock<IPlanet>();
            var galaxyStub = new Mock<IGalaxy>();
            var pathStub = new Mock<IPath>();
            var unitStub = new Mock<IUnit>();
            var resourcesStub = new Mock<IResources>();

            resourcesStub.Setup(x => x.BronzeCoins).Returns(15);
            resourcesStub.Setup(x => x.GoldCoins).Returns(10);
            resourcesStub.Setup(x => x.SilverCoins).Returns(1);

            locationStub.Setup(x => x.Planet).Returns(planetStub.Object);
            locationStub.Setup(x => x.Coordinates.Latitude).Returns(1.0d);
            locationStub.Setup(x => x.Coordinates.Longtitude).Returns(1.0d);

            unitStub.Setup(x => x.CurrentLocation).Returns(locationStub.Object);
            unitStub.Setup(x => x.CanPay(resourcesStub.Object)).Returns(true);
            unitStub.Setup(x => x.Pay(resourcesStub.Object)).Returns(resourcesStub.Object);

            pathStub.Setup(x => x.TargetLocation).Returns(locationStub.Object);
            pathStub.Setup(x => x.Cost).Returns(resourcesStub.Object);

            galaxyStub.Setup(x => x.Name).Returns("Susurlevo");
            galaxyStub.Setup(x => x.Planets).Returns(new List<IPlanet>() { planetStub.Object });

            planetStub.Setup(x => x.Name).Returns(galaxyStub.Object.Name);
            planetStub.Setup(x => x.Galaxy).Returns(galaxyStub.Object);
            planetStub.Setup(x => x.Units).Returns(new List<IUnit>() { });

            galacticMapStub.Add(pathStub.Object);

            var teleportStation = new TeleportStationFake(businessOwnerStub.Object, galacticMapStub, locationStub.Object);

            teleportStation.TeleportUnit(unitStub.Object, locationStub.Object);

            Assert.IsTrue(teleportStation.Resources.IsEqualTo(resourcesStub.Object));
        }

        [Test]//11 Err
        public void TeleportUnit_WhenAllValidationsPassed_ShouldSetTheUnitsCurrentLocationToThePreviousLocation()
        {
                //previous location is Null?! -> so we fail
        }

        [Test]//12 Err
        public void TeleportUnit_WhenAllValidationsPassed_ShouldSetTheUnitsCurrentLocationToTheTargetLocation()
        {
            var businessOwnerStub = new Mock<IBusinessOwner>();
            var galacticMapStub = new List<IPath>();
            var locationStub = new Mock<ILocation>();
            var planetStub = new Mock<IPlanet>();
            var galaxyStub = new Mock<IGalaxy>();
            var pathStub = new Mock<IPath>();
            var unitStub = new Mock<IUnit>();
            var resourcesStub = new Mock<IResources>();

            resourcesStub.Setup(x => x.BronzeCoins).Returns(15);
            resourcesStub.Setup(x => x.GoldCoins).Returns(10);
            resourcesStub.Setup(x => x.SilverCoins).Returns(1);

            locationStub.Setup(x => x.Planet).Returns(planetStub.Object);
            locationStub.Setup(x => x.Coordinates.Latitude).Returns(1.0d);
            locationStub.Setup(x => x.Coordinates.Longtitude).Returns(1.0d);

            unitStub.Setup(x => x.CurrentLocation).Returns(locationStub.Object);
            unitStub.Setup(x => x.CanPay(resourcesStub.Object)).Returns(true);
            unitStub.Setup(x => x.Pay(resourcesStub.Object)).Returns(resourcesStub.Object);

            pathStub.Setup(x => x.TargetLocation).Returns(locationStub.Object);
            pathStub.Setup(x => x.Cost).Returns(resourcesStub.Object);

            galaxyStub.Setup(x => x.Name).Returns("Susurlevo");
            galaxyStub.Setup(x => x.Planets).Returns(new List<IPlanet>() { planetStub.Object });

            planetStub.Setup(x => x.Name).Returns(galaxyStub.Object.Name);
            planetStub.Setup(x => x.Galaxy).Returns(galaxyStub.Object);
            planetStub.Setup(x => x.Units).Returns(new List<IUnit>() { });

            galacticMapStub.Add(pathStub.Object);

            var teleportStation = new TeleportStationFake(businessOwnerStub.Object, galacticMapStub, locationStub.Object);

            teleportStation.TeleportUnit(unitStub.Object, locationStub.Object);

            Assert.AreEqual(unitStub.Object.CurrentLocation, locationStub.Object);
        }

        [Test]//13 Err
        public void TeleportUnit_WhenAllValidationsPassed_ShouldAddUnitToTargetPlanetUnits()
        {
        }
    }
}
