using System;

namespace TextToNumber
{
    class TextToNumber
    {
        static void Main()
        {
            int valM = Convert.ToInt32(Console.ReadLine());
            char input = Convert.ToChar(Console.Read());

            long result = 0;


            while (input != '@')
            {
                if (char.IsDigit(input))
                    result *= Convert.ToInt32(input - '0');
                else if(char.IsLetter(input))
                    result +=(char.ToUpper(input) - 65);
                else
                    result %= valM;

                input = Convert.ToChar(Console.Read());
            }

            Console.WriteLine(result);
        }
    }
}
