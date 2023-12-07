// NUnitTests.cs in NUnitTesting Project
using NUnit.Framework;
using SchoolOOPS; // Adjust this to the correct namespace

[TestFixture]
public class NUnitTests
{
    Student student;
    Subject subject;
    Teacher teacher;

    [SetUp]
    public void Setup()
    {
        // Create instances of your classes before each test
        student = new Student();
        subject = new Subject();
        teacher = new Teacher();
    }

    [Test]
    public void TestStudentSearch()
    {
        // Arrange
        string search = "Ravi";

        // Act
        bool result = student.Search(search);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void TestSubjectSearch()
    {
        // Arrange
        string search = "Maths";

        // Act
        bool result = subject.Search(search);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void TestTeacherSearch()
    {
        // Arrange
        string search = "Ram";

        // Act
        bool result = teacher.Search(search);

        // Assert
        Assert.That(result, Is.True);
    }

    // Add more test methods as needed for other scenarios

    [TearDown]
    public void Teardown()
    {
        // Clean up or release resources after each test
        student = null;
        subject = null;
        teacher = null;
    }
}
