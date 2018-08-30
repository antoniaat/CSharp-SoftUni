using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_Files
{
    using System;

    public class Files
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var allLines = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                allLines.Add(input);
            }

            var extensionInRoot = Console.ReadLine()
                .Split(new string[] { " in " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var searchedRoot = extensionInRoot[1];
            var searchedFileExtension = extensionInRoot[0];

            var resultDictionary = new Dictionary<string, long>();

            for (int i = 0; i < allLines.Count; i++)
            {
                string pattern = @"^([^\\]+).*\\(.+);([0-9]+)";

                var regex = Regex.Matches(allLines[i], pattern);
                try
                {

                    foreach (Match match in regex)
                    {
                        var root = match.Groups[1].ToString();
                        var extension = match.Groups[2].ToString();
                        var fileSize = long.Parse(match.Groups[3].ToString());

                        var fileExtension = extension.Split('.').ToList();
                        var finalExtension = fileExtension[1];

                        if (root == searchedRoot)
                        {
                            if (finalExtension == searchedFileExtension)
                            {
                                if (resultDictionary.ContainsKey(extension))
                                {
                                    resultDictionary[extension] = fileSize;
                                }
                                else
                                {
                                    resultDictionary.Add(extension, fileSize);
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("tt");
                }
            }


            foreach (var kvp in resultDictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} KB");
            }
            if (resultDictionary.Count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
