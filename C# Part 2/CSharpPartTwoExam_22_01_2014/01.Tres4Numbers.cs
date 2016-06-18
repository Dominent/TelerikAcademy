using System;
using System.Numerics;
using System.Text;

namespace Tres4Numbers
{
    class Tres4Numbers
    {
        static void Main()
        {
            ulong input = Convert.ToUInt64(Console.ReadLine());

            int numeralSystem = 9;

            string[] TRESNUM4 = new[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

            var strBuilder = new StringBuilder();

            do
            {
                int digitIn9NumSys = (int)(input % (ulong)numeralSystem);
                strBuilder.Insert(0, TRESNUM4[digitIn9NumSys]);
                input /= (ulong)numeralSystem;

            }
            while (input > 0);

            Console.WriteLine(strBuilder.ToString());
        }
    }
}
