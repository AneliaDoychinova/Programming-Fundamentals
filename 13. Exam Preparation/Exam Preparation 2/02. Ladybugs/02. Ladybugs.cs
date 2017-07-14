using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var indexesOfLadybugs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(a => a >= 0 && a < fieldSize)
                .ToArray();

            var listOfLadyBugs = new int[fieldSize];

            foreach (var index in indexesOfLadybugs)
            {
                listOfLadyBugs[index] = 1;
            }

            var command = Console.ReadLine().Split(' ');

            while (command[0] != "end")
            {
                var currentIndex = int.Parse(command[0]);
                var direction = command[1];
                var flyLenght = int.Parse(command[2]);

                var isIndexExists = currentIndex >= 0 && currentIndex < listOfLadyBugs.Length;


                if (!isIndexExists || listOfLadyBugs[currentIndex] == 0)
                {
                    command = Console.ReadLine().Split(' ');
                    continue;
                }

                if (direction == "left")
                {
                    flyLenght = -flyLenght;
                }


                var wantedIndex = currentIndex + flyLenght;
                listOfLadyBugs[currentIndex] = 0;

                while (true)
                {
                    if (wantedIndex < 0 || wantedIndex > listOfLadyBugs.Length - 1)
                    {
                        break;
                    }

                    if (listOfLadyBugs[wantedIndex] == 1)
                    {
                        wantedIndex += flyLenght;
                        continue;
                    }
                    else
                    {
                        listOfLadyBugs[wantedIndex] = 1;
                        break;
                    }
                }
                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(" ", listOfLadyBugs));
        }
    }
}
