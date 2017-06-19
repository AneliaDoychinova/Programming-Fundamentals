using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                var command = input[0];

                if (command == "A")
                {
                    var name = input[1];
                    var phoneNumber = input[2];
                    phonebook[name] = phoneNumber;
                }
                else if (command == "S")
                {
                    var name = input[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var kvp in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
                    }
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}