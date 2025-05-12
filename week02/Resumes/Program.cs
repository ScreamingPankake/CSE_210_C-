using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job.Job job1 = new Job.Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._time = "2019-2022";
        string fullJob1 = $"{job1._jobTitle} ({job1._company}) {job1._time}";
        Job.Job job2 = new Job.Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._time = "2022-2023";
        string fullJob2 = $"{job2._jobTitle} ({job2._company}) {job2._time}";

        Resume.Resume resume = new Resume.Resume();
        resume._name = "Allison Rose";
        resume.jobs.Add(fullJob1);
        resume.jobs.Add(fullJob2);

        resume.Display();
    }
}