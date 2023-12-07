// Teacher.cs in SchoolOOPS Project
using System;

public class Teacher
{
    public string TeacherName { get; set; }

    // Constructor
    public Teacher(string teacherName)
    {
        TeacherName = teacherName;
    }

    // Method to search for a teacher by name
    public bool Search(string searchTerm)
    {
        // Case-insensitive comparison for simplicity
        return TeacherName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase);
    }
}
