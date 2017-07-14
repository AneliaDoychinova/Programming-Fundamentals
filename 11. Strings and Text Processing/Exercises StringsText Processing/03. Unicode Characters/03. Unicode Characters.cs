using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = Console.ReadLine().ToArray();
            var unicode = string.Empty;

            for (int i = 0; i < chars.Length; i++)
            {
               unicode += "\\u" + ((int)chars[i]).ToString("x4");
                
            }

            Console.WriteLine(unicode);

        }
    }
}
