namespace Dealership.Models.Vehicles
{
    using Contracts;
    using Abstract;
    using System;
    using Common.Enums;
    using Common;

    public class Motorcycle : Vehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string setMake, string setModel, decimal setPrice, string setCategory)
            : base(setMake, setModel, setPrice, Constants.MotorcycleWheelsCount, VehicleType.Motorcycle)
        {
            this.Category = setCategory;
        }

        public string Category
        {
            get { return this.category; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxCategoryLength, Constants.MinCategoryLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax,
                    "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));
                this.category = value;
            }
        }
    }
}
