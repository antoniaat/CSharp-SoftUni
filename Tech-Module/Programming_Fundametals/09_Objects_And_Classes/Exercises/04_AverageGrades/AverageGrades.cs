namespace _04.AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            Student[] students = ReadStudents();

            foreach (var student in students.OrderBy(n => n.Name).ThenByDescending(x => x.AverageGrade))
            {
                if (student.AverageGrade >= 5.00)
                {
                    Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
                }
            }
        }

        private static Student[] ReadStudents()
        {
            int n = int.Parse(Console.ReadLine());

            var students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                students[i] = ReadStudent();
            }

            return students;
        }

        private static Student ReadStudent()
        {
            var currentStudent = Console.ReadLine().Split();
            var grades = new List<double>();

            for (var i = 1; i < currentStudent.Length; i++)
            {
                grades.Add(double.Parse(currentStudent[i]));
            }

            var averageGrade = grades.Sum() / grades.Count;

            return new Student()
            {
                Name = currentStudent[0],
                Grades = grades,
                AverageGrade = averageGrade
            };
        }
    }
}