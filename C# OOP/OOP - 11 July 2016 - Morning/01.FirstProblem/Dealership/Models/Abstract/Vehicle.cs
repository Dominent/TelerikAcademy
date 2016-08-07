namespace Dealership.Models.Abstract
{
    using Contracts;
    using System.Collections.Generic;
    using Common.Enums;
    using Common;
    using System.Text;
    public abstract class Vehicle : IVehicle
    {
        private IList<IComment> comments;
        private string make;
        private string model;
        private decimal price;
        private int wheels;

        //string make, string model, decimal price, int seat
        public Vehicle(string setMake, string setModel, decimal setPrice, int setWheels, VehicleType setType)
        {
            this.Make = setMake;
            this.Model = setModel;
            this.Price = setPrice;
            this.Wheels = setWheels;
            this.Type = setType;

            this.Comments = new List<IComment>();
        }

        //if has time make it deep copy!
        public IList<IComment> Comments
        {
            get
            {
                return this.comments;
            }
            protected set
            {
                this.comments = value;
            }
        }

        public string Make
        {
            get { return this.make; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxMakeLength, Constants.MinMakeLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax,
                    "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
                this.make = value;
            }
        }

        //repeating validation extract to method ?
        public string Model
        {
            get { return this.model; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxModelLength, Constants.MinModelLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax,
                    "Model", Constants.MinModelLength, Constants.MaxModelLength));
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax,
                    "Price", Constants.MinPrice, Constants.MaxPrice));
                this.price = value;
            }
        }

        public VehicleType Type { get; private set; }

        public int Wheels
        {
            get { return this.wheels; }
            private set
            {
                Validator.ValidateIntRange(value, Constants.MinWheels, Constants.MaxWheels,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax,
                    "Wheels", Constants.MinWheels, Constants.MaxWheels));
                this.wheels = value;
            }
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(string.Format(" {0}:", this.GetType().Name));
            strBuilder.AppendLine(string.Format("  Make: {0}", this.Make));
            strBuilder.AppendLine(string.Format("  Model: {0}", this.Model));
            strBuilder.AppendLine(string.Format("  Wheels: {0}", this.Wheels));
            strBuilder.AppendLine(string.Format("  Price: ${0}", this.Price));
            //mai ne im e tuka mqstoto
            if (this is IMotorcycle)
                strBuilder.AppendLine(string.Format("  Category: {0}", (this as IMotorcycle).Category));
            if (this is ICar)
                strBuilder.AppendLine(string.Format("  Seats: {0}", (this as ICar).Seats));
            if (this is ITruck)
                strBuilder.AppendLine(string.Format("  Weight Capacity: {0}t", (this as ITruck).WeightCapacity));
            strBuilder.AppendLine(string.Format("    --{0}--", this.comments.Count > 0 ? "COMMENTS" : "NO COMMENTS"));
            if (this.comments.Count > 0)
            {
                foreach (var comment in Comments)
                {
                    strBuilder.AppendLine("    ----------");
                    strBuilder.AppendLine(string.Format("    {0}", comment.Content));
                    strBuilder.AppendLine(string.Format("      User: {0}", comment.Author));
                    strBuilder.AppendLine("    ----------");
                }
                strBuilder.AppendLine(string.Format("    --{0}--", "COMMENTS"));
            }
            return strBuilder.ToString();
        }
    }
}
