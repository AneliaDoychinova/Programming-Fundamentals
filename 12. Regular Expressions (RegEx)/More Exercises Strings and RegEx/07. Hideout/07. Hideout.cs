using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = Console.ReadLine();
              while (true)
            {
                var input = Console.ReadLine().Split(' ');
                var character = char.Parse(input[0]);
                var num = int.Parse(input[1]);
                
                var pattern = @".*(?<result>\" + character + "{" + num + ",}).*";
                Match match = Regex.Match(map, pattern);
                if (match.Success)
                {
                    var regex = "\\"+character + "{" + num + ",}";
                    var resultMatch = Regex.Match(map, regex);
                    var resultIndex = resultMatch.Index;
                    var resultLenght = resultMatch.Length;

                    Console.WriteLine("Hideout found at index {0} and it is with size {1}!", resultIndex,resultLenght);
                    break;
                }        
            }
            
        }
    }
}
