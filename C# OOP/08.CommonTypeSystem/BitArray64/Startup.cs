namespace BitArray64
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var test = new BitArray64(125125215152115125);

            Console.WriteLine(test);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(test[i]);
            }

            var test2 = new BitArray64(32);

            Console.WriteLine(test == test2);

            Console.WriteLine(test != test2);
        }
    }
}
