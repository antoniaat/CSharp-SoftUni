namespace _02_Worm_Ipsum
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class WormIpsum
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stringOutput = new StringBuilder();

            var regex = new Regex(@"^([A-Z][^\.]+?\.){1,1}$");

            while (input != "Worm Ipsum")
            {
                if (input != null && regex.Match(input).Success)
                {
                    var inputLine = input.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

                    for (var i = 0; i < inputLine.Length; i++)
                    {
                        var count = CharacterCount.Count(inputLine[i]);
                        var maxCharLenght = 0L;
                        var ch = '\0';
                        var wordLenght = 0;

                        foreach (var character in count)
                        {
                            if (character.Value < 2) continue;
                            var curCharLenght = character.Value;

                            if (curCharLenght <= maxCharLenght) continue;
                            maxCharLenght = curCharLenght;
                            ch = character.Key;
                            wordLenght = inputLine[i].Length;
                        }

                        if (maxCharLenght >= 2)
                        {
                            var replacer = string.Empty;

                            for (var j = 0; j < wordLenght; j++)
                            {
                                replacer += ch;
                            }

                            if (i == inputLine.Length - 1)
                            {
                                stringOutput.Append(replacer);
                            }
                            else
                            {
                                stringOutput.Append(replacer + " ");
                            }
                        }

                        else
                        {
                            if (i == inputLine.Length - 1)
                            {
                                stringOutput.Append(inputLine[i]);
                            }
                            else
                            {
                                stringOutput.Append(inputLine[i] + " ");
                            }
                        }

                        if (i == inputLine.Length - 1)
                        {
                            stringOutput.Append("." + "\n");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(stringOutput.ToString());
        }
    }

    public class CharacterCount
    {
        public static SortedDictionary<char, long> Count(string stringToCount)
        {
            var characterCount = new SortedDictionary<char, long>();

            foreach (var character in stringToCount)
            {
                if (!characterCount.ContainsKey(character))
                {
                    characterCount.Add(character, 1);
                }
                else
                {
                    characterCount[character]++;
                }
            }

            return characterCount;
        }
    }
}