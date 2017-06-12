using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');
            var resultList = new List<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                var token = input[i].Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);

                foreach (var number in token)
                {
                    resultList.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
