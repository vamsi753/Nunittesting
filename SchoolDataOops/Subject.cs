// Subject.cs in SchoolOOPS Project
using System;

public class Subject
{
    public string SubjectName { get; set; }

    // Constructor
    public Subject(string subjectName)
    {
        SubjectName = subjectName;
    }

    // Method to search for a subject by name
    public bool Search(string searchTerm)
    {
        // Case-insensitive comparison for simplicity
        return SubjectName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase);
    }
}
