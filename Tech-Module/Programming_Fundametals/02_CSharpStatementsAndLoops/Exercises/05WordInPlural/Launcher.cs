using System;
using System.Text;

public class Launcher
{
    public static void Main()
    {
        var noun = Console.ReadLine();
        Console.WriteLine(ReplaceLastLetters(noun));
    }

    private static string ReplaceLastLetters(string noun)
    {
        var wordInPlural = new StringBuilder();

        if (noun.EndsWith("y"))
        {
            wordInPlural.Append(noun.Remove(noun.Length - 1));
            wordInPlural.Append("ies");
        }
        else if (noun.EndsWith("o") || noun.EndsWith("ch") || noun.EndsWith("s")
                 || noun.EndsWith("sh") || noun.EndsWith("x") || noun.EndsWith("z"))
        {
            wordInPlural.Append(noun + "es");
        }
        else
        {
            wordInPlural.Append(noun + "s");
        }

        return wordInPlural.ToString();
    }
}