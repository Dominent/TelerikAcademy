using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamProblemFive
{
    internal class ExamProblemFive
    {
        private static void Main()
        {
            /*----- 324 -----*/
            /*    So Amaze   */
            /*    Much Win   */
            /*    Very Hard  */
            /*      WoW      */
            /*      25M      */
            /*---------------*/

            var n = Convert.ToInt32(Console.ReadLine());

            var map = new Dictionary<int, List<int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                if (input == "None")
                {
                    map.Add(i, new List<int>() { -1 });
                }
                else
                {
                    var temp = input.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

                    map.Add(i, new List<int>());
                    foreach (var path in temp)
                    {
                        map[i].Add(path);
                    }
                }

            }
            var strBuilder = new StringBuilder();

            var paths = Console.ReadLine();
            while (paths != "Have a break")
            {
                var temp = paths.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

                if (map[temp[0]].Contains(temp[1]))
                {
                    strBuilder.AppendLine("There is a direct flight.");
                }
                else
                {
                    if (CheckFlights(map, temp[0], temp[1]))
                        strBuilder.AppendLine("There are flights, unfortunately they are not direct, grandma :(");
                    else
                        strBuilder.AppendLine("No flights available.");
                }
                paths = Console.ReadLine();
            }

            Console.WriteLine(strBuilder.ToString());
        }

        public static bool CheckFlights(Dictionary<int, List<int>> map, int key, int dest)
        {
            if (map[dest].Contains(-1))
                return false;

            foreach (var val in map[key])
            {
                if (val != -1)
                {
                    if (map[val].Contains(key))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
