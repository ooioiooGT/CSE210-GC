using System;

public class Resume{
    public string _gcName; 
    public List<Job> _gcJobs = new List<Job>(); 
    public void Display(){

       Console.WriteLine($"Name: {_gcName}");
       Console.WriteLine("Jobs:");
       foreach (Job job in _gcJobs ){
        job.Display();
       }

    }

}