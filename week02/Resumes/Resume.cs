using System;

namespace Resume
{
    public class Resume
    {
        public string member;
        public List<string> jobs = new List<string>();
        public string _name;

        public void Display()
        {
            System.Console.WriteLine($"Name: {_name}");
            System.Console.WriteLine("Jobs:");
            
            foreach(string job in jobs)
            {
                
                System.Console.WriteLine(job);
            }
        }
    }
}