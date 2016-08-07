namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using Cosmetics.Common;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Category : ICategory
    {
        private string name;
        private IList<IProduct> products;

        public Category(string setName)
        {
            this.Name = setName;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value);
                Validator.CheckIfStringLengthIsValid(value, Constants.categoryNameMaxSymbols, Constants.categoryNameMinSymbols,
                    string.Format(Constants.categoryInvalidName, Constants.categoryNameMinSymbols, Constants.categoryNameMaxSymbols));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics);
            products.Add(cosmetics);
        }

        public string Print()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(string.Format("{0} category – {1} {2} in total", this.Name, products.Count,
                products.Count == 1 ? "product" : "products"));

            var sortedProducts =
                from item in products
                orderby item.Brand ascending, item.Price descending
                select item;
                

            foreach (var item in sortedProducts)
            {
                strBuilder.Append(item.Print());
                strBuilder.AppendLine();
            }

            return strBuilder.ToString().Trim();
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics);
            if (products.Contains(cosmetics))
                products.Remove(cosmetics);
            else
                throw new KeyNotFoundException(string.Format(Constants.productDoesNotExist, cosmetics.Name, this.Name));

        }
    }
}
