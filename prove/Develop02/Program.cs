using System;

class Program {
    static void Main(string[] args) {
        Journal journal = new Journal();
        bool running = true;
        while (running) {
        Console.WriteLine("Journal Program");
        Console.WriteLine("1. Write new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Load journal from file");
        Console.WriteLine("4. Save journal to file");
        Console.WriteLine("5. Exit program");
        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();

        switch (choice) {
            case "1":
                journal.AddEntry();
                break;
            case "2":
                journal.DisplayJournal();
                break;
            case "3":
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.LoadJournal(filename);
                break;
            case "4":
                Console.Write("Enter filename: ");
                filename = Console.ReadLine();
                journal.SaveJournal(filename);
                break;
            case "5":
                running = false;
                break;
            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }
    }
}
}
