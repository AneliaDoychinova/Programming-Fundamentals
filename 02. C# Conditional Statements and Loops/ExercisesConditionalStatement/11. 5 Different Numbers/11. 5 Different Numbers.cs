using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var isThereNumbers = false;

            for (int i = a; i <= b; i++)
            {
                for (int j = i + 1; j <= b; j++)
                {
                    for (int k = j+1; k <= b; k++)
                    {
                        for (int l = k+1; l <= b; l++)
                        {
                            for (int m = l+1; m <= b; m++)
                            {
                                Console.Write("{0} {1} {2} {3} {4}", i, j ,k,l,m);
                                Console.WriteLine();
                                isThereNumbers = true;
                            }
                            
                        }
                    }
                }
                
            }
            if (!isThereNumbers)
            {
                Console.WriteLine("No");
            }

        }
    }
}
