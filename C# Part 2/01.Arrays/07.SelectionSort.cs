using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int valN = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[valN];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbers.Length - 1; i++)
                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[i] > numbers[j])
                        ExchangeTwoVals(ref numbers[i], ref numbers[j]);

            foreach (int num in numbers)
                Console.WriteLine(num);
        }

        static void ExchangeTwoVals(ref int val1, ref int val2)
        {
            val1 = val1 ^ val2;
            val2 = val1 ^ val2;
            val1 = val1 ^ val2;
        }
    }
}
