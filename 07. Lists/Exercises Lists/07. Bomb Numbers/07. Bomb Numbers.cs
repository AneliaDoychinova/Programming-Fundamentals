using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var specialNum = bombNums[0];
            var power = bombNums[1];
           
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == specialNum)
                    {
                        var leftIndex = Math.Max(i - power,0);
                        var rightIndex = Math.Min(i + power, numbers.Count -1);
                        var removeCount = rightIndex - leftIndex + 1;

                        numbers.RemoveRange(leftIndex, removeCount);
                        i = -1;
                    }
                }
            
            var sum = numbers.Sum();

            Console.WriteLine(sum);

        }
    }
}
