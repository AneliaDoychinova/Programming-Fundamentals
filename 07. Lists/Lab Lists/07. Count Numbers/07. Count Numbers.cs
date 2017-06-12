using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var countNums = new Dictionary<int, int>();
            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!countNums.ContainsKey(numbers[i]))
                {
                    countNums.Add(numbers[i], 0);
                }
                countNums[numbers[i]]++;
            }

            foreach (var kvp in countNums)
            {
                var number = kvp.Key;
                var count = kvp.Value;

                Console.WriteLine("{0} -> {1}", number,count);
            }
        }
    }
}
