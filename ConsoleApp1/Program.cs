using ConsoleApp1;

var gui = new GuiConsoleApp();
var clsMath = new MyMath();

string[] actions =
[
    "plus", "minus", "divide", "percent", "multiply", "sum", "min", "max", "factorial", "count", "sort",
    "percent with basic", "depercent", "square pow", "cube pow", "square root", "cube root"
];

gui.WriteActions(actions);
while (true)
{
    string action = gui.GetAction(actions);
    if (action == "exit")
    {
        return;
    }
    if (action == "plus")
    {
        var num1 = gui.GetDouble("Enter first number");
        var num2 = gui.GetDouble("Enter second number");
        var result = clsMath.Plus(num1, num2);
        Console.WriteLine($"{num1} + {num2} = {result}");
    }
    if (action == "minus")
    {
        var num1 = gui.GetDouble("Enter first number");
        var num2 = gui.GetDouble("Enter second number");
        var result = clsMath.Minus(num1, num2);
        Console.WriteLine($"{num1} - {num2} = {result}");
    }
    if (action == "divide")
    {
        var num1 = gui.GetDouble("Enter first number");
        var num2 = gui.GetDouble("Enter second number");
        var result = clsMath.Div(num1, num2);
        Console.WriteLine($"{num1} / {num2} = {result}");
    }
    if (action == "percent")
    {
        var number = gui.GetDouble("Enter number");
        var result = clsMath.Per(number);
        Console.WriteLine($"1% of {number} = {result}");
    }
    if (action == "multiply")
    {
        var num1 = gui.GetDouble("Enter first number");
        var num2 = gui.GetDouble("Enter second number");
        var result = clsMath.Mul(num1, num2);
        Console.WriteLine($"{num1} * {num2} = {result}");
    }
    if (action == "sum")
    {
        var nums = gui.GetArray("Enter numbers");
        var result = clsMath.Sum(nums);
        Console.WriteLine($"Sum = {result}");
    }
    if (action == "min")
    {
        var nums = gui.GetArray("Enter numbers");
        var result = clsMath.Min(nums);
        Console.WriteLine($"Min = {result}");
    }
    if (action == "max")
    {
        var nums = gui.GetArray("Enter numbers");
        var result = clsMath.Max(nums);
        Console.WriteLine($"Max = {result}");
    }
    if (action == "factorial")
    {
        var number = gui.GetDouble("Enter number");
        var result = clsMath.Factorial(number);
        Console.WriteLine($"{number}! = {result}");
    }
    if (action == "count")
    {
        var nums = gui.GetArray("Enter numbers");
        var result = clsMath.Count(nums);
        Console.WriteLine($"Count = {result}");
    }
    if (action == "sort")
    {
        var nums = gui.GetArray("Enter numbers");
        var descending = gui.GetBool("Sort by descending");
        var result = clsMath.Sort(nums, descending);
        Console.WriteLine($"Sorted = {String.Join(',', result)}");
    }
    if (action == "percent with basic")
    {
        var number = gui.GetDouble("Enter number");
        var basic = gui.GetDouble("Enter basic");
        var result = clsMath.Per(number, basic);
        Console.WriteLine($"{number} out of {basic} = {result}%");
    }
    if (action == "depercent")
    {
        var percent = gui.GetShort("Enter percent");
        var number = gui.GetDouble("Enter number");
        if (percent < 0 || percent > 100)
        {
            Console.WriteLine($"{percent} is out of range [0-100]");
        }
        else
        {
            var result = clsMath.Deper(percent, number);
            Console.WriteLine($"{percent}% of {number} = {result}");
        }
    }
    if (action == "square pow")
    {
        var number = gui.GetDouble("Enter number");
        var result = clsMath.SquarePow(number);
        Console.WriteLine($"{number}^2 = {result}");
    }
    if (action == "cube pow")
    {
        var number = gui.GetDouble("Enter number");
        var result = clsMath.CubePow(number);
        Console.WriteLine($"{number}^3 = {result}");
    }
    if (action == "square root")
    {
        var number = gui.GetDouble("Enter number");
        var result = clsMath.SquareRoot(number);
        Console.WriteLine($"Square root of {number} = {result}");
    }
    if (action == "cube root")
    {
        var number = gui.GetDouble("Enter number");
        var result = clsMath.CubeRoot(number);
        Console.WriteLine($"Cube root of {number} = {result}");
    }
}

