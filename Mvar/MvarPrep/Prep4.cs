public class Prep4
{
    public void Run()
    {
        Mvar numbers = new Mvar(new List<Mvar>() {});
        Mvar numInput = new Mvar(1);
        Mvar sum = new Mvar(0);
        Mvar avg = new Mvar();
        Mvar max = new Mvar(0);
        Mvar pos_min = new Mvar(0);

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (numInput.Val() != 0)
        {
            Console.Write("Enter number: ");
            numInput.Set(Console.ReadLine());
            if (numInput.Val() != 0)
            {
                numbers.Add(numInput.Val());
            }
        }

        foreach (Mvar num in numbers.Val())
        {
            sum.Add(num.Val());
            if (num.Val() > max.Val())
            {
                max = num;
            }
            if ((num.Val() < pos_min.Val() && num.Val() > 0) || (pos_min.Val() == 0 && num.Val() > 0))
            {
                pos_min = num;
            }
        }
        avg.Set(sum.Val() / numbers.Length());

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {pos_min}");

        Console.WriteLine("The sorted list is:");
        foreach (Mvar num in numbers.Val())
        {
            Console.WriteLine(num.Val());
        }
    }
}