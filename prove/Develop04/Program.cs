// I was creative by making the questions not repeat during a session until all of them have been asked.
// This does not apply to the prompts (it does apply to the questions about the prompts and the questions in the listing activity.)

using System;

class Program
{
    static void Main(string[] args)
    {
        List<String> reflectionPrompts = new List<String>
        {
            "Think of something hard that you accomplished.",
            "Think about a time when you did something good.",
            "Think of a time when you did what was right even though nobody was watching.",
            "Think about an achievement that you are proud of."
        };

        List<String> reflectionQuestions = new List<String>
        {
            "How did it make you feel?",
            "Why was this experience meaningful",
            "What did you feel like before you began?",
            "What did you feel like after you finished?",
            "Why did you do it?",
            "What obstacles did you overcome during this experience?",
            "What did this experience teach you?",
            "What was the most importaint part of this experience?",
            "Did anyone help you?"
        };

        List<String> listingQuestions = new List<String>
        {
            "What are things you want to do?",
            "Who are people that have inspired you?",
            "What have you succeeded at?",
            "What scriptures help you be better?",
            "What have you learned recently?"
        };

        Breathing breathingActivity = new Breathing("Breathing Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Reflection reflectionActivity = new Reflection("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", reflectionQuestions, reflectionPrompts);
        Listing listingActivity = new Listing("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listingQuestions);

        Boolean running = true;
        String choice;

        while(running)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            Console.Clear();

            if (choice == "1")
            {   
                breathingActivity.RunActivity();
            }
            else if (choice == "2")
            {
                reflectionActivity.RunActivity();
            }
            else if (choice == "3")
            {
                listingActivity.RunActivity();
            }
            else if (choice == "4")
            {
                running = false;
                Console.WriteLine("Goodbye. I hope to see you again.");
                Thread.Sleep(2000);
            }
            
            Console.Clear();
        }
    }
}