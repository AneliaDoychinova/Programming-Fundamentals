using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var numsToTake = arr[0];
            var numsToDelete = arr[1];
            var numToSearchFor = arr[2];
            var newList = new List<int>();
            var isNumFound = false;

            for (int i = 0; i < numsToTake; i++)
            {
                newList.Add(numbers[i]);
            }
            for (int i = 0; i < numsToDelete; i++)
            {
                newList.RemoveAt(0);
            }
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] == numToSearchFor)
                {
                    Console.WriteLine("YES!");
                    isNumFound = true;
                    break;
                } 
            }
            if (!isNumFound)
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
