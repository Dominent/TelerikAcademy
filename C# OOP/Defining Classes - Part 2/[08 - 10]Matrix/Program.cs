namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            var item1 = new Matrix<int>(2, 3)
            {
                Elements = new int[2, 3]
                {
                    {1, 2, 3},
                    {4, 5, 6},
                }
            };

            var item2 = new Matrix<int>(3, 2)
            {
                Elements = new int[3, 2]
                {
                    {1, 2},
                    {3, 4},
                    {5, 6}
                }
            };

            var item3 = new Matrix<int>(3, 2)
            {
                Elements = new int[3, 2]
                {
                    {1, 2},
                    {3, 4},
                    {5, 6}
                }
            };


            Console.WriteLine(item2 - item3);
            Console.WriteLine(item2 + item3);
            Console.WriteLine(item1 * item2);

            Console.WriteLine(item3[1,1]);

            Console.WriteLine((item3 - item2) ? true : false);
        }
    }
}
