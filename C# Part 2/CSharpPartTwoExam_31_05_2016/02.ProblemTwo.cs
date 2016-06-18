using System;
using System.Linq;
using System.Numerics;

namespace ExamProblemTwo
{
    class ExamProblemTwo
    {
        static void Main()
        {
            uint[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToUInt32(x)).ToArray();

            int times = 0;
            string direction = String.Empty;
            int step = 0;

            ulong sum = 0; // maybe BigInteger not sure !?
            var counter = 0;
            var index = 0;

            string movement = Console.ReadLine();
            while (movement != "stop")
            {
                var formatedString = movement.Split(' ');
                counter++;

                times = Convert.ToInt32(formatedString[0]);
                direction = formatedString[1];
                step = Convert.ToInt32(formatedString[2]);

                switch (direction)
                {
                    case "right":
                        {
                            for (int i = 0; i < times; i++)
                            {
                                index += step;
                                while ((index > input.Length - 1))
                                {
                                    index = index - input.Length;
                                }
                                sum += input[index];
                            }
                        }
                        break;
                    case "left":
                        {
                            for (int i = 0; i < times; i++)
                            {
                                index -= step;
                                while ((index < 0 ))
                                {
                                    index = input.Length - Math.Abs(index);
                                }
                                sum += input[index];
                            }
                        }
                        break;
                    default:
                        break;
                }
                movement = Console.ReadLine();
            }

            double result = Math.Round(sum / (double)counter, 1, MidpointRounding.AwayFromZero);

            Console.WriteLine("{0:F1}",result);
        }

    }
}
