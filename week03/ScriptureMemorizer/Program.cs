using System;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string choice = "null";
        string[] scriptures = {
            "C:/Users/21nat/OneDrive/Documents/Schoolwork/CSE_210/CSE_210_C-/week03/ScriptureMemorizer/Scriptures/2_nephi_2-25.txt",
            "C:/Users/21nat/OneDrive/Documents/Schoolwork/CSE_210/CSE_210_C-/week03/ScriptureMemorizer/Scriptures/alma_40-8.txt",
            "C:/Users/21nat/OneDrive/Documents/Schoolwork/CSE_210/CSE_210_C-/week03/ScriptureMemorizer/Scriptures/alma_53-20-21.txt",
            "C:/Users/21nat/OneDrive/Documents/Schoolwork/CSE_210/CSE_210_C-/week03/ScriptureMemorizer/Scriptures/mosiah_4-26.txt",
            "C:/Users/21nat/OneDrive/Documents/Schoolwork/CSE_210/CSE_210_C-/week03/ScriptureMemorizer/Scriptures/mosiah_16-7-9.txt",
            "C:/Users/21nat/OneDrive/Documents/Schoolwork/CSE_210/CSE_210_C-/week03/ScriptureMemorizer/Scriptures/mosiah_27-31.txt"
        };

        Random random = new Random();
        int indexFile = random.Next(scriptures.Length);
        string fileName = scriptures[indexFile];

        string scripture = Scriptures.OpenScripture(fileName);
        string[] words = Regex.Split(scripture, @"\W+");
        int indexWord = random.Next(words.Length);

        Console.WriteLine(Reference.GetReference(indexFile) + scripture);

        while(choice != "quit" && WordScripture.CheckBlankSpaces(words))
        {
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();

            if(choice == "")
            {
                Console.Clear();
                Console.WriteLine(WordScripture.MakeBlankSpace(words));
                Console.Clear();
                Console.WriteLine(WordScripture.MakeBlankSpace(words));
                Console.Clear();
                Console.WriteLine(WordScripture.MakeBlankSpace(words));
            }
        }
    }
}