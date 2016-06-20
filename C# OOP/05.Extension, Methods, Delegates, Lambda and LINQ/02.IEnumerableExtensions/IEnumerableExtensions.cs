//-----------------------------------------------------------------------
// <copyright file="IEnumerableExtensions.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace IEnumerableExtensions
{
    using System.Collections.Generic;

    /// <summary>
    /// Class holds custom IEnumerable extension methods.
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Adds an element at the end of a collection.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="collection">Extension method target.</param>
        /// <param name="x">Item to add to the collection.</param>
        /// <returns>New collection with the item added to it.</returns>
        public static IEnumerable<T> Add<T>(this IEnumerable<T> collection, T x)
        {
            foreach (var item in collection)
            {
                yield return item;
            }

            yield return x;
        }

        /// <summary>
        /// Calculates the product of two generic items.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="collection">Extension method target.</param>
        /// <param name="x">First item to be multiplied.</param>
        /// <param name="y">Second item to be multiplied.</param>
        /// <returns>The product of the multiplied items.</returns>
        public static T Product<T>(this IEnumerable<T> collection, T x, T y) where T : struct
        {
            return (dynamic)x * y;
        }

        /// <summary>
        /// Compares two items and finds the minimum item.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="collection">Extension method target.</param>
        /// <param name="x">First item to be compared</param>
        /// <param name="y">Second item to be compared</param>
        /// <returns>The minimum item out of the two items.</returns>
        public static T Min<T>(this IEnumerable<T> collection, T x, T y) where T : struct
        {
            return (dynamic)x > y ? y : x;
        }

        /// <summary>
        /// Compares two items and finds the maximal item out of them.
        /// </summary>
        /// <typeparam name="T">Generic type.</typeparam>
        /// <param name="collection">Extension method target.</param>
        /// <param name="x">First item to be compared.</param>
        /// <param name="y">Second item to be compared.</param>
        /// <returns>The maximum item out of the two items.</returns>
        public static T Max<T>(this IEnumerable<T> collection, T x, T y) where T : struct
        {
            return (dynamic)x > y ? x : y;
        }
    }
}
