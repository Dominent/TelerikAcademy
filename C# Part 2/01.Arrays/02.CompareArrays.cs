using System;

class CompareArrays
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[valN];
        bool areEqual = false;
        
        for (int i = 0; i < valN; i++)
            numbers[i] = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < valN; i++)
        {
            if (Convert.ToInt32(Console.ReadLine()) == numbers[i])
                areEqual = true;
            else
            {
                areEqual = false;
                break;
            }
                
        }

        Console.WriteLine("{0}", areEqual?"Equal":"Not equal");
           

    }
}

