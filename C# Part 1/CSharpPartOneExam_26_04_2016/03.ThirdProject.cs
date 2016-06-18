using System;

namespace ThirdProject
{
    class ThirdProject
    {
        static void Main()
        {
            int valA = Convert.ToInt32(Console.ReadLine());
            int valB = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = valA; i <= valB; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        if (j % 2 == 0)
                        {
                            sum += j;
                        }
                    }
                }
            }
            Console.WriteLine(sum);

        }

    }
}
