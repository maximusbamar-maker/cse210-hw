// The program has a menu asking the user which of the scriptures they want to memorize
// A Hidden word is never chosen as the word to hide so 3 words are always hidden each round
// The program will end on quit, or if enter is pressed while all words are hidden

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        string filePath = "scriptures.csv";

        string[] lines = System.IO.File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string[] refParts = parts[0].Split("`");
            string[] passageParts = parts[1].Split(" ");

            string book = refParts[0];
            int chapter = int.Parse(refParts[1]);
            int start = int.Parse(refParts[2]);
            Reference newReference;
            if (refParts.Count() == 4)
            {   
                int end = int.Parse(refParts[3]);
                newReference = new Reference(book, chapter, start, end);
            }
            else
            {
                newReference = new Reference(book, chapter, start);
            }

            List<Word> newPassage = new List<Word>();
            foreach (string word in passageParts)
            {
                Word newWord = new Word(word);
                newPassage.Add(newWord);
            }

            Scripture newScripture = new Scripture(newReference, newPassage);
            scriptures.Add(newScripture);
        }

        
        Console.WriteLine("Choose a passage to memorize");

        int len = scriptures.Count();
        
        for (int i=0; i<len; i++)
        {
            Console.Write($"[{i+1}]");
            scriptures[i].DisplayReference();
        }
        Console.Write("> ");
        string userInput = Console.ReadLine();
        int userNum = int.Parse(userInput) - 1;

        Boolean memorizing = true;
        Boolean allHidden = false;

        Scripture script = scriptures[userNum];
        while (memorizing)
        {
            script.Display();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            Console.Write("> ");
            userInput = Console.ReadLine();

            if (userInput == "quit" || allHidden)
            {
                memorizing = false;
            }
            else
            {
                allHidden = script.HideWords(3);
            }
        }
    }
}