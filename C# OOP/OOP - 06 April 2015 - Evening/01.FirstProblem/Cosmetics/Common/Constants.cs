namespace Cosmetics.Common
{
    public class Constants
    {
        public const string categoryInvalidName = "Category name must be between {0} and {1} symbols long!";
        public const int categoryNameMinSymbols = 2;
        public const int categoryNameMaxSymbols = 15;
        public const string productDoesNotExist = "Product {0} does not exist in category {1}!";
        public const int productNameMinSymbols = 3;
        public const int productNameMaxSymbols = 10;
        public const string productInvalidName = "Product name must be between {0} and {1} symbols long!";
        public const int brandNameMinSymbols = 2;
        public const int brandNameMaxSymbols = 10;
        public const string brandInvalidName = "Product brand must be between {0} and {1} symbols long!";
        public const string invalidMoneyValue = "Money cannot be negative!";
        public const string invalidMillilitersValue = "Milliliters cannot be negative!";
        public const int ingredientNameMinSymbols = 4;
        public const int ingredientNameMaxSymbols = 12;
        public const string invalidIngredientName = "Each ingredient must be between {0} and {1} symbols long!";
    }
}
