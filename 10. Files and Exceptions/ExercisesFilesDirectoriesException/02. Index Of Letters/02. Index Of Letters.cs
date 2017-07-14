using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Index_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("input.txt");

            for (int i = 0; i < input.Length; i++)
            {
                var chars = input[i];
                var charNum = (int)input[i] - 97;
                File.AppendAllText("output.txt", chars +  " -> " + charNum + Environment.NewLine);
            }
        }
    }
}
