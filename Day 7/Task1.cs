using System;

abstract class Student
{
    private string name;
    private string id;
    public string GetName(){
        return name;
    }
    public void SetName(string value){
        name = value;
    }
    public string GetId(){
        return id;
    }
    public void SetId(string value){
        id = value;
    }
    public abstract int Marks();
    public abstract double Percentage();
    public static string CourseSubjects;
    public static string Result;
}
class StudentMain : Student{
    private int marks;
    private double percentage;
    public void SetMarks(int value){
        marks = value;
    }
    public void SetPercentage(double value){
        percentage = value;
    }
    public override int Marks(){
        return marks;
    }
    public override double Percentage(){
        return percentage;
    }
}
class Task1
{
    static void Main(string[] args)
    {
        StudentMain student1 = new StudentMain();
        student1.SetName("Sandeep");
        student1.SetId("21481A05D5");
        student1.SetMarks(85);
        student1.SetPercentage(85.0);

        StudentMain student2 = new StudentMain();
        student2.SetName("Shyam");
        student2.SetId("21481A05G1");
        student2.SetMarks(90);
        student2.SetPercentage(90.0);

        Student.CourseSubjects = "DS, CPP, FE, MERN, OS";
        Student.Result = "Pass";

        Console.WriteLine("Student 1: Name = " + student1.GetName() + ", Id = " + student1.GetId() + ", Marks = " + student1.Marks() + ", Percentage = " + student1.Percentage());
        Console.WriteLine("Student 2: Name = " + student2.GetName() + ", Id = " + student2.GetId() + ", Marks = " + student2.Marks() + ", Percentage = " + student2.Percentage());
        Console.WriteLine("Course Subjects: " + Student.CourseSubjects);
        Console.WriteLine("Result: " + Student.Result);
    }
}
