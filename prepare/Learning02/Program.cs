using System;

class Program
{   
    
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._gcJobTitle = "Software Engineer";
        job1._gcCompany = "Microsoft";
        job1._gcStartYear = 2022;
        job1._gcEndYear = 2023;
        // job1.Display();
        Job job2 = new Job();
        job2._gcJobTitle = "Computer science";
        job2._gcCompany = "Apple";
        job2._gcStartYear = 2023;
        job2._gcEndYear = 2024;
        // job2.Display();
        Resume resume1 = new Resume();
        resume1._gcName = "Gilber Chen";
        resume1._gcJobs.Add(job1);
        resume1._gcJobs.Add(job2);
        resume1.Display();
        
    }
}