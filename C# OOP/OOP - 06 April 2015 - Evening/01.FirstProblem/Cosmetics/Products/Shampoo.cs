using Cosmetics.Contracts;
using System;
using Cosmetics.Common;
using System.Text;

namespace Cosmetics.Products
{
    public class Shampoo : Product, IShampoo
    {
        private readonly UsageType usageType;
        private uint milliliters;

        public Shampoo(string setName, string setBrand, decimal setPrice, GenderType setGender, uint setMilliliters, UsageType setUsageType)
            : base(setName, setBrand, setPrice, setGender)
        {
            this.usageType = setUsageType;
            this.Milliliters = setMilliliters;
        }

        public uint Milliliters
        {
            get { return this.milliliters; }
            private set
            {
                Validator.CheckIfNull(value);
                Validator.CheckIfQuantityIsNotNegative(value, Constants.invalidMillilitersValue);
                this.milliliters = value;
            }
        }

        public override decimal Price
        {
            get { return base.Price * milliliters; }
            protected set { base.Price = value; }
        }

        public UsageType Usage { get { return this.usageType; } }

        public override string Print()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            strBuilder.AppendLine(string.Format("  * Price: ${0}", this.Price));
            strBuilder.AppendLine(string.Format("  * For gender: {0}", Enum.GetName(typeof(GenderType), Gender)));
            strBuilder.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            strBuilder.AppendLine(string.Format("  * Usage: {0}", Enum.GetName(typeof(UsageType), Usage)));

            return (strBuilder.ToString().Trim());
        }
    }
}
