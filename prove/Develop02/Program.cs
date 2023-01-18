using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        string[] prompts = {
            "What did you do today", "What did you learn today ?", "What was the strongest emotions you felt today?", "If you were to be elected as a President of a nation, What impact would you create for the people?",
            "What do you intend to achieve with your daily planing? "
        };
        string[] responses = new string[prompts.Length];

        DateTime date = DateTime.Now;

        for (int i = 0; i < prompts.Length; i ++)
        {
            Console.Write(prompts[i] + ":");
	       responses[i] = Console.ReadLine();
        }

        using (StreamWriter writer = new StreamWriter("journal.csv", true))
        {
            writer.WriteLine("Date: " + date.ToString());
            for (int i = 0; i < prompts.Length; i ++)
            {
                writer.WriteLine(prompts[i] + ": " + responses[i]);
            }
        }
        Console.WriteLine("Your journal saved successfully!");
    }
}