using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (numbers.Length != 1)
            {
                var newArray = new int[numbers.Length - 1];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = numbers[i] + numbers[i + 1];

                }
                numbers = newArray;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
