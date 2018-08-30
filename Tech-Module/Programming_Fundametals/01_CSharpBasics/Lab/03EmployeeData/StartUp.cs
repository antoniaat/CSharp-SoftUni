using System;

namespace _03EmployeeData
{
    public class StartUp
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var employeeId = int.Parse(Console.ReadLine());
            var salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeId:D8}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}