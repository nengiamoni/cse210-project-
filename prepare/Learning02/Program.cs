// Program.cs

using System;

class Program
{
    static void Main()
    {
        // Create job1 instance and set member variables
        Job job1 = new Job("Software Engineer", "ABC Tech", DateTime.Parse("2022-01-17"), DateTime.Parse("2023-01-17"));

        // Create job2 instance and set member variables
        Job job2 = new Job("Data Analyst", "XYZ Corp", DateTime.Parse("2022-02-01"), DateTime.Parse("2023-02-01"));

        // Create a new instance of the Resume class
        Resume myResume = new Resume("Nengi Amoni");

        // Add the two jobs to the list of jobs in the resume object
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the entire resume details
        myResume.DisplayResumeDetails();
    }
    
}
