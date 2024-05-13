using System;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Major { get; set; }

    public Student(string name, int age, string gender, string major)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Major = major;
    }

    public override string ToString()
    {
        return $"Student Name: {Name}, Age: {Age}, Gender: {Gender}, Major: {Major}";
    }
}