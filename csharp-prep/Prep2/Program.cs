using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        // How to calculate the grade percentage in C#

        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string scores = "";

        if (percent >= 90)
        {
            scores = "A";
        }
        else if (percent >= 80)
        {
            scores = "B";
        }
        else if (percent >= 70)
        {
            scores = "C";
        }
        else if (percent >= 60)
        {
            scores = "D";
        }
        else
        {
            scores = "F";
        }
        Console.WriteLine($"Your grade is: {scores}");

        if (percent >= 70)
        {
            Console.WriteLine("You Passed ");
        }
        else
        {
            Console.WriteLine("You failed, Please try again. ");
        }



    }
}