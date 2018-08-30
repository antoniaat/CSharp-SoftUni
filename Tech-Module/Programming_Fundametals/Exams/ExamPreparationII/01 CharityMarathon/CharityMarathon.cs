namespace _01_CharityMarathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            var maratonLenght = decimal.Parse(Console.ReadLine());
            var numberOfRunners = decimal.Parse(Console.ReadLine());
            var averageNumberOfLaps = decimal.Parse(Console.ReadLine());
            var lenghtOfTheTrack = decimal.Parse(Console.ReadLine());
            var capacityOfTheTrack = decimal.Parse(Console.ReadLine());
            var donatedMoney = decimal.Parse(Console.ReadLine());

            var totalRunners = capacityOfTheTrack * maratonLenght;
            decimal totalMeters;

            if (totalRunners >= numberOfRunners)
            {
                totalMeters = (numberOfRunners * averageNumberOfLaps * lenghtOfTheTrack) / 1000;
            }
            else
            {
                totalMeters = (totalRunners * averageNumberOfLaps * lenghtOfTheTrack) / 1000;
            }

            var raisedMoney = totalMeters * donatedMoney;

            Console.WriteLine($"Money raised: {raisedMoney:f2}");
        }
    }
}