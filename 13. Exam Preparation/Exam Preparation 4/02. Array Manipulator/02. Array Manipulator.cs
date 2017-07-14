using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split();
                var command = tokens[0];

                switch (command)
                {
                    case "exchange":
                        arr = ExchangeArray(arr, tokens);
                        break;
                    case "max":
                        PrintIndexofMaxElement(arr, tokens);
                        break;
                    case "min":
                        PrintIndexofMinElement(arr, tokens);
                        break;
                    case "first":
                        PrintFirstElements(arr, tokens);
                        break;
                    case "last":
                        PrintLastElements(arr, tokens);
                        break;

                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

        private static void PrintLastElements(int[] arr, string[] tokens)
        {
            var count = int.Parse(tokens[1]);
            var type = tokens[2];

            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var resultList = new List<int>();
            var cnt = 0;
            var parity = type == "even" ? 0 : 1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] % 2 == parity)
                {
                    cnt++;
                    resultList.Add(arr[i]);
                }
                if (cnt == count)
                {
                    break;
                }
            }
            resultList.Reverse();
            Console.WriteLine("[{0}]", string.Join(", ", resultList));
        }

        private static void PrintFirstElements(int[] arr, string[] tokens)
        {
            var count = int.Parse(tokens[1]);
            var type = tokens[2];

            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var resultList = new List<int>();
            var cnt = 0;
            var parity = type == "even" ? 0 : 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == parity)
                {
                    cnt++;
                    resultList.Add(arr[i]);
                }
                if (cnt == count)
                {
                    break;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", resultList));
        }

        private static void PrintIndexofMinElement(int[] arr, string[] tokens)
        {
            var type = tokens[1];
            var minElement = int.MaxValue;
            var isElement = false;
            var index = 0;
            var parity = type == "even" ? 0 : 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == parity && arr[i] <= minElement)
                {
                    isElement = true;
                    minElement = arr[i];
                    index = i;
                }
            }

            if (isElement)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void PrintIndexofMaxElement(int[] arr, string[] tokens)
        {
            var type = tokens[1];
            var maxElement = int.MinValue;
            var isElement = false;
            var index = 0;
            var parity = type == "even" ? 0 : 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == parity && arr[i] >= maxElement)
                {
                    isElement = true;
                    maxElement = arr[i];
                    index = i;
                }
            }
            if (isElement)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static int[] ExchangeArray(int[] arr, string[] tokens)
        {
            var index = int.Parse(tokens[1]);

            if (index > arr.Length - 1 || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            var leftPart = arr.Skip(index + 1).ToArray();
            var rightPart = arr.Take(index + 1).ToArray();
            var length = arr.Length;
            arr = new int[length];
            arr = leftPart.Concat(rightPart).ToArray();
            return arr;
        }
    }
}
