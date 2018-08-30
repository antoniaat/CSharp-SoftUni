namespace _01_AnonymousDownsite
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class AnonymousDownsite
    {
        public static void Main()
        {
            var n = BigInteger.Parse(Console.ReadLine());
            var securityKey = BigInteger.Parse(Console.ReadLine());
            var totalMoneyLoss = 0M;
            var sites = new List<string>();

            for (var i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var siteName = inputLine[0];
                var siteVisits = decimal.Parse(inputLine[1]);
                var siteCommercialPricePerVisit = decimal.Parse(inputLine[2]);
                sites.Add(siteName);

                var siteLoss = siteVisits * siteCommercialPricePerVisit;
                totalMoneyLoss += siteLoss;
            }

            Console.WriteLine(string.Join("\n", sites));
            Console.WriteLine($"Total Loss: {totalMoneyLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey, sites.Count)}");
        }
    }
}