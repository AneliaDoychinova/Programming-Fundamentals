using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.Write_to_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("sample_text.txt").ToCharArray();

            var chars = new char[] { '.', ',', '!', '?', ':' };
            var letters = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!chars.Contains(text[i]))
                {
                    var letter = text[i].ToString();
                   File.AppendAllText("output.txt", letter);
                }

            }
            
        }
    }
}
