using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class FileEdit
{
    public static void FileSave(string filename, List<String> answers)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (string answer in answers)
            {
                writer.WriteLine(answer);
            }
        }
    }
    public static List<string> LoadFile(string filename)
    {
        List<string> answers = new List<string>(File.ReadAllLines(filename));

        return answers;
    }

}