using System;

public class Docent
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Subject { get; set; }

    public Docent(string name, int age, string gender, string subject)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Subject = subject;
    }

    public override string ToString()
    {
        return $"Docent Name: {Name}, Age: {Age}, Gender: {Gender}, Subject: {Subject}";
    }
}