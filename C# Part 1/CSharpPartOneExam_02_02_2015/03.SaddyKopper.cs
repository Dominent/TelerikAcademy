using System;
using System.Numerics;

namespace SaddyKopper
{
    class SaddyKopper
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            int count = 0;
            int result = 0;
            BigInteger output = 1;

            while (true)
            {
                for (int i = 1; i < input.Length; i++) //123456 -> //12345
                {
                    for (int j = 0; j <= (input.Length - 1) - i; j++) // oprosti formulata
                    {
                        if (j % 2 == 0)// starting from zero
                            result += Convert.ToInt32(input[j] - '0');
                    }
                    output *= result;
                    result = 0;
                }
                count += 1;
                if (output < 10)
                {
                    Console.WriteLine(count);
                    Console.WriteLine(output);
                    break;
                }

                if (count == 10)
                {
                    Console.WriteLine(output);
                    break;
                }
                    input = output.ToString().ToCharArray();
                    output = 1;
            }
        }
    }
}
