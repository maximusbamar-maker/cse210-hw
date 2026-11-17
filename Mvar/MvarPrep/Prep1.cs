public class Prep1
{
    public void Run()
    {
        Mvar firstName = new Mvar();
        Mvar lastName = new Mvar();

        Console.Write("What is your first name? ");
        firstName.Set(Console.ReadLine());

        Console.Write("What is your last name? ");
        lastName.Set(Console.ReadLine());

        Console.WriteLine($"The name's {lastName.Val()}, {firstName.Val()} {lastName.Val()}.");
    }
}