using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                var command = input[0];
                var name = input[1];

                if (command == "A")
                {
                    var phoneNumber = input[2];
                    phonebook[name] = phoneNumber;
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}",name, phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}
