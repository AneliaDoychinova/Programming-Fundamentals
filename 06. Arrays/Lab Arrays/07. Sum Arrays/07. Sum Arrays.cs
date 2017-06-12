using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var len1 = firstArray.Length;
            var len2 = secondArray.Length;

            var sumArray = new int[Math.Max(len1, len2)];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstArray[i%len1] + secondArray[i%len2];
            }
            Console.WriteLine(string.Join(" ", sumArray));

        }
    }
}
