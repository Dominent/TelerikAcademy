using System;

class AllocateArray
{
    static void Main()
    {
        int valN = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[valN];

        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = i * 5;

        foreach (var num in numbers)
            Console.WriteLine(num);

    }
}


