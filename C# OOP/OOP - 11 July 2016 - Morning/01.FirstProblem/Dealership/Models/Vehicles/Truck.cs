namespace Dealership.Models.Vehicles
{
    using Contracts;
    using Abstract;
    using Common.Enums;
    using Common;

    public class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string setMake, string setModel, decimal setPrice, int setWeightCapacity)
            : base(setMake, setModel, setPrice, Constants.TruckWheelsCount, VehicleType.Truck)
        {
            this.WeightCapacity = setWeightCapacity;
        }

        public int WeightCapacity
        {
            get { return this.weightCapacity; }
            private set
            {
                Validator.ValidateIntRange(value, Constants.MinCapacity, Constants.MaxCapacity,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax,
                    "Weight capacity", Constants.MinCapacity, Constants.MaxCapacity));
                this.weightCapacity = value;
            }
        }
    }
}
