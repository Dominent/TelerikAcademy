using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1}", (input % 2 == 0 ? "even" : "odd"), input);
        }
    }
}
