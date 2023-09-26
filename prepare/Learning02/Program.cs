using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        Job job1 = new Job();
        job1.JobTitle = "software engineer";
        job1.Company = "Apple";
        job1.StartYear = 1524;
        job1.EndYear = 2192;
        
        Job job2 = new Job();
        job2.JobTitle = "Pear Eater";
        job2.Company = "Microsoft";
        job2.StartYear = 1000;
        job2.EndYear = 2023;




        Resume MyResume = new Resume{
            Name = "Owen Chamberlain"
        };
        MyResume.Jobs.Add(job1);
        MyResume.Jobs.Add(job2);

        MyResume.Display();



    }
}