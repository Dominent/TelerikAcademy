namespace VersionAttribute
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Version(1, 11)]
    class Program
    {
        static void Main()
        {
            VersionAttribute attribute = (VersionAttribute)Attribute.GetCustomAttribute(typeof(Program), typeof(VersionAttribute));

            Console.WriteLine(attribute.ToString());
        }
    }
}