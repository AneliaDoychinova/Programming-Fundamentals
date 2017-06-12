using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            var counts = new Dictionary<int,int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!counts.ContainsKey(numbers[i]))
                {
                    counts.Add(numbers[i],0); 
                }
                counts[numbers[i]]++;
            }

            var mostFrequentNum = counts.OrderByDescending(kv => kv.Value).First().Key;

            Console.WriteLine(mostFrequentNum);
            
        }
    }
}
