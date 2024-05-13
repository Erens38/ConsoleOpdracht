using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Creating student objects
        Student myInfo = new Student("John Doe", 25, "Male", "Computer Science");
        Student classmate1 = new Student("Alice Smith", 24, "Female", "Electrical Engineering");
        Student classmate2 = new Student("Bob Johnson", 23, "Male", "Physics");

        // Creating docent objects
        Docent teacher1 = new Docent("Dr. Brown", 40, "Male", "Computer Science");
        Docent teacher2 = new Docent("Prof. Green", 50, "Female", "Mathematics");

        // Displaying student information
        Console.WriteLine("Student Information:");
        Console.WriteLine(myInfo.ToString());
        Console.WriteLine(classmate1.ToString());
        Console.WriteLine(classmate2.ToString());

        // Displaying docent information
        Console.WriteLine("\nDocent Information:");
        Console.WriteLine(teacher1.ToString());
        Console.WriteLine(teacher2.ToString());
    }
}
