using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.Play_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var exceptionsCount = 0;

            while (exceptionsCount < 3)
            {
                var index = 0;
               
                var input = Console.ReadLine().Split(' ');
                var command = input[0];
                
                try
                {
                    index = int.Parse(input[1]);
                }
                catch (Exception)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionsCount++;
                    continue;
                }

                if (command == "Replace")
                {
                    try
                    {
                       var numToPut = int.Parse(input[2]);
                        numbers.Insert(index, numToPut);
                        numbers.RemoveAt(index + 1);
                    }
                    catch (Exception)
                    {
                        
                        Console.WriteLine("The index does not exist!");
                        exceptionsCount++;
                    }
                }
                else if (command == "Show")
                {
                    try
                    {
                        Console.WriteLine(numbers[index]);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("The index does not exist!");
                        exceptionsCount++;
                    }
                }
                else if (command == "Print")
                {
                    var startIndex = index;
                    var endIndex = int.Parse(input[2]);
                    var isException = false;
                    var listToPrint = new List<int>();

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        try
                        {
                            listToPrint.Add(numbers[i]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("The index does not exist!");
                            exceptionsCount++;
                            isException = true;
                            break;
                        }
                    }
                    if (!isException)
                    {
                        Console.WriteLine(string.Join(", ", listToPrint));
                    }
                    
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
