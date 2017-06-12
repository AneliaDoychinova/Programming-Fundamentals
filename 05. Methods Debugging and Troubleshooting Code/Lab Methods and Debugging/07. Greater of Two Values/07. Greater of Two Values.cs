using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                var firstNum = int.Parse(Console.ReadLine());
                var secondNum = int.Parse(Console.ReadLine());

                var greaterValue = GetGreaterValue(firstNum, secondNum);
                Console.WriteLine(greaterValue);
            }
            else if (type == "char")
            {
                var firstCh = char.Parse(Console.ReadLine());
                var secondCh = char.Parse(Console.ReadLine());

                var greaterValue = GetGreaterValue(firstCh, secondCh);
                Console.WriteLine((char)greaterValue);

            }
            else
            {
                var firstString = Console.ReadLine();
                var secondString = Console.ReadLine();


                var greaterValue = GetGreaterValue(firstString, secondString);
                Console.WriteLine(greaterValue);

            }
        }

        static string GetGreaterValue(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) == 1)
            {
                return firstString;
            }
            return secondString;
        }

        static int GetGreaterValue(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            return secondNum;
        }
    }
}
