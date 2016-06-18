using System;

namespace SecondProject
{
    class SecondProject
    {
        static void Main()
        {
            int carCount = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int maxCount = 0;
            int initialSpeed = 0;
            bool inGroup = false;
            long sum = 0;
            long maxSum = 0;

            for (int i = 0; i < carCount; i++)
            {
                int currentCarSpeed = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    initialSpeed = currentCarSpeed;
                    count = 1;
                    inGroup = true;
                    sum = initialSpeed;
                }
                else
                {
                    if (currentCarSpeed > initialSpeed)
                    {
                        if (inGroup)
                        {
                            ++count;
                            sum += currentCarSpeed;
                        }
                        else //(inGroup == false)
                        {
                            inGroup = true;
                            count = 2;
                            sum = currentCarSpeed + initialSpeed;
                        }
                    }
                    else
                    {
                        if (currentCarSpeed > 1500 || initialSpeed > 1500)
                        {
                            inGroup = false;
                            count = 0;
                            sum = 0;
                        }
                        else
                        {
                            inGroup = false;
                            if (count > maxCount)
                            {
                                maxCount = count;
                            }
                            if (sum > maxSum)
                            {
                                maxSum = sum;
                            }
                            count = 0;
                            sum = 0;
                        }
                    }
                }

                if (currentCarSpeed > 1500 || initialSpeed > 1500)
                {
                    inGroup = false;
                    count = 0;
                    sum = 0;
                }
                else
                {
                    if (count > maxCount)
                        maxCount = count;
                    if (sum > maxSum)
                        maxSum = sum;
                }

                if (inGroup == false)
                    initialSpeed = currentCarSpeed;
            }

            Console.WriteLine(maxSum);
        }
    }
}
