using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringInput = Console.ReadLine();
            var didimonPattern = new Regex(@"[^a-zA-Z-]+");
            var bojomonPattern = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");

            while (true)
            {
                var didimonMatch = didimonPattern.Match(stringInput);
                if (!didimonMatch.Success)
                {
                    break;
                }

                Console.WriteLine(didimonMatch.Value);
                var index = stringInput.IndexOf(didimonMatch.Value);
                stringInput = stringInput.Remove(0,didimonMatch.Length + index);

                var bojomonMatch = bojomonPattern.Match(stringInput);
                if (!bojomonMatch.Success)
                {
                    break;
                }
                Console.WriteLine(bojomonMatch);
                index = stringInput.IndexOf(bojomonMatch.Value);
                stringInput = stringInput.Remove(0,bojomonMatch.Length+index);
            }

        }
    }
}
