using System;
using System.Linq;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static void Main()
        {
            int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(AppCount(number, input));
        }

        static int AppCount(int pattern, int[] input)
        {
           return input.Where(x => x== pattern).Count();
        }
    }
}
