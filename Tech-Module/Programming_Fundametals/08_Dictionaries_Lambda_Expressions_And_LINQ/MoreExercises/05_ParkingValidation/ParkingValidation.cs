namespace _05_ParkingValidation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ParkingValidation
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, string>();

            for (var i = 0; i < n; i++)
            {
                var count = 0;

                var input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (input[0] == "register")
                {
                    var username = input[1];
                    var licensePlateNumber = input[2];

                    if (licensePlateNumber.Length == 8)
                    {
                        var pattern = @"([A-Z]{2})([1-9]+)([A-Z]{2})";
                        var regex = new Regex(pattern);
                        var matches = regex.Matches(licensePlateNumber);

                        foreach (Match match in matches)
                        {
                            if (!match.Success) continue;

                            count++;

                            if (!dict.ContainsKey(username))
                            {
                                if (!dict.ContainsValue(licensePlateNumber))
                                {
                                    dict.Add(username, licensePlateNumber);
                                    Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                                }
                                else
                                {
                                    Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                                }
                            }

                            else
                            {
                                Console.WriteLine(
                                    $"ERROR: already registered with plate number {licensePlateNumber}”");
                            }
                        }

                        if (count == 0)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                        }
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    var username = input[1];

                    if (!dict.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        dict.Remove(username);
                        Console.WriteLine($"user {username} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
