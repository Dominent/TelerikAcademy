using System;

namespace SayHello
{
    class SayHello
    {
        static void Main() => Hello(Console.ReadLine());
        public static void Hello(string name) => Console.WriteLine("Hello, " + name + "!");
    }
}
