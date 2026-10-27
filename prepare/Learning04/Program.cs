using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathHomework = new MathAssignment("Maximus Amar", "Linear Algebra", "2.4", "1-10");
        WritingAssignment englishHomework = new WritingAssignment("Maximus Amar", "Shakespeare", "The meaning of King Lear");

        Console.WriteLine(mathHomework.GetHomeworkList());
        Console.WriteLine(englishHomework.GetWritingInformation());
    }
}