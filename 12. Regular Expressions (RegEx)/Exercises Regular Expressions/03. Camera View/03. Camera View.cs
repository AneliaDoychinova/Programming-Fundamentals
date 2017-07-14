using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace using_System_
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var numToSkip = numbers[0];
            var numToTake = numbers[1];

            var text = Console.ReadLine();
            var pattern = @"\|<(?<words>\w+)";

            MatchCollection matches = Regex.Matches(text, pattern);
            
            var words = new List<string>();

            foreach (Match match in matches)
            {
                var result = new string(match.Groups["words"].Value.ToArray().Skip(numToSkip).Take(numToTake).ToArray());
                words.Add(result);
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
