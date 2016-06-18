using System;

class MaximalKSum
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[valN];
        int valK = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = Convert.ToInt32(Console.ReadLine());

        Array.Sort(numbers);

        for (int i = numbers.Length - valK; i < numbers.Length; i++)
            sum += numbers[i];


        Console.WriteLine(sum);
    }
}

