using System;

namespace ExchangeIfGreater
{
    class ExcangeIfGreater
    {
        static void Main()
        {
            double valA = Convert.ToDouble(Console.ReadLine());
            double valB = Convert.ToDouble(Console.ReadLine());

            if (valA > valB)
            {
                double temp = valA;
                valA = valB;
                valB = temp;
            }
            Console.WriteLine("{0} {1}", valA, valB);
        }
    }
}
