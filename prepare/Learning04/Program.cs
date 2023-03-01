using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Uchenna Godstime", "Multiplication");
        Console.WriteLine(a.GetSummary());

        MathAssignment b = new MathAssignment("Endurance Irich", "Fraction", "6.5", "7-40");
        Console.WriteLine(b.GetSummary());
        Console.WriteLine(b.GetHomeworkList());

        WritingAssignment c = new WritingAssignment("Owunamanam", "Nigerial History", "The 2023 Election.");
        Console.WriteLine(c.GetSummary());
        Console.WriteLine(c.GetWritingInformation());
        
    }
}