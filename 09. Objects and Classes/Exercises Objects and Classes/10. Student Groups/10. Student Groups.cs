using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _10.Student_Groups
{
    class Program
    {
        static void Main(string[] args)
        {
           var townsList = ReadInput();
           var numOfTowns = townsList.Count;
           var groups = DistributeStudentsIntoGroups(townsList);
           PrintOutput(groups, numOfTowns);
        }

        private static void PrintOutput(List<Group> groups, int num)
        {
            var numOfGroups = groups.Count;
            var numOfTowns = num;

            Console.WriteLine("Created {0} groups in {1} towns:", numOfGroups, numOfTowns);
             
            foreach (var group in groups.OrderBy(x => x.Town.Name))
            {
                Console.WriteLine("{0} => {1}",
                    group.Town.Name, string.Join(", ", group.Students.Select(x => x.Email).ToList()));

            }
        }

        private static List<Group> DistributeStudentsIntoGroups(List<Town> townsList)
        {
            var groups = new List<Group>();
            foreach (var town in townsList.OrderBy(x => x.Name))
            {
                var students = town.Students
                    .OrderBy(d => d.RegistrationDate)
                    .ThenBy(n => n.Name)
                    .ThenBy(e => e.Email)
                    .ToList();

                while (students.Any())
                {
                    var group = new Group
                    {
                        Town = town,
                        Students = students.Take(town.Seats).ToList()
                    };

                    students = students.Skip(town.Seats).ToList();
                    groups.Add(group);
                }
            }
                return groups;
            
        }

        private static List<Town> ReadInput()
        {
            var input = Console.ReadLine();
            var townList = new List<Town>();
            var indexOfLastTown = 0;
            while (input != "End")
            {
               
                if (input.Contains("=>"))
                {

                    var tokens = input.Split(new char[] { '>', '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var townName = string.Empty;
                    var seats = 0;

                    if (tokens.Length == 3)
                    {
                        townName = tokens[0];
                        seats = int.Parse(tokens[1]);
                    }
                    else
                    {
                        townName = tokens[0] + " " + tokens[1];
                        seats = int.Parse(tokens[2]);
                    }

                    var town = new Town
                    {
                        Name = townName,
                        Seats = seats,
                        Students = new List<Student>()
                    };


                    townList.Add(town);
                    indexOfLastTown = townList.IndexOf(town);
                }

                else
                {
                    var inputSplit = input.Split(new char[] {'|', ' '},StringSplitOptions.RemoveEmptyEntries);
                    var student = new Student
                    {
                        Name = inputSplit[0] + " " + inputSplit[1],
                        Email = inputSplit[2],
                        RegistrationDate = DateTime.ParseExact(inputSplit[3], "d-MMM-yyyy", CultureInfo.InvariantCulture)
                    };

                    townList[indexOfLastTown].Students.Add(student);
                }
                input = Console.ReadLine();
            }
            return townList;
        }

        class Student
        {
            public string Name { get; set; }

            public string Email { get; set; }

            public DateTime RegistrationDate { get; set; }
        }

        class Town
        {
            public string Name  {get; set; }

            public int Seats { get; set; }

            public List<Student> Students { get; set; }
        }

        class Group
        {
            public Town Town { get; set; }

            public List<Student> Students { get; set; }
        }
    }
}
