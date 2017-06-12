using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var isThereTripleSum = false;
            for (int a = 0; a < numbersArray.Length; a++)
            {
                for (int b = a+1; b < numbersArray.Length; b++)
                {
                    var sum = numbersArray[a] + numbersArray[b];

                    if (numbersArray.Contains(sum))
                    {
                         isThereTripleSum = true;
                            Console.WriteLine("{0} + {1} == {2}",numbersArray[a],numbersArray[b],sum);
                    }
                }
            }
            if (!isThereTripleSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
