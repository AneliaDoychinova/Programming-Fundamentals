using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"<.{2}>";

            MatchCollection matches = Regex.Matches(text, pattern);
            var sb = new StringBuilder();
            sb.Append(text);

            for (int i = 0; i < matches.Count; i++)
            {
                var mine = matches[i].Value;
                var indexofMine = matches[i].Index;
                var minePower = Math.Abs((int)mine[1] - (int)mine[2]);

                ReplacingMines(text, sb, mine, indexofMine, minePower);

            }
            var result = sb.ToString();
            Console.WriteLine(result);

        }

        private static void ReplacingMines(string text, StringBuilder sb, string mine, int indexofMine, int minePower)
        {
            var leftIndexToReplace = Math.Max(0, indexofMine - minePower);
            var rightIndexToReplace = Math.Min(indexofMine + minePower + 3, text.Length - 1);

            for (int i = leftIndexToReplace; i <= rightIndexToReplace; i++)
            {
                sb[i] = '_';
            }
        }
    }
}
