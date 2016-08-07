namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;

    public abstract class Product : IProduct
    {
        private string name;
        private readonly GenderType gender;
        private string brand;
        protected decimal price;

        public Product(string setName, string setBrand ,decimal setPrice, GenderType setGender )
        {
            this.Name = setName;
            this.gender = setGender;
            this.Brand = setBrand;
            this.Price = setPrice;
        }
        public string Brand
        {
            get { return this.brand; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.brandNameMaxSymbols, Constants.brandNameMinSymbols,
                    string.Format(Constants.brandInvalidName, Constants.brandNameMinSymbols, Constants.brandNameMaxSymbols));
                this.brand = value;
            }
        }

        public GenderType Gender { get { return this.gender; } }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.productNameMaxSymbols, Constants.productNameMinSymbols,
                    string.Format(Constants.productInvalidName, Constants.productNameMinSymbols, Constants.productNameMaxSymbols));
                this.name = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                Validator.CheckIfNull(value);
                Validator.CheckIfQuantityIsNotNegative(value, Constants.invalidMoneyValue);
                this.price = value;
            }
        }

        public abstract string Print();
    }
}
