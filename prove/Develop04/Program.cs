using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Ollie", "Surrealist Canadian Sports Reviews" );
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("ollie", "French Fries", "4.5", "11-14");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Ollie", "Ancient Proverbs", "How Sumerians Roasted Eachother");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
}