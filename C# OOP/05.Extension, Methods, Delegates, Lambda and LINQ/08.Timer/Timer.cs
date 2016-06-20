//-----------------------------------------------------------------------
// <copyright file="Timer.cs" company="Telerik Academy">
// Telerik Academy by Progress
// </copyright>
// <author>Petromil "Dominent" Pavlov </author>
//-----------------------------------------------------------------------

namespace Timer
{
    using System.Threading;

    /// <summary>
    /// The public class Timer contains all methods that execute after given time.
    /// </summary>
    public static class Timer
    {
        /// <summary>
        /// Used to store input functions.
        /// </summary>
        public delegate void CustomDelegate();

        /// <summary>
        /// Runs a function after given seconds.
        /// </summary>
        /// <param name="seconds">Wait time for function execution</param>
        /// <param name="input">Function which will be executed</param>
        public static void RunFunc(int seconds, CustomDelegate input)
        {
            var milliSeconds = (int)(seconds / 0.001);

            while (true)
            {
                Thread.Sleep(milliSeconds);

                input.Invoke();
            }
        }
    }
}
