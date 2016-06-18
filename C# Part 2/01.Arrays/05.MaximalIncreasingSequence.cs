using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MaxIncSeq(valN));
    }

    static int MaxIncSeq(int input)
    {
        int count = 1;
        int maxCount = 0;
        int sum = 0;
        int maxSum = 0;

        int currentElement = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < input - 1; i++)
        {
            int previousElement = currentElement;

            currentElement = Convert.ToInt32(Console.ReadLine());
            if (previousElement <= currentElement)
            {
                count++;
                sum += currentElement;
                if (sum >= maxSum)
                {
                    maxCount = count;
                    maxSum = sum;
                }
            }
            else
            {
                count = 1;
                sum = previousElement;
            }
        }
        return maxCount;
    }
}

