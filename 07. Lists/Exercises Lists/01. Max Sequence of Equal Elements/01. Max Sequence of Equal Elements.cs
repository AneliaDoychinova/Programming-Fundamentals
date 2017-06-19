using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var longestSequence = new List<int>();
            var currentSequence = new List<int>();

            currentSequence.Add( numbers[0]);

            for (int i = 1; i < numbers.Count; i++)
            {
                var currentNum = numbers[i];
                var searchedNum = currentSequence[0];

                if (currentNum == searchedNum)
                {
                    currentSequence.Add(currentNum);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence = new List<int>(currentSequence);
                    }
                    currentSequence.Clear();
                    currentSequence.Add(currentNum);
                }
            }
            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = new List<int>(currentSequence);
            }
            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}
