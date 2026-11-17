public class Prep3
{
    public void Run()
    {
        Random randomGenerator = new Random();
        Mvar secretNum = new Mvar();
        Mvar guessNum = new Mvar();
        Mvar playing = new Mvar("Y");

        while (playing.Val() == "Y")
        {   
            secretNum.Set(randomGenerator.Next(1, 100));
            guessNum.Set(0);

            while (guessNum.Val() != secretNum.Val())
            {
                Console.Write("What is your guess? ");
                guessNum.Set(Console.ReadLine());

                if (guessNum.Val() > secretNum.Val())
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNum.Val() < secretNum.Val())
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.Write("Do you want to play again? (Y/N) ");
            playing.Set(Console.ReadLine());
        }
    }
}