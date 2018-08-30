namespace _01_Snowballs
{
    using System;
    using System.Numerics;

    public class Snowballs
    {
        public static void Main()
        {
            var n = BigInteger.Parse(Console.ReadLine());
            BigInteger highestValue = 0;
            BigInteger firstSnowballSnow = 0;
            BigInteger firstSnowballTime = 0;
            BigInteger firstsnowballQuality = 0;

            for (var i = 0; i < n; i++)
            {
                var snowballSnow = BigInteger.Parse(Console.ReadLine());
                var snowballTime = BigInteger.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());

                var snowballValue = BigInteger.Pow(snowballSnow / snowballTime , snowballQuality);

                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    firstSnowballSnow = snowballSnow;
                    firstSnowballTime = snowballTime;
                    firstsnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{firstSnowballSnow} : {firstSnowballTime} = {highestValue} ({firstsnowballQuality})");
        }
    }
}
