using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
    public int Age
    {
        get

        {
            int currentYear = DateTime.Now.Year;
            return currentYear - YearOfBirth;
        }
    }
}