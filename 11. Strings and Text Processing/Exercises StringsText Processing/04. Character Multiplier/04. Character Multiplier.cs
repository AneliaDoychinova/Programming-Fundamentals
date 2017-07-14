using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var firstString = input[0];
            var secondString = input[1];

            var totalSum = 0;
            var longerString = string.Empty;
            var shortString = string.Empty;

            if (firstString.Length > secondString.Length)
	        {
		        longerString = firstString;
                shortString = secondString;
	        }
            else if(secondString.Length > firstString.Length)
	        {
                longerString = secondString;
                shortString = firstString;
	        }
            else
	        {
                 longerString = firstString;
	        }
            if (shortString == string.Empty)
            {
                for (int i = 0; i < secondString.Length; i++)
                {
                    totalSum += firstString[i] * secondString[i];
                }
            }
            else
            {
                for (int i = 0; i < longerString.Length; i++)
                {
                    if (i < shortString.Length)
                    {
                        totalSum += shortString[i] * longerString[i];
                    }
                    else
                    {
                        totalSum += longerString[i];
                    }
                }
            }

            Console.WriteLine(totalSum);

        }
    }
}
