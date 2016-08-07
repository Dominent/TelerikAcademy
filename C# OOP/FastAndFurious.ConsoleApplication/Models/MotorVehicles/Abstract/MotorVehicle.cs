namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Common.Utils;

    public abstract class MotorVehicle : IMotorVehicle, IWeightable, IValuable
    {
        private readonly int id;
        private int weight;
        private int acceleration;
        private int topSpeed;
        private decimal price;
        private IList<ITunningPart> tunningParts;

        public MotorVehicle(decimal price,
            int weight,
            int acceleration,
            int topSpeed
            )
        {
            this.id = DataGenerator.GenerateId();
            this.Acceleration = acceleration;
            this.price = price;
            this.Weight = weight;
            this.TopSpeed = topSpeed;
            tunningParts = new List<ITunningPart>();
        }

        public decimal Price { get { return this.Price + this.TunningParts.Sum(x => x.Price); } }

        public int Weight
        {
            get { return this.weight; }
            private set { this.weight = value; }
        }
        public int Acceleration
        {
            get { return this.acceleration; }
            private set { this.acceleration = value; }
        }
        public int TopSpeed
        {
            get { return this.topSpeed; }
            private set { this.topSpeed = value; }
        }

        public IEnumerable<ITunningPart> TunningParts { get { return new List<ITunningPart>(this.tunningParts); } }

        public int Id { get { return this.id; } }

        public void AddTunning(ITunningPart part)
        {
            tunningParts.Add(part);
        }
        public TimeSpan Race(int trackLengthInMeters)
        {
            // Oohh boy, you shouldn't have missed the PHYSICS class in high school.
            throw new NotImplementedException();
        }
        public bool RemoveTunning(ITunningPart part)
        {
            return tunningParts.Remove(part);
        }
    }
}
