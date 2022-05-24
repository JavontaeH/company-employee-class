using System;

public class Employee
{

    // Some readonly properties (let's talk about gets, baby)
    public string FirstName { get; }
    public string LastName { get; }
    public string Title { get; }

    public DateTime StartDate { get; }
    public Employee(string firstName, string lastName, string title, DateTime startdate)
    {
        FirstName = firstName;
        LastName = lastName;
        Title = title;
        StartDate = startdate;
    }
}
