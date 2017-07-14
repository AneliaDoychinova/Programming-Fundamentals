using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 1)
                {
                    File.AppendAllText("output.txt", text[i] + Environment.NewLine);
                }
            }
        }
    }
}
