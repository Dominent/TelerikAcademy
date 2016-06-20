//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace Timer
{
    using System;

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
            Timer.RunFunc(
                10,
                delegate
                {
                    Console.WriteLine("Doge Doge Doge");
                });
        }
    }
}
