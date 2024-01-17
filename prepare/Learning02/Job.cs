// Job.cs

using System;

public class Job
{
    // Member variables
    private string _jobTitle;
    private string _companyName;
    private DateTime _startDate;
    private DateTime _endDate; // Added member variable for end date

    // Constructor
    public Job(string jobTitle, string companyName, DateTime startDate, DateTime endDate)
    {
        _jobTitle = jobTitle;
        _companyName = companyName;
        _startDate = startDate;
        _endDate = endDate;
    }

    // Properties
    public string JobTitle
    {
        get { return _jobTitle; }
        set { _jobTitle = value; }
    }

    public string CompanyName
    {
        get { return _companyName; }
        set { _companyName = value; }
    }

    public DateTime StartDate
    {
        get { return _startDate; }
        set { _startDate = value; }
    }

    public DateTime EndDate
    {
        get { return _endDate; }
        set { _endDate = value; }
    }

    // Display method
    public void DisplayJobDetails()
    {
        Console.WriteLine($"Job Title: {_jobTitle}");
        Console.WriteLine($"Company Name: {_companyName}");
        Console.WriteLine($"Start Date: {_startDate.ToShortDateString()}");
        Console.WriteLine($"End Date: {_endDate.ToShortDateString()}");
    }
}
