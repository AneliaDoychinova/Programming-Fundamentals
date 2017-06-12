using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _16.Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();

            while (input[0] != "END")
            {
                long result = 0;
                switch (input[0])
                {
                    case "INC":
                        {
                            var operandOne = long.Parse(input[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            var operandOne = long.Parse(input[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            var operandOne = long.Parse(input[1]);
                            var operandTwo = long.Parse(input[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            var operandOne = long.Parse(input[1]);
                            var operandTwo = long.Parse(input[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                }

                Console.WriteLine(result);
                input = Console.ReadLine().Split();
            }
        }
    }
}
