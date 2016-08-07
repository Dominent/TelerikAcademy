namespace Cosmetics.Products
{
    using Contracts;
    using System;
    using Common;
    using System.Text;
    using System.Collections.Generic;

    public class Toothpaste : Product, IToothpaste
    {
        public Toothpaste(string setName, string setBrand, decimal setPrice, GenderType setGender, IList<string> setIngredients)
            : base(setName, setBrand, setPrice, setGender)
        {
            Validator.CheckIfNull(setIngredients);
            foreach(var item in setIngredients)
            {
                Validator.CheckIfStringLengthIsValid(item, Constants.ingredientNameMaxSymbols, Constants.ingredientNameMinSymbols, 
                    string.Format(Constants.invalidIngredientName, Constants.ingredientNameMinSymbols, Constants.ingredientNameMaxSymbols));
            }
            this.Ingredients = String.Join(", ", setIngredients);
        }

        public string Ingredients { get; private set; }

        public override string Print()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            strBuilder.AppendLine(string.Format("  * Price: ${0}", this.Price));
            strBuilder.AppendLine(string.Format("  * For gender: {0}", Enum.GetName(typeof(GenderType), Gender)));
            strBuilder.Append(string.Format("  * Ingredients: {0}", Ingredients));
            return (strBuilder.ToString().Trim());
        }
    }
}
