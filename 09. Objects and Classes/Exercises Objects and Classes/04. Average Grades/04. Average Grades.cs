using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }

            public double Average { get{return Grades.Average();}}
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input.First();
                var grades = input.Skip(1).Select(double.Parse).ToList();

                var student = new Student 
                {
                    Name = name,
                    Grades = grades
                };

                students.Add(student);
            }

            var excellentStudents = students.Where(a => a.Average >= 5.00).OrderBy(a => a.Name).
                ThenByDescending(a => a.Average).ToArray();

            foreach (var student in excellentStudents)
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name , student.Average);
            }
        }
    }
}
