using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(' ');
                var command = tokens[0];
                switch (command)
                {
                    case "reverse":
                        arr = ReverseAray(arr, tokens);
                        break;
                    case "sort":
                        arr = SortArray(arr, tokens);
                        break;
                    case "rollLeft":
                        arr = RollLeft(arr, tokens);
                        break;
                    case "rollRight":
                        arr = RollRight(arr, tokens);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("[{0}]",string.Join(", ",arr));
        }

        private static List<string> RollRight(List<string> arr, string[] tokens)
        {
            var count = int.Parse(tokens[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");

            }
            else
            {
                var result = new string[arr.Count];

                for (int oldIndex = 0; oldIndex < arr.Count; oldIndex++)
                {
                    var newIndex = oldIndex + count;
                    newIndex = newIndex % arr.Count;

                    result[newIndex] = arr[oldIndex];
                }

                for (int i = 0; i < result.Length; i++)
                {
                    arr[i] = result[i];
                }
            }
            return arr;
        }

        private static List<string> RollLeft(List<string> arr, string[] tokens)
        {
            var count = int.Parse(tokens[1]);
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                var result = new string[arr.Count];

                for (int oldIndex = 0; oldIndex < arr.Count; oldIndex++)
                {
                    var newIndex = oldIndex - count;
                    newIndex = newIndex % arr.Count;
                    if (newIndex < 0)
                    {
                        newIndex = newIndex + arr.Count;
                    }
                    result[newIndex] = arr[oldIndex];
                }

                for (int i = 0; i < result.Length; i++)
                {
                    arr[i] = result[i];
                }
            }
            return arr;
        }

        private static List<string> SortArray(List<string> arr, string[] tokens)
        {
            var start = int.Parse(tokens[2]);
            var count = int.Parse(tokens[4]);
            
            if (count < 0 || start < 0 || start > arr.Count - 1 
                || start + count-1 > arr.Count-1)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                arr.Sort(start, count, StringComparer.InvariantCulture);
              
            }
            return arr;
        }

        static List<string> ReverseAray(List<string> arr, string[] tokens)
        {
            var start = int.Parse(tokens[2]);
            var count = int.Parse(tokens[4]);

            if (count < 0 || start < 0 || start > arr.Count - 1
                || start + count - 1 > arr.Count - 1)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                var end = start + count - 1;
                while (start < end)
                {
                    var oldItem = arr[start];
                    arr[start] = arr[end];
                    arr[end] = oldItem;

                    start++;
                    end--;
                }
            }
            return arr;
        }
    }
}
