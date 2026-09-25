using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        String numInput = "";
        int sum = 0;
        int avg;
        int max = 0;
        int pos_min = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (numInput != "0")
        {
            Console.Write("Enter number: ");
            numInput = Console.ReadLine();
            if (numInput != "0")
            {
                numbers.Add(int.Parse(numInput));
            }
        }

        foreach (int num in numbers)
        {
            sum += num;
            if (num > max)
            {
                max = num;
            }
            if ((num < pos_min && num > 0) || (pos_min == 0 && num > 0))
            {
                pos_min = num;
            }
        }
        avg = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {pos_min}");

        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}