namespace _05.ShortWordsSorted
{
    using System;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            char[] separators = new char[]
                {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};

            var wordsList = Console.ReadLine()
                .ToLower()
                .Split(separators)
                .ToList();

            var result = wordsList
                .Where(w => w != "" && w.Length < 5)
                .OrderBy(w => w)
                .Distinct().ToList();

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
