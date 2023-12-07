using System;
using System.Collections.Generic;

namespace SchoolOOPS
{
    public class Student
    {
        public string Name { get; set; }

        public bool Search(string searchTerm)
        {
            return Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class Subject
    {
        public string SubjectName { get; set; }

        public bool Search(string searchTerm)
        {
            return SubjectName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class Teacher
    {
        public string TeacherName { get; set; }

        public bool Search(string searchTerm)
        {
            return TeacherName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase);
        }
    }

    public class SchoolDataManager
    {
        private List<Student> students;
        private List<Subject> subjects;
        private List<Teacher> teachers;

        public SchoolDataManager()
        {
            students = new List<Student>();
            subjects = new List<Subject>();
            teachers = new List<Teacher>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public List<Subject> GetAllSubjects()
        {
            return subjects;
        }

        public List<Teacher> GetAllTeachers()
        {
            return teachers;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SchoolDataManager schoolDataManager = new SchoolDataManager();

            // Adding sample data
            schoolDataManager.AddStudent(new Student { Name = "John" });
            schoolDataManager.AddSubject(new Subject { SubjectName = "Maths" });
            schoolDataManager.AddTeacher(new Teacher { TeacherName = "Mr. Smith" });

            // Retrieving and displaying data
            Console.WriteLine("Students:");
            foreach (var student in schoolDataManager.GetAllStudents())
            {
                Console.WriteLine($"- {student.Name}");
            }

            Console.WriteLine("\nSubjects:");
            foreach (var subject in schoolDataManager.GetAllSubjects())
            {
                Console.WriteLine($"- {subject.SubjectName}");
            }

            Console.WriteLine("\nTeachers:");
            foreach (var teacher in schoolDataManager.GetAllTeachers())
            {
                Console.WriteLine($"- {teacher.TeacherName}");
            }
        }
    }
}
