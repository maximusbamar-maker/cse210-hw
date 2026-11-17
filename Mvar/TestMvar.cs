public class TestMvar
{
    public void Run()
    {
        Mvar var = new Mvar();

        var.Set("1");
        Console.WriteLine($"Type: {var.Type()} - Data: {var.Val()}");
        if (var.Val() == 1)
        {
            Console.WriteLine("It's an int");
        }
        Console.WriteLine();

        var.Set("2.2");
        Console.WriteLine($"Type: {var.Type()} - Data: {var.Val()}");
        if (var.Val() == 2.2)
        {
            Console.WriteLine("It's a double");
        }
        Console.WriteLine();

        var.Set("true");
        Console.WriteLine($"Type: {var.Type()} - Data: {var.Val()}");
        if (var.Val())
        {
            Console.WriteLine("It's a bool");
        }
        Console.WriteLine();

        var.Set("false");
        Console.WriteLine($"Type: {var.Type()} - Data: {var.Val()}");
        if (!var.Val())
        {
            Console.WriteLine("It's still a bool");
        }
        Console.WriteLine();

        var.Set("Hello Mvar World");
        Console.WriteLine($"Type: {var.Type()} - Data: {var.Val()}");
        if (var.Val() == "Hello Mvar World")
        {
            Console.WriteLine("It's a string");
        }
        Console.WriteLine();

        var.Set([1, 2, 3]);
        Console.WriteLine($"Type: {var.Type()} - Data: {var.AsString()}");
        Console.WriteLine();

        var.Set([1.1, 2.2, 3.3]);
        Console.WriteLine($"Type: {var.Type()} - Data: {var.AsString()}");
        Console.WriteLine();

        var.Set(["a", "b", "c"]);
        Console.WriteLine($"Type: {var.Type()} - Data: {var.AsString()}");
        Console.WriteLine();

        var.Set([true, false, true]);
        Console.WriteLine($"Type: {var.Type()} - Data: {var.AsString()}");
        Console.WriteLine(var.Length());
        Console.WriteLine();

        var.Set([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);
        Console.WriteLine($"Type: {var.Type()} - Data: {var.AsString()}");
        Console.WriteLine(var.Length());
        Console.WriteLine(var.Count());
        Console.WriteLine();

        float num = 2.1f;
        Mvar var2 = new Mvar(num);
        Console.WriteLine($"Type: {var2.Type()} - Data: {var2.Val()}");

        Mvar var3 = new Mvar([1, "a", true, 1.1]);
        Console.WriteLine($"Type: {var3.Type()} - Data: {var3.AsString()}");
        var3.Set(1);

        Mvar varEmpty = new Mvar([]);

        Mvar addToInt = new Mvar(1);
        addToInt.Add(1);
        Console.WriteLine(addToInt.Val());
        addToInt.Set(1);
        addToInt.Add(1.1);
        Console.WriteLine(addToInt.Val());
        addToInt.Set(1);
        addToInt.Add("yes");
        Console.WriteLine(addToInt.Val());
        addToInt.Set(1);
        addToInt.Add(false);
        Console.WriteLine(addToInt.Val());
        addToInt.Set(1);
        addToInt.Add([1, 2]);
        Console.WriteLine(addToInt.AsString());
        
        Mvar addToDouble = new Mvar(1.1);
        addToDouble.Add(1);
        Console.WriteLine(addToDouble.Val());
        addToDouble.Set(1.1);
        addToDouble.Add(1.1);
        Console.WriteLine(addToDouble.Val());
        addToDouble.Set(1.1);
        addToDouble.Add("yes");
        Console.WriteLine(addToDouble.Val());
        addToDouble.Set(1.1);
        addToDouble.Add(false);
        Console.WriteLine(addToDouble.Val());
        addToDouble.Set(1.1);
        addToDouble.Add([1, 2]);
        Console.WriteLine(addToDouble.AsString());

        Mvar addToString = new Mvar("yes");
        addToString.Add(1);
        Console.WriteLine(addToString.Val());
        addToString.Set("yes");
        addToString.Add(1.1);
        Console.WriteLine(addToString.Val());
        addToString.Set("yes");
        addToString.Add("yes");
        Console.WriteLine(addToString.Val());
        addToString.Set("yes");
        addToString.Add(false);
        Console.WriteLine(addToString.Val());
        addToString.Set("yes");
        addToString.Add([1, 2]);
        Console.WriteLine(addToString.AsString());

        Mvar addToBoolean = new Mvar(false);
        addToBoolean.Add(1);
        Console.WriteLine(addToBoolean.Val());
        addToBoolean.Set(false);
        addToBoolean.Add(1.1);
        Console.WriteLine(addToBoolean.Val());
        addToBoolean.Set(false);
        addToBoolean.Add("yes");
        Console.WriteLine(addToBoolean.Val());
        addToBoolean.Set(false);
        addToBoolean.Add(true);
        Console.WriteLine(addToBoolean.Val());
        addToBoolean.Set(false);
        addToBoolean.Add([1, 2]);
        Console.WriteLine(addToBoolean.AsString());

        Mvar addToList = new Mvar([1, 2]);
        addToList.Add(1);
        Console.WriteLine(addToList.AsString());
        addToList.Set([1, 2]);
        addToList.Add(1.1);
        Console.WriteLine(addToList.AsString());
        addToList.Set([1, 2]);
        addToList.Add("yes");
        Console.WriteLine(addToList.AsString());
        addToList.Set([1, 2]);
        addToList.Add(true);
        Console.WriteLine(addToList.AsString());
        addToList.Set([1, 2]);
        addToList.Add([3, 4]);
        Console.WriteLine(addToList.AsString());
        addToList.Set([[1, 2], [3, 4]]);
        addToList.Add([[5, 6]]);
        Console.WriteLine(addToList.AsString());
        addToList.Val()[0].Add(1);
        Console.WriteLine(addToList.AsString());
    }
}