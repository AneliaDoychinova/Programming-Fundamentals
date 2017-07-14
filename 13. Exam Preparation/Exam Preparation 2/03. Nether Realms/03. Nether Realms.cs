using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var demon in demons.OrderBy(n => n))
            {
                var health = 0;
                var damage = 0.0;

                var regexLetters = new Regex(@"[^\d\*\/\+\.\-]");
                MatchCollection letters = regexLetters.Matches(demon);
                foreach (Match letter in letters)
                {
                    health += char.Parse(letter.Value);
                }

                var regexDigits = new Regex(@"([\-|\+])*(\d+\.)*\d+");
                MatchCollection digits = regexDigits.Matches(demon);
                foreach (Match digit in digits)
                {
                    damage += double.Parse(digit.Value);
                }

                var regexSymbols = new Regex(@"[\*|\/]");
                MatchCollection symbols = regexSymbols.Matches(demon);
                foreach (Match symbol in symbols)
                {
                    if (symbol.Value == "*")
                    {
                        damage *= 2;
                    }
                    else if (symbol.Value == "/")
                    {
                        damage /= 2;
                    }
                }

                Console.WriteLine("{0} - {1} health, {2:F2} damage ", demon, health, damage);
            }
        }
    }
}
