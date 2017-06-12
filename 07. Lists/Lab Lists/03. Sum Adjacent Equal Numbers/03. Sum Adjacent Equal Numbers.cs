using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersToCheck = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 1; i < numbersToCheck.Count; i++)
            {
                if (numbersToCheck[i-1] == numbersToCheck[i])
                {
                    var sumNumber = numbersToCheck[i - 1] + numbersToCheck[i];
                    numbersToCheck.Insert(i-1, sumNumber);
                    numbersToCheck.RemoveAt(i);
                    numbersToCheck.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbersToCheck));
        }
    }
}
