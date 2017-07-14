﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";

            while (text != "end")
            {
                string replaced = Regex.Replace(
                  text, pattern, replacement);
                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }

        }
    }
}
