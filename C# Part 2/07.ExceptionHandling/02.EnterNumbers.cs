using System;
using System.Collections.Generic;
using System.Text;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            ReadNumber(0, 100);
        }

        static void ReadNumber(int start, int end)
        {
            int currInput = 0;
            int prevInput = 0;
            bool quit = false;

            var listInt = new List<int>();
            listInt.Add(1);
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    currInput = Convert.ToInt32(Console.ReadLine());
                    if (currInput <= prevInput || currInput >= 100)
                    {
                        Console.WriteLine("Exception");
                        quit = true;
                        break;
                    }
                    else
                    {
                        listInt.Add(currInput);
                    }
                    prevInput = currInput;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception");
                    quit = true;
                    break;
                }

            }
            if (!quit)
            {
                listInt.Add(100);
                var strBuilder = new StringBuilder();

                foreach (var num in listInt)
                {
                    strBuilder.Append(num.ToString() + ' ' + '<'+ ' ');
                }

                Console.WriteLine(strBuilder.ToString().TrimEnd(new char[] { ' ', '<', ' ' }));
            }
           
        }
    }
}
