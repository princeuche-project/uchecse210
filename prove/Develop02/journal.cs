using System;

class Entry {
    public string prompt;
    public string response;
    public DateTime date;

    public Entry(string prompt, string response, DateTime date) {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }
}

class Journal {
    public List<Entry> entries = new List<Entry>();
    public List<string> prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public void AddEntry() {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        string prompt = prompts[index];
        Console.WriteLine("Prompt: " + prompt);
        string response = Console.ReadLine();
        DateTime date = DateTime.Now;
        Entry newEntry = new Entry(prompt, response, date);
        entries.Add(newEntry);
        Console.WriteLine("Entry added!");
    }

    public void DisplayJournal() {
        if (entries.Count == 0) {
            Console.WriteLine("Empty Journal.");
        } else {
            for (int i = 0; i < entries.Count; i++) {
                Entry entry = entries[i];
                Console.WriteLine("Entry " + (i+1) + ":");
                Console.WriteLine("Prompt: " + entry.prompt);
                Console.WriteLine("Response: " + entry.response);
                Console.WriteLine("Date: " + entry.date);
                
            }
        }
    }

    public void LoadJournal(string filename) {
        if (File.Exists(filename)) {
            entries = new List<Entry>();
            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 3) {
                string prompt = lines[i];
                string response = lines[i+1];
                DateTime date = DateTime.Parse(lines[i+2]);
                Entry entry = new Entry(prompt, response, date);
                entries.Add(entry);
            }
            Console.WriteLine("Journal loaded from " + filename);
        } else {
            Console.WriteLine("File not found.");
        }
    }

    public void SaveJournal(string filename) {
        List<string> lines = new List<string>();
        for (int i = 0; i < entries.Count; i++) {
            Entry entry = entries[i];
            lines.Add(entry.prompt);
            lines.Add(entry.response);
            lines.Add(entry.date.ToString());
        }
        File.WriteAllLines(filename, lines);
        Console.WriteLine("Journal saved to" + filename);
}
}
