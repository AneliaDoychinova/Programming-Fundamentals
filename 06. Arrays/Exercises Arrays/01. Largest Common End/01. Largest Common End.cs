using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var words1 = Console.ReadLine().Split().ToArray();
            var words2 = Console.ReadLine().Split().ToArray();

            var leftCount = 0;
            var rightCount = 0;

            var smallestArray = Math.Min(words1.Length, words2.Length);

            for (int i = 0; i < smallestArray; i++)
            {
                if (words1[i] == words2[i])
                {
                    leftCount++;
                }

                if (words1[words1.Length - 1 - i] == words2[words2.Length - 1 - i])
                {
                    rightCount++;
                }
            }
        
            Console.WriteLine(Math.Max(leftCount,rightCount));
            

        }
    }
}
