//-----------------------------------------------------------------------
// <copyright file="LongestString.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace LongestString
{
    using System;
    using System.Linq;

    /// <summary>
    /// Public class holding the main starting point of our program.
    /// </summary>
    public class LongestString
    {
        /// <summary>
        /// Main starting point of our program
        /// </summary>
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var output =
                from str in input
                orderby str descending
                select str;

            Console.WriteLine(output.First().Length);
        }
    }
}
