using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Max_Sequence_Of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

            var currentNum = 0;
            var lenght = 1;
            var maxLenght = 1;
            var maxLongNum = 0;

            for (int i = 1; i <= numbers.Length - 1; i++)
            {

                if (numbers[i] == numbers[i - 1])
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
            for (int i = 0; i < maxLenght; i++)
            {
                File.AppendAllText("output.txt", Convert.ToString(maxLongNum) + " ");
            }
            
        }
    }
}
