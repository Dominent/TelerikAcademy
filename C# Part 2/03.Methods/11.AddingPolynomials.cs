using System;
using System.Collections.Generic;
using System.Linq;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main()
        {
            int dimensions = Convert.ToInt32(Console.ReadLine());
            List<int> firstPolynomial = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();
            List<int> secondPolynomial = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToList();

            while (firstPolynomial.Count > secondPolynomial.Count) firstPolynomial.Insert(0, 0);
            while (firstPolynomial.Count < secondPolynomial.Count) secondPolynomial.Insert(0, 0);

            Console.WriteLine(String.Join(" ", AddPolynomials(firstPolynomial.ToArray(), secondPolynomial.ToArray())));

        }

        static int[] AddPolynomials(int[] firstPolynomial, int[] secondPolynomial)
        {
            int arrSize = (firstPolynomial.Count() + secondPolynomial.Count())/2;

            int[] output = new int[arrSize];

            for (int i = 0; i < arrSize; i++) output[i] = firstPolynomial[i] + secondPolynomial[i];

            return output;
        }
    }
}
