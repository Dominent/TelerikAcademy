//-----------------------------------------------------------------------
// <copyright file="StringBuilderSubstring.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    /// <summary>
    /// Public class holding the main starting point of our program.
    /// </summary>
    public class StringBuilderSubstring
    {
        /// <summary>
        /// Main starting point of our program
        /// </summary>
        public static void Main()
        {
            var input = "To fix a violation of this rule, add or fill-in a documentation header for the element.";
            var index = 10;
            var length = 5;

            var strBuilder = new StringBuilder(input);

            Console.WriteLine(strBuilder.ToString());

            strBuilder = strBuilder.Substring(index, length);

            Console.WriteLine(strBuilder.ToString());
        }
    }
}
