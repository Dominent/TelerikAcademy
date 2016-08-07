namespace Dealership.Models.Vehicles
{
    using Abstract;
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Enums;
    using Common;
    public class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string setMake, string setModel, decimal setPrice, int setSeats)
            : base(setMake, setModel, setPrice, Constants.CarWheelsCount, VehicleType.Car)
        {
            this.Seats = setSeats;
        }

        public int Seats
        {
            get { return this.seats; }
            private set
            {
                Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax,
                    "Seats", Constants.MinSeats, Constants.MaxSeats));
                this.seats = value;
            }
        }
    }
}
