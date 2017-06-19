using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var numsCount = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNum = numbers[i];
                if (!numsCount.ContainsKey(currentNum))
                {
                    numsCount.Add(currentNum, 0);
                }
                numsCount[currentNum]++;
            }
            foreach (var kvp in numsCount)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
            
        }
    }
}
