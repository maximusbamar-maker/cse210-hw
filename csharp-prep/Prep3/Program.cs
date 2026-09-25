using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int secretNum;
        string guessStr;
        int guessNum;
        string playing = "yes";

        while (playing == "yes")
        {   
            secretNum = randomGenerator.Next(1, 100);
            guessStr = "";
            guessNum = 0;

            while (guessNum != secretNum)
            {
                Console.Write("What is your guess? ");
                guessStr = Console.ReadLine();
                guessNum = int.Parse(guessStr);

                if (guessNum > secretNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNum < secretNum)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.Write("Do you want to play again? ");
            playing = Console.ReadLine();
        }
    }
}