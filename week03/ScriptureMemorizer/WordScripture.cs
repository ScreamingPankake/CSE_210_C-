using System;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

public class WordScripture
{

    public static string MakeBlankSpace(string[] words)
    {
        Random random = new Random();
        int index = random.Next(words.Length);
        string blankWord = words[index];

        string blank = new string('_', blankWord.Length);

        words[index] = blank;
        string sentence = string.Join(" ", words);
        return sentence;
    }

    public static bool CheckBlankSpaces(string[] words)
    {
        bool hasRealWords = Regex.IsMatch(MakeBlankSpace(words), @"\b(?!_+\b)\w+\b");

        return hasRealWords;
    }
}