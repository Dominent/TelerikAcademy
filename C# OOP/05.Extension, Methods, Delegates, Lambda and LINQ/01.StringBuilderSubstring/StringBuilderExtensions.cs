//-----------------------------------------------------------------------
// <copyright file="StringBuilderExtensions.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace StringBuilderSubstring
{
    using System.Text;

    /// <summary>
    /// Public class holding extension methods for StringBuilder.
    /// </summary>
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Implements an extension method Substring for the class StringBuilder.
        /// Has the same functionality as Substring in the class String.
        /// </summary>
        /// <param name="index">The start index of the string we want.</param>
        /// <param name="length">The length of the wanted string.</param>
        /// <param name="strBuilder">Extension method base class.</param>
        /// <returns>New instance of the object StringBuilder, with the substring.</returns>
        public static StringBuilder Substring(this StringBuilder strBuilder, int index, int length)
        {
            return new StringBuilder(strBuilder.ToString().Substring(index, length));
        }
    }
}
