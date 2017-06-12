using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Sequence_of_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

		int[] array = Console.ReadLine()
			.Split()
			.Select(int.Parse)
			.ToArray();

		var input = Console.ReadLine().Split();

		while (input[0] != "stop")
		{
			int[] numbers = new int[2];

			if (input[0] == "add" ||
				input[0] == "subtract" ||
				input[0] == "multiply")
			{
				numbers[0] = int.Parse(input[1]);
				numbers[1] = int.Parse(input[2]);

			}

			array = PerformAction(array, input, numbers);
            
            PrintArray(array);
            
			input = Console.ReadLine().Split();
		}
	}

	static int[] PerformAction(int[] arr, string[] action, int[] numbers)
	{
		int pos = numbers[0] - 1;
		int value = numbers[1];

		switch (action[0])
		{
			case "multiply":
				arr[pos] *= value;
                return arr;
			case "add":
				arr[pos] += value;
                return arr;
			case "subtract":
				arr[pos] -= value;
                return arr;
			case "lshift":
				var leftShiftArray = ArrayShiftLeft(arr);
                return leftShiftArray;
			case "rshift":
				var rightShiftArray = ArrayShiftRight(arr);
                return rightShiftArray;
		}
        return arr;
	}

	static int[] ArrayShiftRight(int[] array)
	{
        var rightShiftArray = new int[array.Length];

		for (int i = array.Length - 1; i >= 0; i--)
		{
            if (i == 0)
            {
               rightShiftArray[i] = array[array.Length-1];
               return rightShiftArray;
            }
			rightShiftArray[i] = array[i - 1];
		}
        return rightShiftArray;
	}

	static int[] ArrayShiftLeft(int[] array)
	{
        var leftShiftArray = new int[array.Length];

		for (int i = 0; i <= array.Length - 1; i++)
		{
            if (i == array.Length - 1)
            {
                leftShiftArray[array.Length - 1] = array[0];
                return leftShiftArray;
            }
			leftShiftArray[i] = array[i + 1];
		}
        return leftShiftArray;
	}

	static void PrintArray(int[] array)
	{
        Console.WriteLine(string.Join(" ", array));
	}
        }
    }
