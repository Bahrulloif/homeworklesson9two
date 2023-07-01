var student = new Student("Jeky", "Sherozi32");
System.Console.WriteLine(student.ToString());
student.AddCourseGrade("Fizika", 5);
student.AddCourseGrade("Himiya", 3);
student.AddCourseGrade("Algebra", 4);
student.PrintGrades();
System.Console.WriteLine(student.GetAverageGrade());
System.Console.WriteLine(student.GetAddress());
System.Console.WriteLine(student.GetName());
student.SetAddress("Lohuti12");
System.Console.WriteLine(student.GetAddress());

var teacher=new Teacher("Juma", "Gafurov20");
teacher.AddCourse("Algebra");
System.Console.WriteLine(teacher.AddCourse("Fizika"));
System.Console.WriteLine(teacher.GetAddress());
System.Console.WriteLine(teacher.GetName());
teacher.SetAddress("Niyozi43");
System.Console.WriteLine(teacher.GetAddress());
System.Console.WriteLine(teacher.RemoveCourse("Fizika"));

