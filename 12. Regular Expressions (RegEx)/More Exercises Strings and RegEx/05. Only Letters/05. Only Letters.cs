using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = Console.ReadLine();
            var regex =new Regex (@"\d+");

            MatchCollection matches = regex.Matches(message);
            
            var sb = new StringBuilder();
            sb.Append(message);

            for (int i = 0; i <matches.Count; i++)
            {
                var number = matches[i].Value;
                var indexNum = matches[i].Index;
                if (indexNum + number.Length > message.Length-1)
                {
                    continue;
                }
                var charToReplace = message[indexNum + number.Length];

                sb.Replace(number, charToReplace.ToString());
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
