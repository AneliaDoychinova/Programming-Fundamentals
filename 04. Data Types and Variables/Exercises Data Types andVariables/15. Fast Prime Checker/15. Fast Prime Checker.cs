using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int numberToCheck = 2; numberToCheck <= number; numberToCheck++)
            {    bool isPrime = true;
            for (int divisor = 2; divisor <= Math.Sqrt(numberToCheck); divisor++)
                      {
                          if (numberToCheck % divisor == 0)
                            {
                                isPrime = false;
                                break;
                            }
                      }
            Console.WriteLine("{0} -> {1}", numberToCheck, isPrime);
            }   

        }
    }
}
