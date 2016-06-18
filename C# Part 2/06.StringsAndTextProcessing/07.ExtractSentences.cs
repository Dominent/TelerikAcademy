using System;
using System.Text;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();

            var strBuild = new StringBuilder();

            string[] output = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var sentance in output)
            {
                var index = sentance.IndexOf(" " + word + " ", StringComparison.Ordinal);
                if (index != -1)
                {
                    var startIndx = index;
                    var endIndx = index;
                    while (true)
                    {
                        if (startIndx > 0) startIndx--;
                        if (endIndx < sentance.Length - 1) endIndx++;

                        if ((sentance[startIndx] == '.' || sentance[endIndx] == '!' || sentance[endIndx] == '?')) break;
                        if (Char.IsUpper(sentance[endIndx])) break;

                        if (startIndx == 0 && endIndx == sentance.Length - 1)
                        {
                            strBuild.Append(sentance + '.');
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(strBuild.ToString());
        }
    }
}

