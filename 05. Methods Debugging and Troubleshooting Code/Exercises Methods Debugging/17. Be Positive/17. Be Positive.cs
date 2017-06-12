using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Be_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            var countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                var input = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                        
                    int num = int.Parse(input[j]);
                    numbers.Add(num);
                }

                bool found = false;

                for (int k = 0; k < numbers.Count; k++)
                {
                    int currentNum = numbers[k];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else if(k+1 < numbers.Count)
                    {
                        currentNum += numbers[k + 1];

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                        k++;
                    }
                }
                
                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
