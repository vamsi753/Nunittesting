// Student.cs in SchoolOOPS Project
using System;

public class Student
{
    public string Name { get; set; }

    // Constructor
    public Student(string name)
    {
        Name = name;
    }

    // Method to search for a student by name
    public bool Search(string searchTerm)
    {
        // Case-insensitive comparison for simplicity
        return Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase);
    }
}
