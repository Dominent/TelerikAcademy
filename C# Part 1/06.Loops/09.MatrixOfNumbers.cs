using System;
using System.Text;

class MatrixOfNumbers
{
    static void Main()
    {
        int input = Convert.ToInt32(Console.ReadLine());
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < input; i++) // 0, 1, 2, 3
        {
            for (int j = i + 1, k = 0; k < input; k++, j++)
                sb.Append(String.Format(" {0}", j));

            Console.WriteLine(sb.ToString().TrimStart(' '));
            sb.Clear();
        }
    }
}

