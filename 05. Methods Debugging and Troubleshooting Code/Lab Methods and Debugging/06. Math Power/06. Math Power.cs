﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var result = NumberRaiseToPower(number, power);

            Console.WriteLine(result);
        }

        static double NumberRaiseToPower(double number, int power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
