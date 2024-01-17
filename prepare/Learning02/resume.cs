// Resume.cs

using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    private string _personName;
    private List<Job> _jobList;

    // Constructor
    public Resume(string personName)
    {
        _personName = personName;
        _jobList = new List<Job>();
    }

    // Properties
    public string PersonName
    {
        get { return _personName; }
        set { _personName = value; }
    }

    public List<Job> JobList
    {
        get { return _jobList; }
    }

    // Add a job to the resume
    public void AddJob(Job job)
    {
        _jobList.Add(job);
    }

    // Display resume details
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Resume of {_personName}");

        if (_jobList.Count > 0)
        {
            Console.WriteLine("Work Experience:");
            foreach (var job in _jobList)
            {
                job.DisplayJobDetails();
                Console.WriteLine(); // Add a newline between jobs
            }
        }
        else
        {
            Console.WriteLine("No work experience available.");
        }
    }
}
