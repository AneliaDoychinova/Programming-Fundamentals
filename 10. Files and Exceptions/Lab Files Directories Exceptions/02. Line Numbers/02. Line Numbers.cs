﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output.txt", i+1 + ". " + text[i] + Environment.NewLine);
            }
        }
    }
}
