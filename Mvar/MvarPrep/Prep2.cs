public class Prep2
{
    public void Run()
    {
        Console.Write("What is your grade percentage? ");
        Mvar grade = new Mvar(Console.ReadLine());
        Mvar letter = new Mvar();

        if (grade.Val() >= 90)
        {
            letter.Set("A");
        }
        else if (grade.Val() >= 80)
        {
            letter.Set("B");
        }
        else if (grade.Val() >= 70)
        {
            letter.Set("C");
        }
        else if (grade.Val() >= 60)
        {
            letter.Set("D");
        }
        else
        {
            letter.Set("F");
        }

        if (letter.Val() != "F")
        {
            Mvar secondDigit = new Mvar(grade.Val() % 10);
            
            if (secondDigit.Val() >= 7 && letter.Val() != "A")
            {
                letter.Add("+");
            }
            else if (secondDigit.Val() <= 3)
            {
                letter.Add("-");
            }
        }

        Console.WriteLine($"You have an {letter.Val()}");

        if (grade.Val() >= 70)
        {
            Console.WriteLine("Good job!");
        }
        else
        {
            Console.WriteLine("You got this");
        }
    }
}