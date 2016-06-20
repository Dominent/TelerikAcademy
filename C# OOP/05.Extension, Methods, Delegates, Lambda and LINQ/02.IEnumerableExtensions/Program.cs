//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace IEnumerableExtensions
{
    using System;
    using System.Linq;

    /// <summary>
    /// Public class holding the main starting point of our program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main starting point of our program
        /// </summary>
        public static void Main()
        {
            var array = new int[]
            {
                1, 2, 3, 4, 5, 6
            };

            array = array.Add<int>(22).ToArray<int>();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(array.Product<int>(array[0], array[1]));

            Console.WriteLine(array.Min<int>(array[0], array[1]));

            Console.WriteLine(array.Max<int>(array[0], array[1]));
        }
    }
}
