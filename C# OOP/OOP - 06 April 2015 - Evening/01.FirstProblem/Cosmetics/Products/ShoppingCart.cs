namespace Cosmetics.Products
{
    using Common;
    using Contracts;
    using System.Collections.Generic;

    public class ShoppingCart : IShoppingCart
    {
        private IList<IProduct> products;

        public ShoppingCart()
        {
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            Validator.CheckIfNull(product);
            products.Add(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            Validator.CheckIfNull(product);
            return products.Contains(product);
        }

        public void RemoveProduct(IProduct product)
        {
            Validator.CheckIfNull(product);
            products.Remove(product);
        }

        public decimal TotalPrice()
        {
            var sum = 0m;
            foreach (var item in products)
            {
                if (item is IShampoo)
                {
                    sum += (item as Shampoo).Price;
                }
                sum += item.Price;
            }
            return sum;
        }
    }
}
