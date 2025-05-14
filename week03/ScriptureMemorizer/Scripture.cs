using System;
using System.IO;

public class Scriptures
{
    public static string OpenScripture(string filePath)
    {
        string content = File.ReadAllText(filePath);
        
        return content;
    }
}