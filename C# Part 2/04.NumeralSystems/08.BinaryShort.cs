using System;
using System.Text;

namespace BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {
            short input = Convert.ToInt16(Console.ReadLine());
            var strBuild = new StringBuilder();
            for (int i = 0; i < 16; i++) strBuild.Insert(0, ((input & (1 << i)) >> i));
            Console.WriteLine(strBuild.ToString().PadLeft(16, '0'));
        }
    }
}
