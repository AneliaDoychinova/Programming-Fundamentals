using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _08.Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = File.ReadAllLines("input.txt");
            var students = new List<Student>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                var input = inputArray[i].Split(' ');
                var name = input.First();
                var grades = input.Skip(1).Select(double.Parse).ToList();

                var student = new Student 
                {
                    Name = name,
                    Grades = grades 
                };

                students.Add(student);
            }

            var excelentStudents = students.Where(a => a.Average >= 5).
                OrderBy(a => a.Name).ThenByDescending(a => a.Average).ToArray();

            foreach (var student in excelentStudents)
            {
                File.AppendAllText("output.txt", student.Name + " -> " + student.Average + Environment.NewLine);
            }
        }

        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }

            public double Average { get { return Grades.Average(); } }
        }
    }
}
