using System;
using System.Linq;
using System.Text;

namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            long[] input = new long[3];
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 3; i++)
                input[i] = Convert.ToInt64(Console.ReadLine());
          
            input.OrderByDescending(x => x).ToList().ForEach(x => sb.Append(" " + x));
            Console.WriteLine(sb.ToString().TrimStart(' '));
        }
    }
}
