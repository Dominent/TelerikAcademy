using System;

namespace FourthProject
{
    class FourthProject
    {
        static void Main()
        {
            //Malko kote - seks ima li ? :D -> V.Bojinov
            int input = Convert.ToInt32(Console.ReadLine());
            char symbol = Convert.ToChar(Console.Read());
            int countEven = 5;

            int length = input;

            for (int i = 10; i <= length; i+=4) // Ebasi mo Telerik 
                    countEven++;

            int test = countEven - 1;


            Console.WriteLine(' ' + symbol.ToString() + new string(' ', test - 4) + symbol.ToString());
            for (int i = 0; i < test - 4; i++)
            {
                Console.WriteLine(' ' + new string(symbol, test - 2));
            }
            for (int i = 0; i < test - 4; i++)
            {
                Console.WriteLine(new string(' ', 2) + new string(symbol, test - 4));
            }
            for (int i = 0; i < test - 4; i++)
            {
                Console.WriteLine(' ' + new string(symbol, test - 2));
            }
            Console.WriteLine(' ' + new string(symbol, test - 2) + new string(' ', 3) + new string(symbol, test - 3));

            for (int i = 0; i < test - 2; i++)
            {
                Console.WriteLine(new string(symbol, test) + new string(' ', 2) + new string(symbol, 1));
            }
            Console.WriteLine(new string(symbol, test) + new string(' ', 1) + new string(symbol, 2));
            Console.WriteLine(' ' + new string(symbol, countEven));


        }
    }
}
