using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var currentNum = 0;
            var lenght = 1;
            var maxLenght = 1;
            var maxLongNum = 0;
   
            for (int i = 1; i <= numbers.Length - 1; i++)
            {

                if (numbers[i] == numbers[i-1])
                {
                    lenght++;
                    
                    if (maxLenght < lenght)
                    {
                         maxLenght = lenght;
                    maxLongNum = numbers[i];
                    }
                   
                }
                else
                {
                    currentNum = numbers[i];
                    lenght = 1;
                }

            }
            var maxLenghtNum = new int[maxLenght];

            for (int i = 0; i < maxLenghtNum.Length; i++)
            {
                maxLenghtNum[i] = maxLongNum;
            }

            Console.WriteLine(string.Join(" ", maxLenghtNum));
        }
    }
}
