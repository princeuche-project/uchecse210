using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        // To define LIst in C#
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            // Ask the user for their number
            Console.Write("What is your number (0 to Stop) ");
            string userinput = Console.ReadLine();
            userNumber = int.Parse(userinput);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        // To sum the numbers in the List
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;

        }
        Console.WriteLine($"The sun is {sum}");

        // Getting the Average number in C#
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        // To get the Max Number in the LIst
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}