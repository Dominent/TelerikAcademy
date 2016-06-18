using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        long oddNumSum = 1;
        long evenNumSum = 1;

        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < numbers.Length; i++)
            if (i % 2 == 0) //odd
                oddNumSum *= Convert.ToInt32(numbers[i]);
            else //even
                evenNumSum *= Convert.ToInt32(numbers[i]);

        Console.WriteLine("{0}",
            oddNumSum == evenNumSum ? String.Format("yes {0}", evenNumSum) : String.Format("no {0} {1}", oddNumSum, evenNumSum));
    }
}

