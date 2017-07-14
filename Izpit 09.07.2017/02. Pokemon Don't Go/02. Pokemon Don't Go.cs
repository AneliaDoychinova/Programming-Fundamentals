using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sum = 0l;
            while (nums.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());
                var removedElement = 0;

                if (index < 0)
                {
                    removedElement = nums[0];
                    nums[0] = nums[nums.Count - 1];
                }
                else if (index > nums.Count - 1)
                {
                    removedElement = nums[nums.Count - 1];
                    nums[nums.Count - 1] = nums[0];
                }
                else
                {
                    removedElement = nums[index];
                    nums.RemoveAt(index);
                }
                sum += removedElement;
                if (nums.Count == 0)
                {
                    break;
                }
                for (int i = 0; i < nums.Count;i++ )
                {
                    if (nums[i] <= removedElement)
                    {
                        nums[i] +=removedElement;
                    }
                    else
                    {
                        nums[i] -=removedElement;
                    }
                }
               
            }

            Console.WriteLine(sum);
        }
    }
}
