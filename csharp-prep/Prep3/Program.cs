using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        // To allow the computer to generate a Random number
        // Random randomGenerator = new Random();
        //int magicNumber = randomGenerator.Next(1, 101);


        int guess = -1;
        while (guess != magicNumber)
        {
            Console.Write("What is your Guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Guess higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Guess lower");
            }
            else
            {
                Console.WriteLine("You guessed it right! ");
            }

        }
    }
}