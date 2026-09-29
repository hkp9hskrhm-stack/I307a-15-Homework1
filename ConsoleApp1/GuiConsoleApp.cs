namespace ConsoleApp1;

internal class GuiConsoleApp
{
    public double[] GetArray(double[] nums)
    {
        Console.Write("Enter numbers with \",\": ");
        var input = Console.ReadLine();
        if (input != null)
            nums = input.Split(',').Select(double.Parse).ToArray();

        return nums;
    }
}