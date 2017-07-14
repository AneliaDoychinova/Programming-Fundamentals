using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_base_10_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();
            var baseToConvert = readNumbers[0];
            var numToConvert = readNumbers[1];

            var number = new List<int>();

            while (numToConvert != 0)
            {
                int num = (int)(numToConvert % baseToConvert);
                numToConvert = numToConvert / baseToConvert;
                number.Add(num);
            }

            number.Reverse();

            Console.WriteLine(string.Join("",number));

        }
    }
}
