using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Software Engineer";
       job1._comapny = "Microsoft";
       job1._startYear = 2020;
       job1._endYear = 2022;

       Job job2 = new Job(); 
       job2._jobTitle = "Web Developer";
       job2._comapny = "Apple";
       job2._startYear = 2023;
       job2._endYear = 2025;

       Resume myResume = new Resume();
       myResume._name = "Prince Okoi";

       myResume._jobs.Add(job1);
       myResume._jobs.Add(job2);

       //Call Display Method
       myResume.DisplayResume();
    }
}