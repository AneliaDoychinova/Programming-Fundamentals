﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                var charIndex = input[i] - 97;
                Console.WriteLine("{0} -> {1}", input[i],charIndex);
            }
        }
    }
}
