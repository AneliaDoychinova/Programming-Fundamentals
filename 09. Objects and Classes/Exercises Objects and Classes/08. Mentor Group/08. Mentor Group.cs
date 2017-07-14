using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.Mentor_Group
{
    class Program
    {
        static void Main(string[] args)
        {

            var namesAndDates = ReadNamesAndDates();
            var comments = ReadComments(namesAndDates.Keys.ToList());
            var allStudents = GetStudents(namesAndDates, comments);
            PrintStudents(allStudents);

           

        }

        private static void PrintStudents(List<Student> allStudents)
        {
            foreach (var students in allStudents)
            {
                students.Dates.Sort();

                Console.WriteLine(students.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in students.Comments)
                {
                    Console.WriteLine("- {0}",comment);
                }
                
                Console.WriteLine("Dates attended:");

                foreach (var date in students.Dates)
                {
                    Console.WriteLine("-- {0}", date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

            }
        }

        private static List<Student> GetStudents(SortedDictionary<string, List<DateTime>> namesAndDates, SortedDictionary<string, List<string>> comments)
        {
            var studentsList = new List<Student>();
            foreach (var student in namesAndDates)
            {
                var name = student.Key;
                var dates = student.Value;
                var studentComments = new List<string>();
                if (comments.ContainsKey(name))
                {
                    studentComments = comments[name];
                }
                var currentStudent = new Student
                {
                    Name = name,
                    Dates = dates,
                    Comments = studentComments
                };
                studentsList.Add(currentStudent);
            }
            return studentsList;
        }

        private static SortedDictionary<string,List <string>> ReadComments(List<string> names)
        {
            var tokens = Console.ReadLine().Split('-');
            var namesAndComments = new SortedDictionary<string,List <string>>();

            while (tokens[0] != "end of comments")
            {
                var name = tokens[0];
                var comment = tokens[1];

                if (!names.Contains(name))
                {
                    tokens = Console.ReadLine().Split('-');
                    continue;
                }
                if (!namesAndComments.ContainsKey(name))
                {
                    namesAndComments[name] = new List<string>();
                }
                namesAndComments[name].Add(comment);
                tokens = Console.ReadLine().Split('-');
            }
            return namesAndComments;
        }

        private static SortedDictionary<string, List<DateTime>> ReadNamesAndDates()
        {
           var studentsDict = new SortedDictionary<string, List<DateTime>>();

           var tokens = Console.ReadLine().Split(' ', ',');

            while (tokens[0] != "end")
            {
                var name = tokens[0];

                if (tokens.Length == 1)
                {
                    studentsDict[name] = new List<DateTime>();
                    tokens = Console.ReadLine().Split(' ', ',');
                    continue;
                }
                var dates = tokens.Skip(1)
                    .Select(d => DateTime.ParseExact(d, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    .ToList();

                if (!studentsDict.ContainsKey(name))
                {
                    studentsDict[name] = new List<DateTime>();
                }
                studentsDict[name].AddRange(dates);

                tokens = Console.ReadLine().Split(' ', ',');
            }

            return studentsDict;
        }

        class Student
        {
            public string Name { get; set; }

            public List<string> Comments { get; set; }

            public List<DateTime> Dates { get; set; }
        }
    }
}
