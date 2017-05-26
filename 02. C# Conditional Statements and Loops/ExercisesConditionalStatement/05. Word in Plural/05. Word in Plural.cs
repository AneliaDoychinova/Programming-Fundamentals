using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            string characterY = "y";
            var characters = new string[] { "o", "ch", "s", "sh", "x", "z" };

            if (word.EndsWith(characterY))
            {
                var removeIndex = word.IndexOf(characterY);
                var result = word.Remove(removeIndex);
                Console.WriteLine(result + "ies");
            }
            else if (word.EndsWith(characters[0]) || word.EndsWith(characters[1]) || word.EndsWith(characters[2]) || 
                word.EndsWith(characters[3]) || word.EndsWith(characters[4]) || word.EndsWith(characters[5]))
            {
                Console.WriteLine(word + "es");
            }
            else
            {
                Console.WriteLine(word + "s");
            }
        }
    }
}
