namespace _08_MentorGroup
{
    using System;
    using System.Collections.Generic;

    public class MentorGroup
    {
        public static void Main()
        {
            var group = new Dictionary<string, Dictionary<List<DateTime>, List<string>>>();

            var input = Console.ReadLine();
            var name = String.Empty;

            while (input != "end of dates")
            {
                var nameAndDate = input.Split(' ', ',');
                name = nameAndDate[0];
                var currentDates = new List<DateTime>();

                for (var i = 1; i < nameAndDate.Length; i++)
                {
                    var currentDate = DateTime.ParseExact(nameAndDate[i], "dd/MM/yyyy",
                        System.Globalization.CultureInfo.InvariantCulture);
                    currentDates.Add(currentDate);
                }

                if (!group.ContainsKey(name))
                {
                    group.Add(name, new Dictionary<List<DateTime>, List<string>>());
                }

                group[name].Add(currentDates, new List<string>());

                currentDates.Clear();

                input = Console.ReadLine();
            }

            var commentsList = new List<string>();
            input = Console.ReadLine();

            while (input != "end of comments")
            {
                var nameAndComment = input.Split('-');
                name = nameAndComment[0];
                var comment = nameAndComment[1];

                if (group.ContainsKey(name))
                {
                    commentsList.Add(comment);
                    group[name].Add(new List<DateTime>(), commentsList);
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in group)
            {
                Console.WriteLine(kvp.Key);
                Console.Write("Comments:");

                foreach (var lists in kvp.Value.Values)
                {
                    Console.WriteLine(string.Join($"- \n", lists));
                }

                Console.WriteLine("Dates attended:");

                foreach (var lists in kvp.Value.Keys)
                {
                    foreach (var date in lists)
                    {
                        Console.WriteLine($"-- {date.Date}");
                    }
                }
            }
        }
    }
}