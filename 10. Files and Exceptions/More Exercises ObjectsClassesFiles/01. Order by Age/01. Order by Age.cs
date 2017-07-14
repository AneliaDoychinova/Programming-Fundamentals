using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var listOfPersons = new List<Person>();

            while (input[0] != "End")
            {
                var person = new Person 
                {
                    Name = input[0],
                    Id = input[1],
                    Age = int.Parse(input[2])
                };

                listOfPersons.Add(person);
                input = Console.ReadLine().Split(' ');
            }

            listOfPersons = listOfPersons.OrderBy(a => a.Age).ToList();

            foreach (var person in listOfPersons)
            {
                Console.WriteLine("{0} with ID: {1} is {2} years old.", person.Name, person.Id,person.Age);
            }
        }

        class Person
        {
            public string Name { get; set; }

            public string Id { get; set; }

            public int Age { get; set; }
        }
    }
}
