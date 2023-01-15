using System;

class Program
{
   // private const string V = "2021";
   // private const string V1 = "Computer Engineering";

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Job job1 = new Job();
        job1._jobTitle = "Web Developer";
        job1._company = "Empower Energy Solution";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Preferred Guard Service";
        job2._startYear = 2020;
        job2._endYear = 2021;

        Resume myResume = new Resume();
        myResume._name = "Uchenna Godstime";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();


    }
}