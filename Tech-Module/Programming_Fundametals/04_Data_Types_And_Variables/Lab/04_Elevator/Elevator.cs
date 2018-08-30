using System;

namespace _04.Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            var nPersons = int.Parse(Console.ReadLine());
            var capacityOfPersons = int.Parse(Console.ReadLine());
            var courses = (int)Math.Ceiling((double)nPersons / capacityOfPersons);
            Console.WriteLine(courses);
        }
    }
}