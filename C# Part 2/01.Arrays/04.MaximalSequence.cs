using System;

class MaximalSequence
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());

        int count = 1;
        int maxCount = 0;

        int currentElement = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < valN - 1; i++)
        {
            int previousElement = currentElement;
            currentElement = Convert.ToInt32(Console.ReadLine());
            if (previousElement == currentElement)
            {
                count++;
                if (count > maxCount)
                    maxCount = count;
            }
            else
                count = 1;
        }

        Console.WriteLine(maxCount);
    }
}

