 using System;
 
 //The base class for all activities
public abstract class Activity
{
    // The name of the activity
    public string Name { get; set; }

    // The description of the activity
    public string Description { get; set; }

    // The duration of the activity in seconds
    public int Duration { get; set; }

    // The method to run the activity
    public abstract void RunActivity();
}


// The class for the breathing activity
public class BreathingActivity : Activity
{
    // Override the RunActivity method from the base class
    public override void RunActivity()
    {
        // Show the starting message
        Console.WriteLine($"Starting {Name} which will last for {Duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        // Pause for a few seconds
        System.Threading.Thread.Sleep(3000);

        // Start the activity
        Console.WriteLine("Breathe in...");
        System.Threading.Thread.Sleep(Duration * 1000);
        Console.WriteLine("Breathe out...");
        System.Threading.Thread.Sleep(Duration * 1000);

        // Show the ending message
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Console.WriteLine("Thank you for participating.");
    }
}


// The class for the reflection activity
public class ReflectionActivity : Activity
{
    // The list of prompts
    public List<string> Prompts { get; set; }

    // The list of questions
    public List<string> Questions { get; set; }

    // Override the RunActivity method from the base class
    public override void RunActivity()
    {
        // Show the starting message
        Console.WriteLine($"Starting {Name} which will last for {Duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        // Pause for a few seconds
        System.Threading.Thread.Sleep(3000);

        // Get a random prompt
        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine(Prompts[promptIndex]);

        // Ask the questions
        for (int i = 0; i < Questions.Count; i++)
        {
            Console.WriteLine(Questions[i]);
            System.Threading.Thread.Sleep(Duration * 1000);

            // Show a spinner while the program is paused
            Console.CursorLeft = 0;
            Console.Write("|");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("/");
            System.Threading.Thread.Sleep(10000);
            Console.CursorLeft = 0;
            Console.Write("-");
            System.Threading.Thread.Sleep(1000);
            Console.CursorLeft = 0;
            Console.Write("\\");
            System.Threading.Thread.Sleep(1000);
        }

        // Show the ending message
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
        Console.WriteLine("Thank you for participating.");
    }
}


// The class for the listing activity
public class ListingActivity : Activity
{
    // The list of prompts
    public List<string> Prompts { get; set; }

    // Override the RunActivity method from the base class
    public override void RunActivity()
    {
        // Show the starting message
        Console.WriteLine($"Starting {Name} which will last for {Duration} seconds.");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("Prepare to begin...");

        // Pause for a few seconds
        System.Threading.Thread.Sleep(3000);

        // Get a random prompt
        Random random = new Random();
        int promptIndex = random.Next(0, Prompts.Count - 1);
        Console.WriteLine(Prompts[promptIndex]);

        // Give them a few seconds to think
        System.Threading.Thread.Sleep(Duration * 1000);

        // Ask them to start listing
        Console.WriteLine("Start listing...");
        int itemCount = 0;
        while (Duration > 0)
        {
            string input = Console.ReadLine();
            itemCount++;
            Duration--;
        }

        // Show the ending message
        Console.WriteLine("Good job!");
        Console.WriteLine($" Congratulations! You have completed the {Name} activity for {Duration} seconds and listed {itemCount} items.");
        Console.WriteLine("Thank you for participating.");
    }
}