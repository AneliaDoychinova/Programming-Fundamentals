using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalNum = int.Parse(Console.ReadLine());

            var hexadecimal = Convert.ToString(decimalNum, 16).ToUpper();
            var binary = Convert.ToString(decimalNum, 2);

            Console.WriteLine(hexadecimal);
            Console.WriteLine(binary);

        }
    }
}
