public class Teacher : Person
{
    private int _numCourses;
    private List<string>? _courses;

    public Teacher(string name, string address) : base(name, address)
    {

    }
    public bool AddCourse(string course)
    {
        int t = 0;
        foreach (var item in _courses)
        {
            if (item == course)
            {
                t++;
            }
        }
        if (t > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public bool RemoveCourse(string course)
    {
        int t = 0;
        foreach (var item in _courses)
        {
            if (item == course)
            {
                t++;
            }
        }
        if (t > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string ToString()
    {
        return $"Teacher: {base.ToString()}";
    }
}