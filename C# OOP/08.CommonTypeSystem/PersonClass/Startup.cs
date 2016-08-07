namespace PersonClass
{
    using System;
    public class Startup
    {
        public static void Main()
        {
            var ivan = new Person("Ivan");

            Console.WriteLine(ivan);

            ivan.Age = 15;

            Console.WriteLine(ivan);
        }
    }
}
