using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            var primes = FindPrimesInRange(startNum, endNum);
            PrintPrimesInGivenRange(primes);
        }

        static void PrintPrimesInGivenRange(List<int> primes)
        {
            Console.WriteLine(string.Join(", ", primes));
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var resultList = new List<int>();
            var isPrime = true;

            if (startNum == 0 || startNum == 1)
            {
                startNum = 2;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                for (int divisor = 2; divisor <= Math.Sqrt(i); divisor++)
                {
                    if (i%divisor == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    resultList.Add(i);
                }
                isPrime = true;
            }
            return resultList;
        }
    }
}
