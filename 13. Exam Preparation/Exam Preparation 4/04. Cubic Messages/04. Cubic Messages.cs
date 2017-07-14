using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
         
            while (true)
            {
                var message = Console.ReadLine();
                
                if (message == "Over!")
                {
                    break;
                }
                var m = int.Parse(Console.ReadLine());

                var regex = new Regex(@"^(?<leftPart>\d+)(?<chars>[A-Za-z]+)(?<rightPart>[^A-Za-z]*)$");

                Match match = regex.Match(message);
                
                if (!match.Success)
                {
                    continue;
                }

                var chars = match.Groups["chars"].Value;
                
                var leftPart = match.Groups["leftPart"].Value;
                var rightPart = match.Groups["rightPart"].Value;
                
                if (chars.Length != m)
                {
                    continue;
                }
                var resultString = leftPart + rightPart;

                var result = GetDecryptedMessage(chars, resultString);
                Console.WriteLine("{0} == {1}", chars,result);
            }
        }

        private static string GetDecryptedMessage(string chars, string resultString)
        {
            var sb = new StringBuilder();

            foreach (var @char in resultString)
            {
                if (!char.IsDigit(@char))
                {
                    continue;
                }

                var index = int.Parse(@char.ToString());

                var isValidIndex = index >= 0 && index < chars.Length;

                if (isValidIndex)
                {
                    sb.Append(chars[index]);
                }
                else
                {
                    sb.Append(' ');
                }
            }
            return sb.ToString();

        }
    }
}
