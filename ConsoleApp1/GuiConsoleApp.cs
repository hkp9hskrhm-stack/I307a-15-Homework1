namespace ConsoleApp1;

internal class GuiConsoleApp
{
    public void WriteActions(string[] actions)
    {
        foreach (var action in actions)
        {
            Console.WriteLine($"{actions.IndexOf(action) + 1} – {action}");
        }
        Console.WriteLine("Use 0 for exit program");
    }
    
    public string GetAction(string[] actions)
    {
        Console.Write("Enter action: ");
        var input = Console.ReadLine();
        if (input != null)
        {
            if (input == "0") return "exit";
            return actions[int.Parse(input) - 1];
        }

        return "";
    }
    
    public short GetShort(string text)
    {
        if (text.Length == 0)
            text = "Enter short number";
        
        Console.Write($"{text}: ");
        var input = Console.ReadLine();
        if (input != null)
            return short.Parse(input);

        return 0;
    }
    
    public double GetDouble(string text)
    {
        if (text.Length == 0)
            text = "Enter double number";

        Console.Write($"{text}: ");
        var input = Console.ReadLine();
        if (input != null)
            return double.Parse(input);

        return 0;
    }
    
    public bool GetBool(string text)
    {
        Console.Write($"{text} [y/n]: ");
        var input = Console.ReadLine();
        if (input != null)
            return input.ToLower() == "y";

        return false;
    }

    public double[] GetArray(string text)
    {
        if (text.Length == 0)
            text = "Enter numbers with \",\"";
        
        Console.Write($"{text} (with \",\"): ");
        var input = Console.ReadLine();
        if (input != null)
            return input.Split(',').Select(double.Parse).ToArray();

        return [];
    }
}