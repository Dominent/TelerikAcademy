namespace GenericClass
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
            var list = new GenericList<int>(10);

            for (int i = 0; i < 10; i++)
                list.Add(i);

            Console.WriteLine(list);

            list.InsertAt(382, 3);

            list.RemoveAt(3);

            Console.WriteLine(list);

            //list.InsertAt(12, 11);


        }
    }
}
