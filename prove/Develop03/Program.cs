using System;

class Program
{
    static void Main()
    {
        // To Create a new scripture
        Scripture scripture = new Scripture("Alma 7:23", "And now I would that ye should be ahumble, and be bsubmissive and gentle; easy to be entreated; full of patience and long-suffering; being temperate in all things; being diligent in keeping the commandments of God at all times; asking for whatsoever things ye stand in need, both spiritual and temporal; always returning thanks unto God for whatsoever things ye do receive.");

        //Here is to clear the console screen and display the complete scripture
        Console.Clear();
        scripture.DisplayScripture();

        // To Prompt the user to press enter or type quit
        while (true)
        {
            Console.WriteLine("Press enter to hide a word or type quit to exit:");
            string userInput = Console.ReadLine();

            // If the user types quit, end the program
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else
            {
                //Here is to clear the console screen and hide a random word in the scripture
                Console.Clear();
                scripture.HideWord();
                scripture.DisplayScripture();

                // Checking if all words have been hidden
                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("Congratulations, you have memorized the scripture!");
                    break;
                }
            }
        }
    }
}
