using System.IO;
using System.Globalization;

class Journal
{   
    public List<Entry> _entries;
    string filePath = "journal.csv";

    List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was something productive I got done today?",
        "What did I learn today?",
        "What was I most excited for today?",
        "What was the most fun thing I did today?",
        "What was the hardest thing I did today?"
    };

    public void AddEntry()
    {
        // creates a new Entry object
        Random rnd = new Random();
        int rndIndex = rnd.Next(_prompts.Count);

        Entry newEntry = new Entry();
        newEntry._date = DateTime.Today;
        newEntry._prompt = _prompts[rndIndex];

        Console.WriteLine(_prompts[rndIndex]);
        Console.Write("> ");
        newEntry._response = Console.ReadLine();

        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        // runs display for each Entry in the _entries list
        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine();
        }
    }

    public void Save()
    {
        // saves each entry in the journal to a file
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            outputFile.WriteLine("date`prompt`response");
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}`{e._prompt}`{e._response}");
            }
        }
    }

    public void Load()
    {
        // loads each entry from a file to the journal
        string[] lines = System.IO.File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            if (line == "date`prompt`response") {/* do nothing, it's the header */}
            else
            {
                string[] parts = line.Split("`");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];

                Entry newEntry = new Entry()
                {
                    _date = DateTime.ParseExact(date, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                    _prompt = prompt,
                    _response = response,
                };

                _entries.Add(newEntry);
            }
        }
    }

    public void Clear()
    {
        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            outputFile.WriteLine("date`prompt`response");
        }

        _entries = [];
    }
}