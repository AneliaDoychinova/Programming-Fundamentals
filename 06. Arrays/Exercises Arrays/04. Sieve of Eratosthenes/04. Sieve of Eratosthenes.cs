using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var bools = new bool[n + 1];
            bools[0] = bools[1] = false;
            var isPrime = true;
            var primesCount = 0;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primesCount++;
                    bools[i] = true;
                }
                isPrime = true;
            }
            var primes = new int[primesCount];
            var count = 0;

            for (int i = 0; i < bools.Length; i++)
            {
                if (bools[i] == true)
                {
                    primes[count] = i;
                    count++;
                }

            }
            Console.WriteLine(string.Join(" ", primes));
        }
    }
}
