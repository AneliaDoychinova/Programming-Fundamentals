using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstIndex = int.Parse(Console.ReadLine());
            var secondIndex = int.Parse(Console.ReadLine());
            
            for (char i = (char)firstIndex; i <= (char)secondIndex; i++)
            {
                Console.Write("{0} ",i);   
            }
            Console.WriteLine();
        }
    }
}
