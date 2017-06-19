using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var tokens = Console.ReadLine().Split(' ');

            while (tokens[0] != "print")
            {
                var command = tokens[0];

                if (command == "add")
                {
                    AddNumber(tokens, numbers);

                }
                else if (command == "addMany")
                {
                    AddMany(tokens, numbers);
                }
                else if (command == "contains")
                {
                    PrintTheIndexOfElelement(tokens, numbers);
                }
                else if (command == "remove")
                {
                    RemoveIndex(tokens, numbers);
                }
                else if (command == "shift")
                {
                    ShiftElements(tokens, numbers);
                }
                else if (command == "sumPairs")
                {
                    SumPairs(tokens, numbers);
                }
                tokens = Console.ReadLine().Split(' ');
            }
            Console.WriteLine("[{0}]",string.Join(", ",numbers));
        }

        static void SumPairs(string[] tokens, List<int> numbers)
        {
            var endIndex = numbers.Count / 2;
            for (int i = 0; i < endIndex; i++)
            {
                var currentElement = numbers[i] + numbers[i + 1];
                numbers.Insert(i, currentElement);
                numbers.RemoveAt(i + 1);
                numbers.RemoveAt(i + 1);
            }
        }

        static void ShiftElements(string[] tokens, List<int> numbers)
        {
            var positions = int.Parse(tokens[1]);

            for (int i = 0; i < positions; i++)
            {
                var firstElement = numbers[0];
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    var nextElement = numbers[j + 1];
                     
                    numbers[j] = nextElement;
                }
                numbers[numbers.Count - 1] = firstElement;
            }
        }

        static void RemoveIndex(string[] tokens, List<int> numbers)
        {
            var index = int.Parse(tokens[1]);
            numbers.RemoveAt(index);
        }

        static void PrintTheIndexOfElelement(string[] tokens, List<int> numbers)
        {
            var element = int.Parse(tokens[1]);
            if (numbers.Contains(element))
            {
                var index = numbers.FindIndex(x => x == element);
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        static void AddMany(string[] tokens, List<int> numbers)
        {
            var index = int.Parse(tokens[1]);
            for (int i = 2; i < tokens.Length; i++)
            {
                var element = int.Parse(tokens[i]);
                numbers.Insert(index, element);
                index++;
            }
        }

        static void AddNumber(string[] tokens, List<int> numbers )
        {
            var index = int.Parse(tokens[1]);
            var element = int.Parse(tokens[2]);
            numbers.Insert(index, element);
        }
    }
}
