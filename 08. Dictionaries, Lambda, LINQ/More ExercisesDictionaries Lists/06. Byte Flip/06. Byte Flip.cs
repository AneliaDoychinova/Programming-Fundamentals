using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var removedElements = input.Where(a => a.Length == 2).Reverse().Select(a => a).ToList();
            var reversed = new List<string>();

            for (int i = 0; i < removedElements.Count; i++)
            {
                var currentElement = removedElements[i];
                var arr = currentElement.ToCharArray();
                Array.Reverse(arr);
                reversed.Add(new string (arr));
            }
            var decimalNums = reversed.Select(a => Convert.ToInt32(a, 16)).ToList();

            foreach (var num in decimalNums)
            {
                Console.Write((char)num);
            }
            Console.WriteLine();
        }
    }
}
