using System;

namespace Job
{
    public class Job
    {
        public string _jobTitle;
        public string _company;
        public string _time;

        public void Display()
        {
            System.Console.WriteLine($"{_jobTitle} ({_company}) {_time}");
        }
    }
}