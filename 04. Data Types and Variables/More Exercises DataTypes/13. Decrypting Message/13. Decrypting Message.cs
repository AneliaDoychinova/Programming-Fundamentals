﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var output = string.Empty;

            for (int i = 0; i < n; i++)
            {
                var letter = char.Parse(Console.ReadLine());

                var decryptedLetter = (char)(letter + key);
                output += decryptedLetter;
            }
            Console.WriteLine(output);
        }
    }
}
