using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var nonNumbers = input.Where(a => !Char.IsDigit(a)).Select(a => a).ToList();
            var numbers = input.Where(a => Char.IsDigit(a)).Select(a => int.Parse(a.ToString())).ToList();
            var takeList = new List<int>();
            var skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            var resultString = string.Empty;
            var skipNum = skipList[0];

            for (int i = 0; i < takeList.Count; i++)
            {
                var tempArr = new List<char>();
                

                if (i == 0)
	            {
		             tempArr = nonNumbers.Take(takeList[i]).ToList();
                     skipNum += takeList[i];
	            }
                else
                {
                    
                    tempArr = nonNumbers.Skip(skipNum).Take(takeList[i]).ToList();
                    skipNum += skipList[i] + takeList[i];
                }

                resultString += string.Join("", tempArr);
                
            }
            Console.WriteLine(resultString);
            
        }
    }
}
