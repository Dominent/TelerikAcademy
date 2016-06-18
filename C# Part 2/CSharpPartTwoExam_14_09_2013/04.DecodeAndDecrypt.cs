using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DecodeAndDecrypt
{
    class DecodeAndDecrypt
    {
        static void Main()
        {
            string encryptedMsg = Console.ReadLine();

            int length = GetLength(encryptedMsg);

            string word = Decode(encryptedMsg, length.ToString().Length);

            string cypher = GenerateCypher(word, length);

            string message = Encrypt(word.Remove(word.Length - length), cypher);

            Console.WriteLine(message);
        }

        static string GenerateCypher(string input, int cypherLength)
        {
            int index = input.Length - cypherLength;

            return input.Substring(index, input.Length - index);
        }

        static string Decode(string input, int cypherLength)
        {
            var strBuilder = new StringBuilder();

            for (int i = 0; i < input.Length - cypherLength; i++)
            {
                if (!char.IsDigit(input[i])) strBuilder.Append(input[i]);
                else
                {
                    int length = (input[i] - '1');
                    strBuilder.Append(new string(input[i + 1], length));
                }
            }

            return strBuilder.ToString();
        }

        static string Encrypt(string input, string cypher)
        {
            var strBuilder = new StringBuilder(input);

            var steps = Math.Max(input.Length, cypher.Length);

            for (int step = 0; step < steps; step++)
            {
                var inputIndx = step % input.Length;
                var cypherIndx = step % cypher.Length;

                strBuilder[inputIndx] =
                    (char)(((strBuilder[inputIndx] - 'A') ^ (cypher[cypherIndx] - 'A')) + 'A');
            }

            return strBuilder.ToString();
        }

        static int GetLength(string input)
        {
            const string pattern = "[0-9]+$";

            var rgx = new Regex(pattern);
            return Convert.ToInt32(rgx.Match(input).Value);
        }
    }
}
