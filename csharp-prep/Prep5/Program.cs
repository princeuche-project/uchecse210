using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        // Display the C# functions
        
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);


        // To create a welcome message function
        static void DisplayMessage()
        {
            Console.WriteLine("Welcom to the program! ");
        }
        // To ask and reture for the user name funtion
        static string PromptUserName()
        {
            Console.Write("Enter your name ");
            string name = Console.ReadLine();

            return name;
        }

        // To ask and reture for the user number funtion
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        // To square and return the user number function
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        // To display the user name and square number function
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }



    }
}