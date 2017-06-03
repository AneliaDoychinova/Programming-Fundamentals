using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";

            object words = word1 + " " + word2;

            string concatenated = (string)words;

            Console.WriteLine(concatenated);
        }
    }
}
