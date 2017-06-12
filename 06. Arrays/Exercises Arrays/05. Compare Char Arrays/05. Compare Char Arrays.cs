using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var chars2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            var isEqual = true;

            for (int i = 0; i < Math.Min(chars1.Length, chars2.Length); i++)
            {
                if (chars1[i] == chars2[i])
                {
                    continue;
                }
                else
                {
                    isEqual = false;
                    if (chars1[i] > chars2[i])
                    {
                        PrintArray(chars2,chars1);                      
                        break;
                    }
                    else
                    {
                        PrintArray(chars1, chars2);   
                        break;
                    }
                    
                }
            }
            if (isEqual && chars1.Length - chars2.Length <= 0)
            {
                PrintArray(chars1, chars2);  
            }
            else if (isEqual && chars1.Length - chars2.Length > 0)
            {
                PrintArray(chars2, chars1);
            }
        }

        static void PrintArray(char[] first, char[] second)
        {
            Console.WriteLine(string.Join("", first));
            Console.WriteLine(string.Join("", second));
        }
    }
}
