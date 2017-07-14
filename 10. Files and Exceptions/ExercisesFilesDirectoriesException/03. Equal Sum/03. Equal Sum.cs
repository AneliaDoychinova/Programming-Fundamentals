using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

            var leftSum = 0;
            var rightSum = 0;
            var currentSum = 0;
            var indexEqualSum = 0;
            var isEqulSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum = currentSum;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    isEqulSum = true;
                    indexEqualSum = i;
                    break;
                }
                currentSum += numbers[i];
                rightSum = 0;

            }
            if (isEqulSum)
            {
                File.WriteAllText("output.txt", Convert.ToString(indexEqualSum));
            }
            else
            {
                File.WriteAllText("output.txt", "no");
            }
        }
    }
}
