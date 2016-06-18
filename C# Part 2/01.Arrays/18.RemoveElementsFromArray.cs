using System;

namespace RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[input];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(input - LongestMaxSubSequence(numbers));
        }

        public static int LongestMaxSubSequence(int[] input)
        {
            int length = 0;
            int[] array = new int[input.Length];

            for (int i = 0; i < array.Length; i++)
                array[i] = 1;

            for (int i = 1; i < input.Length; i++)
                for (int j = 0; j < i; j++)
                    if (input[i] >= input[j] & array[i] <= array[j] + 1){
                        array[i] = array[j] + 1;
                        if (array[i] > length)
                            length = array[i];
                    }

            return length;
        }
    }
}
