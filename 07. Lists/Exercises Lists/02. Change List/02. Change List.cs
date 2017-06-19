using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var commands = Console.ReadLine().Split(' ');

            while (true)
            {
                if (commands[0] == "Odd" || commands[0] == "Even")
                {
                    break;
                }
                var element = int.Parse(commands[1]);

                if (commands[0] == "Delete")
                { 
                    numbers.RemoveAll(x => x == element);
                }
                else if (commands[0] == "Insert")
                {
                    var position = int.Parse(commands[2]);
                    numbers.Insert(position, element);
                }
                commands = Console.ReadLine().Split(' ');
                
            }
            foreach (var num in numbers)
            {
                if (commands[0] == "Even")
                {
                    if (num % 2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                }
                else
                {
                    if (num % 2 == 1)
                    {
                        Console.Write(num + " ");
                    }
                }
                
            }
            Console.WriteLine();
        }
    }
}
