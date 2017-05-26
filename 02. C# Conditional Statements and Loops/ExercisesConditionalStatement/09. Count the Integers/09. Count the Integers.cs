using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {   
            var count = 0;
            try
            {
                var input = int.Parse(Console.ReadLine());
                
                while (true)
                {
                    count++;
                    input = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                Console.WriteLine(count);
            }
            
            
            
        }
    }
}
