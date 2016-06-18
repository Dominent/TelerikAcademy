using System;

namespace IntDoubleOrString
{
    class IntDoubleOrString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            if (input == "integer")
            {
                int val = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(val + 1);
            }
            else if (input == "real")
            {
                double val = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0:F2}", val + 1.00);
            }
            else
            {
                string val = Console.ReadLine();
                Console.WriteLine(val + "*");
            }
        }
    }
}
