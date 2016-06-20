//-----------------------------------------------------------------------
// <copyright file="DivisibleBy7And3.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    /// <summary>
    /// Public class holding the main starting point of our program.
    /// </summary>
    public class DivisibleBy7And3
    {
        /// <summary>
        /// Main starting point of our program
        /// </summary>
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            var output = input.Where(x => (x % 3 == 0 && x % 7 == 0));

            foreach (var item in output)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
