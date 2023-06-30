public class Student : Person
{
    private int _numCourses;
    private List<string> _courses;
    private List<int> _grades;

    public Student(string name, string address) : base(name, address)
    {

    }
    public void AddCourseGrade(string course, int grade)
    {
        _courses.Add(course);
        _grades.Add(grade);
    }
    public void PrintGrades()
    {
        foreach (var grade in _grades)
        {
            System.Console.WriteLine($"{grade}, ");
        }
    }
    public double GetAverageGrade()
    {
        return _grades.Average();
    }
    public override string ToString()
    {
        return $"Student: {base.ToString()}";

    }
}
