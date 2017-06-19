using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToList();

            var sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                var reversedNum = ReverseNum(numbers[i]);
                sum += reversedNum;
            }
            Console.WriteLine(sum);
        }

        static int ReverseNum(string number)
        {
            var charArray = number.ToCharArray();
            Array.Reverse(charArray);
           var reversedNumToInt = Int32.Parse(new string(charArray));
           return reversedNumToInt;
        }
    }
}
