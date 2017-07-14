using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

            var counts = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!counts.ContainsKey(nums[i]))
                {
                    counts.Add(nums[i], 0);
                }
                counts[nums[i]]++;
            }

            var mostFrequent = counts.OrderByDescending(n => n.Value).First().Key;

            File.WriteAllText("output.txt", Convert.ToString(mostFrequent));
        }
    }
}
