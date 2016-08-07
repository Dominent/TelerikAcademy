namespace FastAndFurious.ConsoleApplication.Models.Drivers.Abstract
{
    using System.Collections.Generic;
    using Common.Enums;
    using Common.Utils;
    using Contracts;

    public abstract class Driver : IDriver
    {
        private readonly int id;
        private readonly GenderType gender;
        private string name;
        private IList<IMotorVehicle> vehicles;
        private IMotorVehicle activeVehicle;

        public Driver(string name, GenderType gender)
        {
            this.gender = gender;
            this.id = DataGenerator.GenerateId();
            this.vehicles = new List<IMotorVehicle>();
        }

        public IMotorVehicle ActiveVehicle { get { return this.activeVehicle; } }

        public GenderType Gender { get { return this.gender; } }

        public int Id { get { return this.Id; } }

        public string Name
        {
            //validate ToDo
            get { return this.name; }
            private set { this.name = value; }
        }

        public IEnumerable<IMotorVehicle> Vehicles { get { return new List<IMotorVehicle>(this.vehicles); } }

        public void AddVehicle(IMotorVehicle vehicle)
        {
            //check if not null
            vehicles.Add(vehicle);
        }
        public bool RemoveVehicle(IMotorVehicle vehicle)
        {
            //check if not null
            return vehicles.Remove(vehicle);
        }
        public void SetActiveVehicle(IMotorVehicle vehicle)
        {
            //check if not null
            this.activeVehicle = vehicle;
        }
    }
}
