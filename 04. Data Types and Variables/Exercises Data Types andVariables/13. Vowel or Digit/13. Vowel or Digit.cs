using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            var ascii = (int)input;
            var vowels = new char[] {'a', 'e', 'i', 'o', 'u' };
            
            if (ascii > 47 && ascii < 58)
            {
                Console.WriteLine("digit");
            }
            else if (vowels.Contains(input))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
