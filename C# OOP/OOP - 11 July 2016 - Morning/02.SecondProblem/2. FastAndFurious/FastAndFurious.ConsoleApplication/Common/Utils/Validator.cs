namespace FastAndFurious.ConsoleApplication.Common.Utils
{
    using System;

    public class Validator
    {
        public static void ValidateNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
